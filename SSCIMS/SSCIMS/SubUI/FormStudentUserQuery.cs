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
    public partial class FormStudentUserQuery : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        public FormStudentUserQuery()
        {
            InitializeComponent();
        }

        #region 自定义函数

        public void Clear()
        {
            cBUserName.Checked = false;
            txtUserName.Clear();
            txtUserName.Enabled = false;
            cBCreateDate.Checked = false;
            rBSingle.Checked = false;
            cbxSingle.SelectedIndex = -1;
            cbxSingle.Enabled = false;
            dTPSingle.Value = DateTime.Now;
            dTPSingle.Enabled = false;
            rBIn.Checked = false;
            dTPInBegin.Value = DateTime.Now;
            dTPInBegin.Enabled = false;
            dTPInEnd.Value = DateTime.Now;
            dTPInEnd.Enabled = false;
            rBOut.Checked = false;
            dTPOutBegin.Value = DateTime.Now;
            dTPOutBegin.Enabled = false;
            dTPOutEnd.Value = DateTime.Now;
            dTPOutEnd.Enabled = false;
            btnCourseAllCancel.Enabled = false;
            btnCourseAllChoose.Enabled = false;
            btnResetPassword.Enabled = false;
            dGVStudentUserQuery.Visible = false;
            dGVStudentUserQuery.Columns[0].Visible = false;
        }

        #endregion

        private void FormStudentUserQuery_Layout(object sender, LayoutEventArgs e)
        {
            eAutoSizeFormClass.controlAutoSize(this, false);
        }

        private void FormStudentUserQuery_Load(object sender, EventArgs e)
        {
            DataGridViewColumn eDataGridViewColumn = new DataGridViewCheckBoxColumn();
            eDataGridViewColumn.HeaderText = "重置密码选择";
            dGVStudentUserQuery.Columns.Add(eDataGridViewColumn);
            Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dGVStudentUserQuery.Visible = true;
            eOperationDatabaseClass.eSqlstring = null;
            if (cBUserName.Checked)
            {
                eOperationDatabaseClass.eSqlstring = "UserName like '%" + txtUserName.Text.ToString() + "%' and ";
            }
            if (cBCreateDate.Checked)
            {
                if (rBSingle.Checked)
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "CreateDate " + cbxSingle.SelectedItem.ToString() + " '" + dTPSingle.Value.ToShortDateString() + "' and ";
                }
                if (rBIn.Checked)
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "CreateDate between '" + dTPInBegin.Value.ToShortDateString() + "' and '" + dTPInEnd.Value.ToShortDateString() + "' and ";
                }
                if (rBOut.Checked)
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "CreateDate not between '" + dTPOutBegin.Value.ToShortDateString() + "' and '" + dTPOutEnd.Value.ToShortDateString() + "' and ";
                }
            }
            eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "UserName !='admin'";
            eOperationDatabaseClass.ProjectString = "UserName as 用户名,CreateDate as 创建日期";
            dGVStudentUserQuery.DataSource = eOperationDatabaseClass.Query("[User]", eOperationDatabaseClass.ProjectString, eOperationDatabaseClass.eSqlstring);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string SetString = "('";
            for (int i = 0; i < dGVStudentUserQuery.Rows.Count; i++)
            {
                if (bool.Parse(dGVStudentUserQuery.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    SetString = SetString + dGVStudentUserQuery.Rows[i].Cells[1].Value.ToString().Trim() + "','";
                }
            }
            if (SetString != "('")
            {
                SetString = SetString.Remove(SetString.Length - 2);
                SetString = "UserName in " + SetString + ")";
                eOperationDatabaseClass.Update("[User]", SetString, "[Password] = UserName", true);
                Clear();
            }
            else
            {
                MessageBox.Show("请选择用户！");
            }
        }

        private void cBUserName_CheckStateChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = cBUserName.Checked;
            txtUserName.Clear();
        }

        private void cBCreateDate_CheckStateChanged(object sender, EventArgs e)
        {
            rBIn.Enabled = cBCreateDate.Checked;
            rBOut.Enabled = cBCreateDate.Checked;
            rBSingle.Enabled = cBCreateDate.Checked;
        }

        private void rBSingle_CheckedChanged(object sender, EventArgs e)
        {
            cbxSingle.Enabled = rBSingle.Checked;
            cbxSingle.SelectedIndex = -1;
            dTPSingle.Enabled = rBSingle.Checked;
            dTPSingle.Value = DateTime.Now;
        }

        private void rBIn_CheckedChanged(object sender, EventArgs e)
        {
            dTPInBegin.Enabled = rBIn.Checked;
            dTPInBegin.Value = DateTime.Now;
            dTPInEnd.Enabled = rBIn.Checked;
            dTPInEnd.Value = DateTime.Now;
        }

        private void rBOut_CheckedChanged(object sender, EventArgs e)
        {
            dTPOutBegin.Enabled = rBOut.Checked;
            dTPOutBegin.Value = DateTime.Now;
            dTPOutEnd.Enabled = rBOut.Checked;
            dTPOutEnd.Value = DateTime.Now;
        }

        private void dGVStudentUserQuery_Click(object sender, EventArgs e)
        {
            if (!dGVStudentUserQuery.Columns[0].Visible)
            {
                if (MessageBox.Show("需要重置密码吗？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dGVStudentUserQuery.Columns[0].Visible = true;
                    dGVStudentUserQuery.CurrentCell = null;
                    btnResetPassword.Enabled = true;
                    btnCourseAllCancel.Enabled = true;
                    btnCourseAllChoose.Enabled = true;
                    MessageBox.Show("请选择用户！");
                }
            }
            else
            {
                dGVStudentUserQuery.CurrentRow.Cells[0].Value = true;
            }
        }

        private void btnCourseAllChoose_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVStudentUserQuery.RowCount; i++)
            {
                dGVStudentUserQuery.Rows[i].Cells[0].Value = true;
            }
        }

        private void btnCourseAllCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVStudentUserQuery.RowCount; i++)
            {
                dGVStudentUserQuery.Rows[i].Cells[0].Value = false;
            }
        }
    }
}
