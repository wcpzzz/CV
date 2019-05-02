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
    public partial class FormCourseQuery : Form
    {
        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        public FormCourseQuery()
        {
            InitializeComponent();
        }

        private void dGVCourseQuery_Layout(object sender, LayoutEventArgs e)
        {
            eAutoSizeFormClass.controlAutoSize(this, false);
        }

        private void FormCourseQuery_Load(object sender, EventArgs e)
        {
            txtCourseID.Enabled = false;
            txtCourseName.Enabled = false;
            txtCreditInBegin.Enabled = false;
            txtCreditInEnd.Enabled = false;
            txtCreditOutBegin.Enabled = false;
            txtCreditOutEnd.Enabled = false;
            txtCreditSingle.Enabled = false;
            txtPeriodsInBegin.Enabled = false;
            txtPeriodsInEnd.Enabled = false;
            txtPeriodsOutBegin.Enabled = false;
            txtPeriodsOutEnd.Enabled = false;
            txtPeriodsSingle.Enabled = false;
            txtTeacher.Enabled = false;
            rBCreditIn.Enabled = false;
            rBCreditOut.Enabled = false;
            rBCreditSingle.Enabled = false;
            rBPeriodsIn.Enabled = false;
            rBPeriodsOut.Enabled = false;
            rBPeriodsSingle.Enabled = false;
            rBSingleYear.Enabled = false;
            rBYearIn.Enabled = false;
            rBYearOut.Enabled = false;
            dTPGivenYearSingle.Enabled = false;
            dTPYearInBegin.Enabled = false;
            dTPYearInEnd.Enabled = false;
            dTPYearOutBegin.Enabled = false;
            dTPYearOutEnd.Enabled = false;
            cbxGiveTerm.Enabled = false;
            cbxPeriodsSign.Enabled = false;
            cbxSignYear.Enabled = false;
            cbxCreditSign.Enabled = false;
        }

        private void cBCourseID_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBCourseID.Checked)
            {
                txtCourseID.Enabled = true;
            }
            else
            {
                txtCourseID.Enabled = false;
                txtCourseID.Clear();
            }
        }

        private void cBCourseName_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBCourseName.Checked)
            {
                txtCourseName.Enabled = true;
            }
            else
            {
                txtCourseName.Enabled = false;
                txtCourseName.Clear();
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

        private void cBTeacher_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBTeacher.Checked)
            {
                txtTeacher.Enabled = true;
            }
            else
            {
                txtTeacher.Enabled = false;
                txtTeacher.Clear();
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

        private void cBPeriods_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBPeriods.Checked)
            {
                rBPeriodsIn.Enabled = true;
                rBPeriodsOut.Enabled = true;
                rBPeriodsSingle.Enabled = true;
            }
            else
            {
                rBPeriodsIn.Enabled = false;
                rBPeriodsIn.Checked = false;
                rBPeriodsOut.Enabled = false;
                rBPeriodsOut.Checked = false;
                rBPeriodsSingle.Enabled = false;
                rBPeriodsSingle.Checked = false;
            }
        }

        private void rBPeriodsSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rBPeriodsSingle.Checked)
            {
                cbxPeriodsSign.Enabled = true;
                txtPeriodsSingle.Enabled = true;
            }
            else
            {
                cbxPeriodsSign.Enabled = false;
                cbxPeriodsSign.SelectedIndex = -1;
                txtPeriodsSingle.Enabled = false;
                txtPeriodsSingle.Clear();
            }
        }

        private void rBPeriodsIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBPeriodsIn.Checked)
            {
                txtPeriodsInBegin.Enabled = true;
                txtPeriodsInEnd.Enabled = true;
            }
            else
            {
                txtPeriodsInBegin.Enabled = false;
                txtPeriodsInBegin.Clear();
                txtPeriodsInEnd.Enabled = false;
                txtPeriodsInEnd.Clear();
            }
        }

        private void rBPeriodsOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rBPeriodsOut.Checked)
            {
                txtPeriodsOutBegin.Enabled = true;
                txtPeriodsOutEnd.Enabled = true;
            }
            else
            {
                txtPeriodsOutBegin.Enabled = false;
                txtPeriodsOutBegin.Clear();
                txtPeriodsOutEnd.Enabled = false;
                txtPeriodsOutEnd.Clear();
            }
        }

        private void cBCredit_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBCredit.Checked)
            {
                rBCreditIn.Enabled = true;
                rBCreditOut.Enabled = true;
                rBCreditSingle.Enabled = true;
            }
            else
            {
                rBCreditIn.Enabled = false;
                rBCreditIn.Checked = false;
                rBCreditOut.Enabled = false;
                rBCreditOut.Checked = false;
                rBCreditSingle.Enabled = false;
                rBCreditSingle.Checked = false;
            }
        }

        private void rBCreditSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rBCreditSingle.Checked)
            {
                cbxCreditSign.Enabled = true;
                txtCreditSingle.Enabled = true;
            }
            else
            {
                cbxCreditSign.Enabled = false;
                cbxCreditSign.SelectedIndex = -1;
                txtCreditSingle.Enabled = false;
                txtCreditSingle.Clear();
            }
        }

        private void rBCreditIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBCreditIn.Checked)
            {
                txtCreditInBegin.Enabled = true;
                txtCreditInEnd.Enabled = true;
            }
            else
            {
                txtCreditInBegin.Enabled = false;
                txtCreditInBegin.Clear();
                txtCreditInEnd.Enabled = false;
                txtCreditInEnd.Clear();
            }
        }

        private void rBCreditOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rBCreditOut.Checked)
            {
                txtCreditOutBegin.Enabled = true;
                txtCreditOutEnd.Enabled = true;
            }
            else
            {
                txtCreditOutBegin.Enabled = false;
                txtCreditOutBegin.Clear();
                txtCreditOutEnd.Enabled = false;
                txtCreditOutEnd.Clear();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string QueryString = null;
            if (cBCourseID.Checked)
            {
                QueryString = "CourseID Like '%" + txtCourseID.Text.ToString() + "%' and ";
            }
            if (cBCourseName.Checked)
            {
                QueryString = QueryString + "CourseName Like '%" + txtCourseName.Text.ToString() + "%' and ";
            }
            if (cBCredit.Checked)
            {
                if (rBCreditSingle.Checked)
                {
                    QueryString = QueryString + "Credit " + cbxCreditSign.SelectedItem.ToString() + txtCreditSingle.Text.ToString() + " and ";
                }
                if (rBCreditIn.Checked)
                {
                    QueryString = QueryString + "Credit between " + txtCreditInBegin.Text.ToString() + " and " + txtCreditInEnd.Text.ToString() + " and ";
                }
                if (rBCreditOut.Checked)
                {
                    QueryString = QueryString + "Credit <= " + txtCreditOutBegin.Text.ToString() + " or Credit >= " + txtCreditOutEnd.Text.ToString() + " and ";
                }
            }
            if (cBGiveTerm.Checked)
            {
                QueryString = QueryString + "GiveTerm = '" + cbxGiveTerm.SelectedItem.ToString() + "' and ";
            }
            if (cBGiveYear.Checked)
            {
                if (rBSingleYear.Checked)
                {
                    QueryString = QueryString + "GiveYear " + cbxSignYear.SelectedItem.ToString() + dTPGivenYearSingle.Value.Year.ToString() + " and ";
                }
                if (rBYearIn.Checked)
                {
                    QueryString = QueryString + "GiveYear between " + dTPYearInBegin.Value.Year.ToString() + " and " + dTPYearInEnd.Value.Year.ToString() + " and ";
                }
                if (rBYearOut.Checked)
                {
                    QueryString = QueryString + "(GiveYear <= " + dTPYearOutBegin.Value.Year.ToString() + " or GiveYear >= " + dTPYearOutEnd.Value.Year.ToString() + ") and ";
                }
            }
            if (cBPeriods.Checked)
            {
                if (rBPeriodsSingle.Checked)
                {
                    QueryString = QueryString + "Periods " + cbxPeriodsSign.SelectedItem.ToString() + txtPeriodsSingle.Text.ToString() + " and ";
                }
                if (rBPeriodsIn.Checked)
                {
                    QueryString = QueryString + "Periods between " + txtPeriodsInBegin.Text.ToString() + " and " + txtPeriodsInEnd.Text.ToString() + " and ";
                }
                if (rBPeriodsOut.Checked)
                {
                    QueryString = QueryString + "Periods <= " + txtPeriodsOutBegin.Text.ToString() + " or Periods >= " + txtPeriodsOutEnd.Text.ToString() + " and ";
                }
            }
            if (cBTeacher.Checked)
            {
                QueryString = QueryString + "Teacher like '%" + txtTeacher.Text.ToString() + "%' and ";
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
            string ProjectionString = "CourseID as 课程编号, CourseName as 课程名称, GiveYear as 授课年份, GiveTerm as 授课学期, Periods as 讲授学时, Teacher as 任课教师, Credit as 课程学分";
            dGVSCourseQuery.DataSource = eOperationDatabaseClass.Query("Course", ProjectionString, QueryString);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cBCourseID.Checked = false;
            cBCourseName.Checked = false;
            cBCredit.Checked = false;
            cBGiveTerm.Checked = false;
            cBGiveYear.Checked = false;
            cBPeriods.Checked = false;
            cBTeacher.Checked = false;
            dGVSCourseQuery.DataSource = null;
        }
    }
}
