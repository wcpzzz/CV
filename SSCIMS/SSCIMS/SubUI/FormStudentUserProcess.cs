using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSCIMS
{
    public partial class FormStudentUserProcess : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        public FormStudentUserProcess()
        {
            InitializeComponent();
        }

        #region 自定义函数

        public void FillListBox()
        {
            cListStudentUserProcess.Items.Clear();
            string WhereString = "StuID not in (select UserName from [User])";
            eOperationDatabaseClass.eDataView = eOperationDatabaseClass.Query("Student", "StuID", WhereString);
            for (int i = 0; i < eOperationDatabaseClass.eDataView.Table.Rows.Count; i++)
            {
                cListStudentUserProcess.Items.Add(eOperationDatabaseClass.eDataView.Table.Rows[i][0]);
            }
        }

        #endregion

        private void FormStudentUserProcess_Load(object sender, EventArgs e)
        {
            FillListBox();
            DataGridViewColumn eDataGridViewColumn = new DataGridViewCheckBoxColumn();
            eDataGridViewColumn.HeaderText = "选择";
            dGVStudentUserProcess.Columns.Add(eDataGridViewColumn);
            dGVStudentUserProcess.DataSource = eOperationDatabaseClass.Query("[User]", "UserName as 用户名,CreateDate as 创建日期", "UserName !='admin'");
        }

        private void tSButtonAllChosoe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cListStudentUserProcess.Items.Count; i++)
            {
                cListStudentUserProcess.SetItemChecked(i, true);
            }
        }

        private void tSButtonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cListStudentUserProcess.Items.Count; i++)
            {
                cListStudentUserProcess.SetItemChecked(i, false);
            }
        }

        private void tSButtonInsert_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.eSqlstring = "";
            for (int i = 0; i < cListStudentUserProcess.CheckedItems.Count; i++)
            {
                eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'" + cListStudentUserProcess.CheckedItems[i].ToString() + "','" + cListStudentUserProcess.CheckedItems[i].ToString() + "','" + DateTime.Now.ToShortDateString() + "' union select ";
            }
            if (eOperationDatabaseClass.eSqlstring != "")
            {
                eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring.Remove(eOperationDatabaseClass.eSqlstring.Length - 14);
                eOperationDatabaseClass.Insert("[User]", "", eOperationDatabaseClass.eSqlstring);
                FillListBox();
                dGVStudentUserProcess.DataSource = eOperationDatabaseClass.Query("[User]", "UserName as 用户名,CreateDate as 创建日期", "UserName !='admin'");
            }
            else
            {
                MessageBox.Show("请选择添加用户！");
            }
        }

        private void tSButtonAllUserChoose_Click(object sender, EventArgs e)
        {
            dGVStudentUserProcess.CurrentCell = null;//取消选择单元格
            for (int i = 0; i < dGVStudentUserProcess.Rows.Count; i++)
            {
                dGVStudentUserProcess.Rows[i].Cells[0].Value = true;
            }
        }

        private void tSButtonAllCancel_Click(object sender, EventArgs e)
        {
            dGVStudentUserProcess.CurrentCell = null;//取消选择单元格
            for (int i = 0; i < dGVStudentUserProcess.Rows.Count; i++)
            {
                dGVStudentUserProcess.Rows[i].Cells[0].Value = false;
            }
        }

        private void tSButtonDelete_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.eSqlstring = "('";
            for (int i = 0; i < dGVStudentUserProcess.Rows.Count; i++)
            {
                if (bool.Parse(dGVStudentUserProcess.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + dGVStudentUserProcess.Rows[i].Cells[1].Value.ToString() + "','";
                }
            }
            if (eOperationDatabaseClass.eSqlstring != "('")
            {
                eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring.Remove(eOperationDatabaseClass.eSqlstring.Length - 2);
                eOperationDatabaseClass.eSqlstring = "UserName in " + eOperationDatabaseClass.eSqlstring + ")";
                eOperationDatabaseClass.Delete("[User]", eOperationDatabaseClass.eSqlstring);
                FillListBox();
                dGVStudentUserProcess.DataSource = eOperationDatabaseClass.Query("[User]", "UserName as 用户名,CreateDate as 创建日期", "UserName !='admin'");
            }
            else
            {
                MessageBox.Show("请选择删除用户！");
            }
        }
    }
}
