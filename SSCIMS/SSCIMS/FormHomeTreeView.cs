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
    public partial class FormHomeTreeView : Form
    {
        public string LoginUserName;

        public FormHomeTreeView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 带参数的构造函数需要添加,不带参数的是自动生成
        /// </summary>
        /// <param name="LoginUser"></param>
        public FormHomeTreeView(string LoginUser)
        {
            InitializeComponent();
            LoginUserName = LoginUser;
            if (LoginUserName != "admin")
            {
                treeViewHome.Nodes["StudentManage"].Remove();
                treeViewHome.Nodes["CourseManage"].Remove();
                treeViewHome.Nodes["UserManage"].Nodes["StudentUserManage"].Remove();
            }
            treeViewHome.ExpandAll();
        }

        private void treeViewHome_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region 调用学生信息处理
            if (treeViewHome.SelectedNode.Name == "StudentProcess")
            {
                FormStudentProcess eFormStudentProcess = new FormStudentProcess();
                eFormStudentProcess.TopLevel = false;
                eFormStudentProcess.Dock = DockStyle.Fill;
                eFormStudentProcess.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormStudentProcess);
                eFormStudentProcess.Show();
            }
            #endregion

            #region 调用学生信息查询
            if (treeViewHome.SelectedNode.Name == "StudentQuery")
            {
                FormStudentQuery eFormStudentQuery = new FormStudentQuery();
                eFormStudentQuery.TopLevel = false;
                eFormStudentQuery.Dock = DockStyle.Fill;
                eFormStudentQuery.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormStudentQuery);
                eFormStudentQuery.Show();
            }
            #endregion

            #region 调用课程信息处理
            if (treeViewHome.SelectedNode.Name == "CourseProcess")
            {
                FormCourseProcess eFormCourseProcess = new FormCourseProcess();
                eFormCourseProcess.TopLevel = false;
                eFormCourseProcess.Dock = DockStyle.Fill;
                eFormCourseProcess.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormCourseProcess);
                eFormCourseProcess.Show();
            }
            #endregion

            #region 调用课程信息查询
            if (treeViewHome.SelectedNode.Name == "CourseQuery")
            {
                FormCourseQuery eFormCourseQuery = new FormCourseQuery();
                eFormCourseQuery.TopLevel = false;
                eFormCourseQuery.Dock = DockStyle.Fill;
                eFormCourseQuery.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormCourseQuery);
                eFormCourseQuery.Show();
            }
            #endregion

            #region 调用选课信息处理
            if (treeViewHome.SelectedNode.Name == "ChooseProcess")
            {
                FormChooseProcess eFormChooseProcess = new FormChooseProcess(LoginUserName);
                eFormChooseProcess.TopLevel = false;
                eFormChooseProcess.Dock = DockStyle.Fill;
                eFormChooseProcess.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormChooseProcess);
                eFormChooseProcess.Show();
            }
            #endregion

            #region 调用选课信息查询
            if (treeViewHome.SelectedNode.Name == "ChooseQuery")
            {
                FormChooseQuery eFormChooseQuery = new FormChooseQuery(LoginUserName);
                eFormChooseQuery.TopLevel = false;
                eFormChooseQuery.Dock = DockStyle.Fill;
                eFormChooseQuery.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormChooseQuery);
                eFormChooseQuery.Show();
            }
            #endregion

            #region 调用用户密码修改
            if (treeViewHome.SelectedNode.Name == "UpdatePassword")
            {
                FormUpdatePassword eFormUpdatePassword = new FormUpdatePassword(LoginUserName);
                eFormUpdatePassword.TopLevel = false;
                eFormUpdatePassword.Dock = DockStyle.Fill;
                eFormUpdatePassword.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormUpdatePassword);
                eFormUpdatePassword.Show();
            }
            #endregion

            #region 调用学生用户处理
            if (treeViewHome.SelectedNode.Name == "StudentUserProcess")
            {
                FormStudentUserProcess eFormStudentUserProcess = new FormStudentUserProcess();
                eFormStudentUserProcess.TopLevel = false;
                eFormStudentUserProcess.Dock = DockStyle.Fill;
                eFormStudentUserProcess.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormStudentUserProcess);
                eFormStudentUserProcess.Show();
            }
            #endregion

            #region 调用学生用户查询
            if (treeViewHome.SelectedNode.Name == "StudentUserQuery")
            {
                FormStudentUserQuery eFormStudentUserQuery = new FormStudentUserQuery();
                eFormStudentUserQuery.TopLevel = false;
                eFormStudentUserQuery.Dock = DockStyle.Fill;
                eFormStudentUserQuery.FormBorderStyle = FormBorderStyle.None;
                splitContainerHome.Panel2.Controls.Clear();
                splitContainerHome.Panel2.Controls.Add(eFormStudentUserQuery);
                eFormStudentUserQuery.Show();
            }
            #endregion

            #region 注销系统
            if (treeViewHome.SelectedNode.Name == "ExitSystem")
            {
                if (MessageBox.Show("确定要退出系统吗?", "系统友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    treeViewHome.SelectedNode = treeViewHome.Nodes[0];
                }
            }
            #endregion

        }
    }
}
