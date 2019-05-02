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
    public partial class FormCourseProcess : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        public FormCourseProcess()
        {
            InitializeComponent();
        }

        #region 自定义函数

        public void BrowseTable()
        {
            string ProjectionString = "CourseID as 课程编号, CourseName as 课程名称, GiveYear as 授课年份, GiveTerm as 授课学期, Periods as 讲授学时, Teacher as 任课教师, Credit as 课程学分";
            dGVCourseProcess.DataSource = eOperationDatabaseClass.Query("Course", ProjectionString, "");
            ClearOperation();
        }

        public void ClearOperation()
        {
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            txtCourseID.Clear();
            txtCourseID.Enabled = true;
            txtCourseName.Clear();
            txtCourseName.Enabled = true;
            txtCredit.Clear();
            txtCredit.Enabled = true;
            txtPeriods.Clear();
            txtPeriods.Enabled = true;
            txtTeacher.Clear();
            txtTeacher.Enabled = true;
            cbxGiveTerm.SelectedIndex = -1;
            cbxGiveTerm.Enabled = true;
            dTPGivenYear.Enabled = true;
            dTPGivenYear.Value = DateTime.Now;
            dGVCourseProcess.Columns[0].Visible = false;
            for (int i = 0; i < dGVCourseProcess.RowCount; i++)
            {
                dGVCourseProcess.Rows[i].Cells[0].Value = false;
            }
            dGVCourseProcess.CurrentCell = null;
        }

        #endregion

        #region 事件区域

        private void FormCourseProcess_Layout(object sender, LayoutEventArgs e)
        {
            eAutoSizeFormClass.controlAutoSize(this, false);
        }

        private void FormCourseProcess_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            DataGridViewColumn eDataGridViewColumn = new DataGridViewCheckBoxColumn();
            eDataGridViewColumn.HeaderText = "删除";
            dGVCourseProcess.Columns.Add(eDataGridViewColumn);
            BrowseTable();
            dGVCourseProcess.Columns[0].Visible = false;
            dGVCourseProcess.CurrentCell = null;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text != "" && cbxGiveTerm.SelectedIndex != -1)
            {
                if (txtCredit.Text.Length == 0)
                {
                    txtCredit.Text = "0";
                }
                if (txtPeriods.Text.Length == 0)
                {
                    txtPeriods.Text = "0";
                }
                eOperationDatabaseClass.eSqlstring = "'" + txtCourseID.Text.ToString() + "','" + txtCourseName.Text.ToString() + "'," + dTPGivenYear.Value.Year.ToString() + ",'" + cbxGiveTerm.SelectedItem.ToString() + "'," + txtPeriods.Text.ToString() + ",'" + txtTeacher.Text.ToString() + "'," + txtCredit.Text.ToString();
                eOperationDatabaseClass.Insert("Course", "CourseID = '" + txtCourseID.Text.ToString() + "'", eOperationDatabaseClass.eSqlstring);
                BrowseTable();
            }
            else
            {
                MessageBox.Show("课程编号和授课学期必须填写！");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOperation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.eSqlstring = "CourseName = '" + txtCourseName.Text.ToString() + "',GiveYear = " + dTPGivenYear.Value.Year.ToString() + ",GiveTerm = '" + cbxGiveTerm.SelectedItem.ToString() + "',Periods = " + txtPeriods.Text.ToString() + ",Teacher = '" + txtTeacher.Text.ToString() + "', Credit = " + txtCredit.Text.ToString();
            eOperationDatabaseClass.Update("Course", "CourseID = '" + txtCourseID.Text.ToString() + "'", eOperationDatabaseClass.eSqlstring, true);
            BrowseTable();
        }

        private void dGVCourseProcess_MouseClick(object sender, MouseEventArgs e)
        {
            if (!dGVCourseProcess.Columns[0].Visible)
            {
                if (MessageBox.Show("你需要修改吗？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnDelete.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    txtCourseID.Enabled = false;
                    txtCourseID.Text = dGVCourseProcess.CurrentRow.Cells[1].Value.ToString();
                    txtCourseName.Text = dGVCourseProcess.CurrentRow.Cells[2].Value.ToString();
                    dTPGivenYear.Value = new DateTime(int.Parse(dGVCourseProcess.CurrentRow.Cells[3].Value.ToString()), 1, 1);
                    cbxGiveTerm.SelectedItem = dGVCourseProcess.CurrentRow.Cells[4].Value.ToString();
                    txtPeriods.Text = dGVCourseProcess.CurrentRow.Cells[5].Value.ToString();
                    txtTeacher.Text = dGVCourseProcess.CurrentRow.Cells[6].Value.ToString();
                    txtCredit.Text = dGVCourseProcess.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    dGVCourseProcess.Columns[0].Visible = true;
                    dGVCourseProcess.CurrentCell = null;
                    txtCourseID.Enabled = false;
                    txtCourseID.Clear();
                    txtCourseName.Enabled = false;
                    txtCourseName.Clear();
                    txtCredit.Enabled = false;
                    txtCredit.Clear();
                    txtPeriods.Enabled = false;
                    txtPeriods.Clear();
                    txtTeacher.Enabled = false;
                    txtTeacher.Clear();
                    cbxGiveTerm.Enabled = false;
                    cbxGiveTerm.SelectedIndex = -1;
                    dTPGivenYear.Enabled = false;
                    dTPGivenYear.Value = DateTime.Now;
                }
            }
            else
            {
                dGVCourseProcess.CurrentRow.Cells[0].Value = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.eSqlstring = "( '";
            for (int i = 0; i < dGVCourseProcess.Rows.Count; i++)
            {
                if (bool.Parse(dGVCourseProcess.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + dGVCourseProcess.Rows[i].Cells[1].Value.ToString() + "','";
                }
            }
            if (eOperationDatabaseClass.eSqlstring != "( '")
            {
                eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring.Remove(eOperationDatabaseClass.eSqlstring.Length - 2);
                eOperationDatabaseClass.eSqlstring = "CourseID in " + eOperationDatabaseClass.eSqlstring + ")";
                eOperationDatabaseClass.Delete("Course", eOperationDatabaseClass.eSqlstring);
                BrowseTable();
            }
            else
            {
                MessageBox.Show("请选择删除课程！");
            }
        }

        #endregion

    }
}
