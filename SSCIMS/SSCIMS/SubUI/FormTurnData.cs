using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSCIMS.SubUI
{
    public partial class FormTurnData : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        public FormTurnData()
        {
            InitializeComponent();
        }

        void Browse()
        {
            dGVTurndata.DataSource = eOperationDatabaseClass.Query("DataminingTable", "*", "");
        }

        private void btnTurnData_Click(object sender, EventArgs e)
        {
            eOperationDatabaseClass.Delete("DataminingTable", "");
            eOperationDatabaseClass.eSqlstring = "Student,Choose,Course";
            eOperationDatabaseClass.ProjectString = "Student.Sex,Student.Profession,Course.Credit,Choose.Grade";
            eOperationDatabaseClass.WhereString = "Student.StuID = Choose.StuID and Choose.CourseID = Course.CourseID";
            eOperationDatabaseClass.eDataSet =
                eOperationDatabaseClass.Query(eOperationDatabaseClass.eSqlstring, eOperationDatabaseClass.ProjectString,
                    eOperationDatabaseClass.WhereString).Table.DataSet;
            for (int i = 0; i < eOperationDatabaseClass.eDataSet.Tables[0].Rows.Count; i++)
            {
                eOperationDatabaseClass.eSqlstring = "";
                if (eOperationDatabaseClass.eDataSet.Tables[0].Rows[i][0].ToString() == "男")
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'',";
                }
                else
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y',";
                }

                if (eOperationDatabaseClass.eDataSet.Tables[0].Rows[i][1].ToString() == "软件工程")
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'',";
                }
                else
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y',";
                }

                if (int.Parse(eOperationDatabaseClass.eDataSet.Tables[0].Rows[i][2].ToString()) >= 4)
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'',";
                }
                else
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y',";
                }

                if (int.Parse(eOperationDatabaseClass.eDataSet.Tables[0].Rows[i][3].ToString()) >= 80)
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "''";
                }
                else
                {
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'',";
                    eOperationDatabaseClass.eSqlstring = eOperationDatabaseClass.eSqlstring + "'Y'";
                }
                eOperationDatabaseClass.Insert("DataminingTable", "", eOperationDatabaseClass.eSqlstring);
            }
            Browse();
        }

        private void FormTurnData_Load(object sender, EventArgs e)
        {
            Browse();
        }
    }
}
