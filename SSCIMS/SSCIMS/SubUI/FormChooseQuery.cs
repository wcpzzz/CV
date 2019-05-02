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
    public partial class FormChooseQuery : Form
    {
        public string LoginUserName = null;

        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        string WhereString = null;

        string Projection = null;

        #region 自定义函数

        public void ClearOperation()
        {
            cBStuID.Checked = false;
            if (LoginUserName != "admin")
            {
                cBStuID.Enabled = false;
            }
            cbxStuID.Enabled = false;
            cBCourseID.Checked = false;
            cbxCourseIDQuery.Enabled = false;
            cBInputGrade.Checked = false;
            cBInputGrade.Enabled = false;
            cBGiveTerm.Checked = false;
            cBGiveYear.Checked = false;
            rBSingleYear.Enabled = false;
            rBSingleYear.Checked = false;
            rBYearIn.Enabled = false;
            rBYearOut.Enabled = false;
            dTPGivenYearSingle.Enabled = false;
            dTPYearInBegin.Enabled = false;
            dTPYearInEnd.Enabled = false;
            dTPYearOutBegin.Enabled = false;
            dTPYearOutEnd.Enabled = false;
            cbxGiveTerm.Enabled = false;
            cbxSignYear.Enabled = false;
            cBInputGrade.Checked = false;
            cBInputGrade.Visible = false;
            btnUpdate.Visible = false;
            dGVChooseQuery.DataSource = null;
        }

        #endregion

        public FormChooseQuery()
        {
            InitializeComponent();
        }

        public FormChooseQuery(string LoginUser)
        {
            InitializeComponent();
            LoginUserName = LoginUser;
        }

        private void FormChooseQuery_Layout(object sender, LayoutEventArgs e)
        {
            if (LoginUserName != "admin")
            {
                btnUpdate.Visible = false;
                cBInputGrade.Visible = false;
            }
            eAutoSizeFormClass.controlAutoSize(this, false);
        }

        private void FormChooseQuery_Load(object sender, EventArgs e)
        {
            if (LoginUserName == "admin")
            {
                eOperationDatabaseClass.eDataView = eOperationDatabaseClass.Query("Student", "StuID", "");
                for (int i = 0; i < eOperationDatabaseClass.eDataView.Table.Rows.Count; i++)
                {
                    cbxStuID.Items.Add(eOperationDatabaseClass.eDataView.Table.Rows[i][0]);
                }
                cbxStuID.SelectedIndex = -1;
                eOperationDatabaseClass.eDataView.Table.Clear();
            }//填充学号下拉列表
            else
            {
                cbxStuID.Items.Add(LoginUserName);
                cbxStuID.SelectedIndex = 0;
                cbxStuID.Enabled = false;
                cBStuID.Checked = false;
                cBStuID.Enabled = false;
            }
            //填充课程编号下拉列表
            eOperationDatabaseClass.eDataView = eOperationDatabaseClass.Query("Course", "CourseID", "");
            for (int i = 0; i < eOperationDatabaseClass.eDataView.Table.Rows.Count; i++)
            {
                cbxCourseIDQuery.Items.Add(eOperationDatabaseClass.eDataView.Table.Rows[i][0]);
            }
            cbxCourseIDQuery.SelectedIndex = -1;
            eOperationDatabaseClass.eDataView.Table.Clear();
            ClearOperation();
        }

        private void cBStuID_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBStuID.Checked)
            {
                cbxStuID.Enabled = true;
            }
            else
            {
                cbxStuID.Enabled = false;
                cbxStuID.SelectedIndex = -1;
                lblStuName.Text = "";
            }
        }

        private void cBCourseID_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBCourseID.Checked)
            {
                cbxCourseIDQuery.Enabled = true;
                if (LoginUserName == "admin")
                {
                    cBInputGrade.Visible = true;
                    cBInputGrade.Enabled = true;
                }
                else
                {
                    cBInputGrade.Enabled = false;
                    cBInputGrade.Visible = false;
                }
            }
            else
            {
                cbxCourseIDQuery.Enabled = false;
                cbxCourseIDQuery.SelectedIndex = -1;
                lblCourseNameQueryText.Text = "";
                cBInputGrade.Enabled = false;
                cBInputGrade.Visible = false;
            }
        }

        private void cBGiveYear_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBGiveYear.Checked)
            {
                rBSingleYear.Enabled = true;
                rBYearIn.Enabled = true;
                rBYearOut.Enabled = true;
            }
            else
            {
                rBSingleYear.Enabled = false;
                rBSingleYear.Checked = false;
                rBYearIn.Enabled = false;
                rBYearIn.Checked = false;
                rBYearOut.Enabled = false;
                rBYearOut.Checked = false;
            }
        }

        private void rBSingleYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rBSingleYear.Checked)
            {
                cbxSignYear.Enabled = true;
                dTPGivenYearSingle.Enabled = true;
            }
            else
            {
                cbxSignYear.Enabled = false;
                cbxSignYear.SelectedIndex = -1;
                dTPGivenYearSingle.Enabled = false;
                dTPGivenYearSingle.Value = DateTime.Now;
            }
        }

        private void rBYearIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBYearIn.Checked)
            {
                dTPYearInBegin.Enabled = true;
                dTPYearInEnd.Enabled = true;
            }
            else
            {
                dTPYearInBegin.Enabled = false;
                dTPYearInBegin.Value = DateTime.Now;
                dTPYearInEnd.Enabled = false;
                dTPYearInEnd.Value = DateTime.Now;
            }
        }

        private void rBYearOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rBYearOut.Checked)
            {
                dTPYearOutBegin.Enabled = true;
                dTPYearOutEnd.Enabled = true;
            }
            else
            {
                dTPYearOutBegin.Enabled = false;
                dTPYearOutBegin.Value = DateTime.Now;
                dTPYearOutEnd.Enabled = false;
                dTPYearOutEnd.Value = DateTime.Now;
            }
        }

        private void cBGiveTerm_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBGiveTerm.Checked)
            {
                cbxGiveTerm.Enabled = true;
            }
            else
            {
                cbxGiveTerm.Enabled = false;
                cbxGiveTerm.SelectedIndex = -1;
            }
        }

        private void cbxStuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStuID.SelectedIndex != -1)
            {
                lblStuName.Text = eOperationDatabaseClass.Query("Student", "StuName", "StuID = '" + cbxStuID.SelectedItem.ToString() + "'").Table.Rows[0][0].ToString();
            }
        }

        private void cbxCourseIDQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCourseIDQuery.SelectedIndex != -1)
            {
                lblCourseNameQueryText.Text = eOperationDatabaseClass.Query("Course", "CourseName", "CourseID = '" + cbxCourseIDQuery.SelectedItem.ToString() + "'").Table.Rows[0][0].ToString();
            }
            cBInputGrade.Checked = false;
        }

        private void cBInputGrade_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBInputGrade.Checked)
            {
                btnUpdate.Visible = true;
                cBStuID.Checked = false;
                cBStuID.Enabled = false;
                cBGiveTerm.Checked = false;
                cBGiveTerm.Enabled = false;
                cBGiveYear.Checked = false;
                cBGiveYear.Enabled = false;
                if (cbxCourseIDQuery.SelectedIndex != -1)
                {
                    Projection = "Choose.StuID as 学号, Student.StuName as 姓名, Grade as 成绩";
                    WhereString = "Choose.StuID = Student.StuID and CourseID = '" + cbxCourseIDQuery.SelectedItem.ToString() + "'";
                    dGVChooseQuery.DataSource = eOperationDatabaseClass.Query("Choose,Student", Projection, WhereString);
                    dGVChooseQuery.Enabled = true;
                }
                else
                {
                    MessageBox.Show("请选择课程编号！");
                }
            }
            else
            {
                btnUpdate.Visible = false;
                cBStuID.Enabled = true;
                cBGiveTerm.Enabled = true;
                cBGiveYear.Enabled = true;
                dGVChooseQuery.DataSource = null;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearOperation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dGVChooseQuery != null)
            {
                string UpdateString = null;
                bool UpdateSuccessful = true;
                int i = 0;
                while (UpdateSuccessful && i < dGVChooseQuery.Rows.Count)
                {
                    UpdateString = "Grade = " + dGVChooseQuery.Rows[i].Cells[2].Value.ToString();
                    WhereString = "StuID = '" + dGVChooseQuery.Rows[i].Cells[0].Value.ToString() + "' and CourseID = '" + cbxCourseIDQuery.SelectedItem.ToString() + "'";
                    UpdateSuccessful = eOperationDatabaseClass.Update("Choose", WhereString, UpdateString, false);
                    i++;
                }
                if (UpdateSuccessful)
                {
                    MessageBox.Show("成绩保存成功！");
                }
                else
                {
                    MessageBox.Show("学号" + dGVChooseQuery.Rows[i - 1].Cells[0].Value.ToString() + "及以后学生成绩保存失败！");
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            WhereString = "";
            if (LoginUserName == "admin")
            {
                Projection = "Choose.StuID as 学号, Student.StuName as 姓名, Choose.CourseID as 课程号, Course.CourseName as 课程名称, Grade as 成绩";
            }
            else
            {
                Projection = "Choose.CourseID as 课程号, Course.CourseName as 课程名称, Grade as 成绩";
            }
            if (LoginUserName == "admin")
            {
                if (cBStuID.Checked)
                {
                    WhereString = "Choose.StuID = '" + cbxStuID.SelectedItem.ToString() + "' and ";
                }
            }
            else
            {
                WhereString = "Choose.StuID = '" + cbxStuID.SelectedItem.ToString() + "' and ";
            }
            if (cBCourseID.Checked)
            {
                WhereString = WhereString + "Choose.CourseID = '" + cbxCourseIDQuery.SelectedItem.ToString() + "' and ";
            }
            if (cBGiveYear.Checked)
            {
                if (rBSingleYear.Checked)
                {
                    WhereString = WhereString + "GiveYear " + cbxSignYear.SelectedItem.ToString() + dTPGivenYearSingle.Value.Year.ToString() + " and ";
                }
                if (rBYearIn.Checked)
                {
                    WhereString = WhereString + "GiveYear between " + dTPYearInBegin.Value.Year.ToString() + " and " + dTPYearInEnd.Value.Year.ToString() + " and ";
                }
                if (rBYearOut.Checked)
                {
                    WhereString = WhereString + "(GiveYear <= " + dTPYearOutBegin.Value.Year.ToString() + " or GiveYear >= " + dTPYearOutEnd.Value.Year.ToString() + ") and ";
                }
            }
            if (cBGiveTerm.Checked)
            {
                if (cbxGiveTerm.SelectedIndex != -1)
                {
                    WhereString = WhereString + "GiveTerm = '" + cbxGiveTerm.SelectedItem.ToString() + "' and ";
                }
            }
            WhereString = WhereString + "Student.StuID = Choose.StuID and Choose.CourseID = Course.CourseID";
            dGVChooseQuery.DataSource = eOperationDatabaseClass.Query("Student,Choose,Course", Projection, WhereString);
            dGVChooseQuery.Enabled = false;
            dGVChooseQuery.CurrentCell = null;
        }
    }
}
