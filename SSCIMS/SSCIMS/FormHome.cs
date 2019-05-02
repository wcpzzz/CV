using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SSCIMS.SubUI;

namespace SSCIMS
{
    public partial class FormHome : Form
    {
        public string LoginUserName;

        public FormHome()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 带参数的构造函数需要添加,不带参数的是自动生成
        /// </summary>
        /// <param name="LoginUser"></param>
        public FormHome(string LoginUser)
        {
            InitializeComponent();
            LoginUserName = LoginUser;
            if (LoginUserName != "admin")
            {
                MenuItemCourseManage.Visible = false;
                MenuItemCourseQuery.Visible = false;
                MenuItemStudentManage.Visible = false;
                MenuItemStudentProcess.Visible = false;
                MenuItemStudentUserManage.Visible = false;
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出系统吗?", "系统友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                System.Environment.Exit(0);
        }

        #region 子窗体调用代码区

        private void MenuItemStudentProcess_Click(object sender, EventArgs e)
        {
            FormStudentProcess eFormStudentProcess = new FormStudentProcess();
            eFormStudentProcess.ShowDialog();
        }

        private void MenuItemStudentQuery_Click(object sender, EventArgs e)
        {
            FormStudentQuery eFormStudentQuery = new FormStudentQuery();
            eFormStudentQuery.ShowDialog();
        }

        private void MenuItemCourseProcess_Click(object sender, EventArgs e)
        {
            FormCourseProcess eFormCourseProcess = new FormCourseProcess();
            eFormCourseProcess.ShowDialog();
        }

        private void MenuItemCourseQuery_Click(object sender, EventArgs e)
        {
            FormCourseQuery eFormCourseQuery = new FormCourseQuery();
            eFormCourseQuery.ShowDialog();
        }

        private void MenuItemChooseProcess_Click(object sender, EventArgs e)
        {
            FormChooseProcess eFormChooseProcess = new FormChooseProcess(LoginUserName);
            eFormChooseProcess.ShowDialog();
        }

        private void MenuItemChooseQuery_Click(object sender, EventArgs e)
        {
            FormChooseQuery eFormChooseQuery = new FormChooseQuery(LoginUserName);
            eFormChooseQuery.ShowDialog();
        }

        private void MenuItemUpdatePassword_Click(object sender, EventArgs e)
        {
            FormUpdatePassword eFormUpdatePassword = new FormUpdatePassword(LoginUserName);
            eFormUpdatePassword.ShowDialog();
        }

        private void MenuItemStudentUserProcess_Click(object sender, EventArgs e)
        {
            FormStudentUserProcess eFormStudentUserProcess = new FormStudentUserProcess();
            eFormStudentUserProcess.ShowDialog();
        }

        private void MenuItemStudentUserQuery_Click(object sender, EventArgs e)
        {
            FormStudentUserQuery eFormStudentUserQuery = new FormStudentUserQuery();
            eFormStudentUserQuery.ShowDialog();
        }

        private void MenuItemTurnData_Click(object sender, EventArgs e)
        {
            FormTurnData eFormTurnData = new FormTurnData();
            eFormTurnData.ShowDialog();
        }

        private void MenuItemMining_Click(object sender, EventArgs e)
        {
            FormDataMining eFormDataMining = new FormDataMining();
            eFormDataMining.ShowDialog();
        }

        #endregion

 
    }
}
