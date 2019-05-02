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
    public partial class FormChooseProcess : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        string LoginUserName = null;

        public FormChooseProcess()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="Loginuser"></param>
        public FormChooseProcess(string LoginUser)
        {
            InitializeComponent();
            LoginUserName = LoginUser;
        }

        private void FormChooseProcess_Layout(object sender, LayoutEventArgs e)
        {
            eAutoSizeFormClass.controlAutoSize(this, false);
        }

        private void FormChooseProcess_Load(object sender, EventArgs e)
        {
            //增加选课列
            DataGridViewColumn eChooseDataGridViewColumn = new DataGridViewCheckBoxColumn();
            eChooseDataGridViewColumn.HeaderText = "选课";
            dGVChooseProcessLeft.Columns.Add(eChooseDataGridViewColumn);

            //增加删除标记
            DataGridViewColumn eDeleteDataGridViewColumn = new DataGridViewCheckBoxColumn();
            eDeleteDataGridViewColumn.HeaderText = "删除";
            dGVChooseProcessRight.Columns.Add(eDeleteDataGridViewColumn);
            DataView eDataView = new DataView();
            if (LoginUserName == "admin")
            {
                eDataView = eOperationDatabaseClass.Query("Student", "Distinct StuID", "");
                for (int i = 0; i < eDataView.Table.Rows.Count; i++)
                {
                    cbxStuID.Items.Add(eDataView.Table.Rows[i][0]);
                }
                cbxStuID.SelectedIndex = -1;
                eDataView.Table.Clear();
            }//填充学号下拉列表
            else
            {
                cbxStuID.Items.Add(LoginUserName);
                cbxStuID.Enabled = false;
            }
            
            //填充授课年份下拉列表
            eOperationDatabaseClass.WhereString = "GiveYear >= " + DateTime.Now.Year.ToString();
            eDataView = eOperationDatabaseClass.Query("Course", "Distinct GiveYear", eOperationDatabaseClass.WhereString);
            for (int i = 0; i < eDataView.Table.Rows.Count; i++)
            {
                cbxGiveYear.Items.Add(eDataView.Table.Rows[i][0]);
            }
            cbxGiveYear.SelectedIndex = -1;

            if (LoginUserName == "admin")
            {
                BrowseCourseData();
                BrowseChooseData();
            }
            else
            {
                cbxStuID.SelectedIndex = 0;
            }
        }

        private void cbxStuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStuID.SelectedIndex != -1)
            {
                eOperationDatabaseClass.WhereString = "StuID = '" + cbxStuID.SelectedItem.ToString() + "'";
                lblStuName.Text = eOperationDatabaseClass.Query("Student", "StuName", eOperationDatabaseClass.WhereString).Table.Rows[0][0].ToString();
            }
            else
            {
                lblStuName.Text = "";
            }
            BrowseCourseData();
            BrowseChooseData();
        }

        private void cbxGiveYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrowseCourseData();
            BrowseChooseData();
        }

        private void cbxGiveTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrowseCourseData();
            BrowseChooseData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cbxStuID.SelectedIndex != -1)
            {
                eOperationDatabaseClass.WhereString = "";
                for (int i = 0; i < dGVChooseProcessLeft.Rows.Count; i++)
                {
                    if (bool.Parse(dGVChooseProcessLeft.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                    {
                        eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "'" + cbxStuID.SelectedItem.ToString() + "', '" + dGVChooseProcessLeft.Rows[i].Cells[1].Value.ToString() + "', null , '" + LoginUserName + "' union select ";
                    }
                }
                if (eOperationDatabaseClass.WhereString != "")
                {
                    eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString.Remove(eOperationDatabaseClass.WhereString.Length - 14);
                    eOperationDatabaseClass.Insert("Choose", "", eOperationDatabaseClass.WhereString);
                    BrowseCourseData();
                    BrowseChooseData();
                }
                else
                {
                    MessageBox.Show("请选择课程！");
                }
 
            }
            else
            {
                MessageBox.Show("请选择选课学生！");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.WhereString = "('";
            for (int i = 0; i < dGVChooseProcessRight.Rows.Count; i++)
            {
                if (bool.Parse(dGVChooseProcessRight.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    if (LoginUserName == "admin")
                    {
                        eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + dGVChooseProcessRight.Rows[i].Cells[1].Value.ToString().Trim() + dGVChooseProcessRight.Rows[i].Cells[3].Value.ToString().Trim() + "','";
                    }
                    else
                    {
                        eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + cbxStuID.SelectedItem.ToString() + dGVChooseProcessRight.Rows[i].Cells[1].Value.ToString().Trim() + "','";
                    }
                }
            }
            if (eOperationDatabaseClass.WhereString != "('")
            {
                eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString.Remove(eOperationDatabaseClass.WhereString.Length - 2) + ")";
                eOperationDatabaseClass.WhereString = "RTRIM(StuID) + RTRIM(CourseID) in " + eOperationDatabaseClass.WhereString;
                eOperationDatabaseClass.Delete("Choose", eOperationDatabaseClass.WhereString);
                BrowseCourseData();
                BrowseChooseData();
            }
            else
            {
                MessageBox.Show("请选择删除课程！");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (LoginUserName == "admin")
            {
                cbxStuID.SelectedIndex = -1;
            }
            else
            {
                cbxStuID.Enabled = false;
                cbxStuID.SelectedText = LoginUserName;
            }
            cbxGiveTerm.SelectedIndex = -1;
            cbxGiveYear.SelectedIndex = -1;
            BrowseCourseData();
            BrowseChooseData();
        }

        private void btnCourseAllChoose_Click(object sender, EventArgs e)
        {
            dGVChooseProcessLeft.CurrentCell = null;//取消选择单元格
            for (int i = 0; i < dGVChooseProcessLeft.Rows.Count; i++)
            {
                dGVChooseProcessLeft.Rows[i].Cells[0].Value = true;
            }
        }

        private void btnCourseAllCancel_Click(object sender, EventArgs e)
        {
            dGVChooseProcessLeft.CurrentCell = null;//取消选择单元格
            for (int i = 0; i < dGVChooseProcessLeft.Rows.Count; i++)
            {
                dGVChooseProcessLeft.Rows[i].Cells[0].Value = false;
            }
        }

        private void btnChooseAllChoose_Click(object sender, EventArgs e)
        {
            dGVChooseProcessRight.CurrentCell = null;//取消选择单元格
            for (int i = 0; i < dGVChooseProcessRight.Rows.Count; i++)
            {
                dGVChooseProcessRight.Rows[i].Cells[0].Value = true;
            }
        }

        private void btnChooseAllCancel_Click(object sender, EventArgs e)
        {
            dGVChooseProcessRight.CurrentCell = null;//取消选择单元格
            for (int i = 0; i < dGVChooseProcessRight.Rows.Count; i++)
            {
                dGVChooseProcessRight.Rows[i].Cells[0].Value = false;
            }
        }

        #region 自定义函数

        public void BrowseCourseData()
        {
            eOperationDatabaseClass.WhereString = "";
            if (cbxGiveYear.SelectedIndex != -1)
            {
                eOperationDatabaseClass.WhereString = "GiveYear = " + cbxGiveYear.SelectedItem.ToString() + " and ";
            }
            if (cbxGiveTerm.SelectedIndex != -1)
            {
                eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + " GiveTerm = '" + cbxGiveTerm.SelectedItem.ToString() + "' and ";
            }
            if (cbxStuID.SelectedIndex != -1)
            {
                eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "CourseID not in (select distinct CourseID from Choose where StuID = '" + cbxStuID.SelectedItem.ToString() + "') and ";
            }
            eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "GiveYear >= " + DateTime.Now.Year.ToString();
            eOperationDatabaseClass.ProjectString = "CourseID as 课程编号, CourseName as 课程名称, GiveYear as 授课年份, GiveTerm as 授课学期, Periods as 讲授学时, Teacher as 任课教师, Credit as 课程学分";
            dGVChooseProcessLeft.DataSource = eOperationDatabaseClass.Query("Course", eOperationDatabaseClass.ProjectString, eOperationDatabaseClass.WhereString);
            dGVChooseProcessLeft.CurrentCell = null;
        }

        public void BrowseChooseData()
        {
            eOperationDatabaseClass.WhereString = "";
            if (LoginUserName == "admin")
            {
                eOperationDatabaseClass.ProjectString = "Choose.StuID as 学号, Student.StuName as 姓名,Choose.CourseID as 课程编号, Course.CourseName as 课程名称, Choose.UserName as 用户";
                if (cbxStuID.SelectedIndex != -1)
                {
                    eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Choose.StuID = '" + cbxStuID.SelectedItem.ToString() + "' and ";
                }
                if (cbxGiveYear.SelectedIndex != -1)
                {
                    eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Course.GiveYear = '" + cbxGiveYear.SelectedItem.ToString() + "' and ";
                }
                if (cbxGiveTerm.SelectedIndex != -1)
                {
                    eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Course.GiveTerm = '" + cbxGiveTerm.SelectedItem.ToString() + "' and ";
                }
                eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Student.StuID = Choose.StuID and Course.CourseID = Choose.CourseID";
                dGVChooseProcessRight.DataSource = eOperationDatabaseClass.Query("Student, Course, Choose", eOperationDatabaseClass.ProjectString, eOperationDatabaseClass.WhereString);
                dGVChooseProcessRight.CurrentCell = null;
            }
            else
            {
                eOperationDatabaseClass.ProjectString = "Choose.CourseID as 课程编号, Course.CourseName as 课程名称, Choose.UserName as 用户";
                eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Choose.StuID = '" + cbxStuID.SelectedItem.ToString() + "' and ";
                if (cbxGiveYear.SelectedIndex != -1)
                {
                    eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Course.GiveYear = '" + cbxGiveYear.SelectedItem.ToString() + "' and ";
                }
                if (cbxGiveTerm.SelectedIndex != -1)
                {
                    eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Course.GiveTerm = '" + cbxGiveTerm.SelectedItem.ToString() + "' and ";
                }
                eOperationDatabaseClass.WhereString = eOperationDatabaseClass.WhereString + "Course.CourseID = Choose.CourseID";
                dGVChooseProcessRight.DataSource = eOperationDatabaseClass.Query("Course, Choose", eOperationDatabaseClass.ProjectString, eOperationDatabaseClass.WhereString);
                dGVChooseProcessRight.CurrentCell = null;
            }
        }

        #endregion
    }
}
