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
    public partial class FormStudentProcess : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        public FormStudentProcess()
        {
            InitializeComponent();
        }

        #region 自定义函数

        public void BrowseTable()
        {
            eOperationDatabaseClass.ProjectString = "StuID as 学号, StuName as 姓名, Sex as 性别, Profession as 专业, Class as 班级, Tel as 联系电话";
            dGVStudentProcess.DataSource = eOperationDatabaseClass.Query("Student", eOperationDatabaseClass.ProjectString, "");
            ClearOperation();
        }

        public void ClearOperation()
        {
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            txtClass.Clear();
            txtClass.Enabled = true;
            txtProfession.Clear();
            txtProfession.Enabled = true;
            txtStuID.Clear();
            txtStuID.Enabled = true;
            txtStuName.Clear();
            txtStuName.Enabled = true;
            txtTel.Clear();
            txtTel.Enabled = true;
            cbxSex.SelectedIndex = -1;
            cbxSex.Enabled = true;
            dGVStudentProcess.Columns[0].Visible = false;
            for (int i = 0; i < dGVStudentProcess.RowCount; i++)
            {
                dGVStudentProcess.Rows[i].Cells[0].Value = false;
            }
            dGVStudentProcess.CurrentCell = null;
        }

        #endregion

        #region 事件区域

        private void FormStudentProcess_Layout(object sender, LayoutEventArgs e)
        {
            //eAutoSizeFormClass.controlAutoSize(this, false);
        }

        private void FormStudentProcess_Load(object sender, EventArgs e)
        {
            DataGridViewColumn eDataGridViewColumn = new DataGridViewCheckBoxColumn();
            eDataGridViewColumn.HeaderText = "删除";
            dGVStudentProcess.Columns.Add(eDataGridViewColumn);
            BrowseTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOperation();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtStuID.Text != "" && cbxSex.SelectedIndex != -1)
            {
                eOperationDatabaseClass.eSqlstring = "'" + txtStuID.Text.ToString() + "','" + txtStuName.Text.ToString() + "','" + cbxSex.SelectedItem.ToString() + "','" + txtProfession.Text.ToString() + "','" + txtClass.Text.ToString() + "','" + txtTel.Text.ToString() + "'";
                eOperationDatabaseClass.Insert("Student", "StuID = '" + txtStuID.Text.ToString() + "'", eOperationDatabaseClass.eSqlstring);
                BrowseTable();
            }
            else
            {
                MessageBox.Show("学号和性别必须填写！");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.eSqlstring = "StuName = '" + txtStuName.Text.ToString() + "',Sex = '" + cbxSex.SelectedItem.ToString() + "',Profession = '" + txtProfession.Text.ToString() + "',Class = '" + txtClass.Text.ToString() + "',Tel = '" + txtTel.Text.ToString() + "'";
            eOperationDatabaseClass.WhereString = "StuID = '" + txtStuID.Text.ToString() + "'";
            eOperationDatabaseClass.Update("Student", eOperationDatabaseClass.WhereString, eOperationDatabaseClass.eSqlstring, true);
            BrowseTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.eSqlstring = "( '";
            for (int i = 0; i < dGVStudentProcess.Rows.Count; i++)
            {
                if (bool.Parse(dGVStudentProcess.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + dGVStudentProcess.Rows[i].Cells[1].Value.ToString() + "','";
                }
            }
            if (eOperationDatabaseClass.eSqlstring != "( '")
            {
                eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring.Remove(eOperationDatabaseClass.eSqlstring.Length - 2);
                eOperationDatabaseClass.eSqlstring = "StuID in " + eOperationDatabaseClass.eSqlstring + ")";
                eOperationDatabaseClass.Delete("Student", eOperationDatabaseClass.eSqlstring);
                BrowseTable();
            }
            else
            {
                MessageBox.Show("请选择删除学生！");
            }
        }

        private void dGVStudentProcess_MouseClick(object sender, MouseEventArgs e)
        {
            if (!dGVStudentProcess.Columns[0].Visible)
            {
                if (MessageBox.Show("你需要修改吗？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnDelete.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    txtStuID.Enabled = false;
                    txtStuID.Text = dGVStudentProcess.CurrentRow.Cells[1].Value.ToString();
                    txtStuName.Text = dGVStudentProcess.CurrentRow.Cells[2].Value.ToString();
                    cbxSex.SelectedItem = dGVStudentProcess.CurrentRow.Cells[3].Value.ToString();
                    txtProfession.Text = dGVStudentProcess.CurrentRow.Cells[4].Value.ToString();
                    txtClass.Text = dGVStudentProcess.CurrentRow.Cells[5].Value.ToString();
                    txtTel.Text = dGVStudentProcess.CurrentRow.Cells[6].Value.ToString();
                }
                else
                {
                    dGVStudentProcess.Columns[0].Visible = true;
                    dGVStudentProcess.CurrentCell = null;
                    btnDelete.Enabled = true;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    txtStuID.Enabled = false;
                    txtStuID.Clear();
                    txtStuName.Enabled = false;
                    txtStuName.Clear();
                    cbxSex.Enabled = false;
                    cbxSex.SelectedIndex = -1;
                    txtProfession.Clear();
                    txtProfession.Enabled = false;
                    txtClass.Clear();
                    txtClass.Enabled = false;
                    txtTel.Clear();
                    txtTel.Enabled = false;
                }
            }
            else
            {
                dGVStudentProcess.CurrentRow.Cells[0].Value = true;
            }
        }

        #endregion
    }
}
