using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLayout;

namespace SSCIMS
{
    public partial class FormStudentQuery : Form
    {
        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        public FormStudentQuery()
        {
            InitializeComponent();
        }

        private void FormStudentQuery_Load(object sender, EventArgs e)
        {
            txtClass.Enabled = false;
            txtProfession.Enabled = false;
            txtStuID.Enabled = false;
            txtStuName.Enabled = false;
            cbxSex.Enabled = false;
            txtTel.Enabled = false;
        }

        private void FormStudentQuery_Layout(object sender, LayoutEventArgs e)
        {
            eAutoSizeFormClass.controlAutoSize(this, false);
        }

        #region 事件区域

        private void cBStuID_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBStuID.Checked)
            {
                txtStuID.Enabled = true;
            }
            else
            {
                txtStuID.Enabled = false;
                txtStuID.Clear();
            }
        }

        private void cBStuName_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBStuName.Checked)
            {
                txtStuName.Enabled = true;
            }
            else
            {
                txtStuName.Enabled = false;
                txtStuName.Clear();
            }
        }

        private void cBSex_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBSex.Checked)
            {
                cbxSex.Enabled = true;
            }
            else
            {
                cbxSex.Enabled = false;
                cbxSex.SelectedIndex = -1;
            }
        }

        private void cBProfession_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBProfession.Checked)
            {
                txtProfession.Enabled = true;
            }
            else
            {
                txtProfession.Enabled = false;
                txtProfession.Clear();
            }
        }

        private void cBClass_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBClass.Checked)
            {
                txtClass.Enabled = true;
            }
            else
            {
                txtClass.Enabled = false;
                txtClass.Clear();
            }
        }

        private void cBTel_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBTel.Checked)
            {
                txtTel.Enabled = true;
            }
            else
            {
                txtTel.Enabled = false;
                txtTel.Clear();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string QueryString = null;
            if (cBStuID.Checked && txtStuID.Text.Length != 0)
            {
                QueryString = "StuID Like '%" + txtStuID.Text.ToString() + "%' and ";
            }
            if (cBStuName.Checked && txtStuName.Text.Length != 0)
            {
                QueryString = QueryString + "StuName Like '%" + txtStuName.Text.ToString() + "%' and ";
            }
            if (cBSex.Checked && cbxSex.SelectedIndex != -1)
            {
                QueryString = QueryString + "Sex = '" + cbxSex.SelectedItem.ToString() + "' and ";
            }
            if (cBProfession.Checked && txtProfession.Text.Length != 0)
            {
                QueryString = QueryString + "Profession Like '%" + txtProfession.Text.ToString() + "%' and ";
            }
            if (cBClass.Checked && txtClass.Text.Length != 0)
            {
                QueryString = QueryString + "Class = '" + txtClass.Text.ToString() + "' and ";
            }
            if (cBTel.Checked && txtTel.Text.Length != 0)
            {
                QueryString = QueryString + "Tel = '" + txtTel.Text.ToString() + "' and ";
            }
            if (QueryString != null)
            {
                QueryString = QueryString.Remove(QueryString.Length - 5);
            }
            else
            {
                QueryString = "";
            }
            OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();
            string ProjectionString = "StuID as 学号, StuName as 姓名, Sex as 性别, Profession as 专业, Class as 班级, Tel as 联系电话";
            dGVStudentQuery.DataSource = eOperationDatabaseClass.Query("Student", ProjectionString, QueryString);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cBClass.Checked = false;
            cBProfession.Checked = false;
            cBStuID.Checked = false;
            cBStuName.Checked = false;
            cBTel.Checked = false;
            cBSex.Checked = false;
            dGVStudentQuery.DataSource = null;
        }

        #endregion
    }
}
