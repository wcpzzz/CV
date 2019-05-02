namespace SSCIMS
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.MenuItemStudentManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudentProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudentQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCourseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCourseProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCourseQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChooseProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChooseQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUpdatePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudentUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudentUserProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudentUserQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDataMining = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTurnData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMining = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStudentManage,
            this.MenuItemCourseManage,
            this.MenuItemChoose,
            this.MenuItemDataMining,
            this.MenuItemUserManage,
            this.MenuItemExit});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(700, 25);
            this.menuStripHome.TabIndex = 0;
            // 
            // MenuItemStudentManage
            // 
            this.MenuItemStudentManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStudentProcess,
            this.MenuItemStudentQuery});
            this.MenuItemStudentManage.Name = "MenuItemStudentManage";
            this.MenuItemStudentManage.Size = new System.Drawing.Size(107, 21);
            this.MenuItemStudentManage.Text = "学生信息管理(&S)";
            // 
            // MenuItemStudentProcess
            // 
            this.MenuItemStudentProcess.Name = "MenuItemStudentProcess";
            this.MenuItemStudentProcess.Size = new System.Drawing.Size(148, 22);
            this.MenuItemStudentProcess.Text = "学生信息处理";
            this.MenuItemStudentProcess.Click += new System.EventHandler(this.MenuItemStudentProcess_Click);
            // 
            // MenuItemStudentQuery
            // 
            this.MenuItemStudentQuery.Name = "MenuItemStudentQuery";
            this.MenuItemStudentQuery.Size = new System.Drawing.Size(148, 22);
            this.MenuItemStudentQuery.Text = "学生信息查询";
            this.MenuItemStudentQuery.Click += new System.EventHandler(this.MenuItemStudentQuery_Click);
            // 
            // MenuItemCourseManage
            // 
            this.MenuItemCourseManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCourseProcess,
            this.MenuItemCourseQuery});
            this.MenuItemCourseManage.Name = "MenuItemCourseManage";
            this.MenuItemCourseManage.Size = new System.Drawing.Size(108, 21);
            this.MenuItemCourseManage.Text = "课程信息管理(&C)";
            // 
            // MenuItemCourseProcess
            // 
            this.MenuItemCourseProcess.Name = "MenuItemCourseProcess";
            this.MenuItemCourseProcess.Size = new System.Drawing.Size(148, 22);
            this.MenuItemCourseProcess.Text = "课程信息处理";
            this.MenuItemCourseProcess.Click += new System.EventHandler(this.MenuItemCourseProcess_Click);
            // 
            // MenuItemCourseQuery
            // 
            this.MenuItemCourseQuery.Name = "MenuItemCourseQuery";
            this.MenuItemCourseQuery.Size = new System.Drawing.Size(148, 22);
            this.MenuItemCourseQuery.Text = "课程信息查询";
            this.MenuItemCourseQuery.Click += new System.EventHandler(this.MenuItemCourseQuery_Click);
            // 
            // MenuItemChoose
            // 
            this.MenuItemChoose.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChooseProcess,
            this.MenuItemChooseQuery});
            this.MenuItemChoose.Name = "MenuItemChoose";
            this.MenuItemChoose.Size = new System.Drawing.Size(109, 21);
            this.MenuItemChoose.Text = "选课信息管理(&H)";
            // 
            // MenuItemChooseProcess
            // 
            this.MenuItemChooseProcess.Name = "MenuItemChooseProcess";
            this.MenuItemChooseProcess.Size = new System.Drawing.Size(152, 22);
            this.MenuItemChooseProcess.Text = "选课信息处理";
            this.MenuItemChooseProcess.Click += new System.EventHandler(this.MenuItemChooseProcess_Click);
            // 
            // MenuItemChooseQuery
            // 
            this.MenuItemChooseQuery.Name = "MenuItemChooseQuery";
            this.MenuItemChooseQuery.Size = new System.Drawing.Size(152, 22);
            this.MenuItemChooseQuery.Text = "选课信息查询";
            this.MenuItemChooseQuery.Click += new System.EventHandler(this.MenuItemChooseQuery_Click);
            // 
            // MenuItemUserManage
            // 
            this.MenuItemUserManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUpdatePassword,
            this.MenuItemStudentUserManage});
            this.MenuItemUserManage.Name = "MenuItemUserManage";
            this.MenuItemUserManage.Size = new System.Drawing.Size(109, 21);
            this.MenuItemUserManage.Text = "用户信息管理(&U)";
            // 
            // MenuItemUpdatePassword
            // 
            this.MenuItemUpdatePassword.Name = "MenuItemUpdatePassword";
            this.MenuItemUpdatePassword.Size = new System.Drawing.Size(152, 22);
            this.MenuItemUpdatePassword.Text = "用户密码修改";
            this.MenuItemUpdatePassword.Click += new System.EventHandler(this.MenuItemUpdatePassword_Click);
            // 
            // MenuItemStudentUserManage
            // 
            this.MenuItemStudentUserManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStudentUserProcess,
            this.MenuItemStudentUserQuery});
            this.MenuItemStudentUserManage.Name = "MenuItemStudentUserManage";
            this.MenuItemStudentUserManage.Size = new System.Drawing.Size(152, 22);
            this.MenuItemStudentUserManage.Text = "学生用户管理";
            // 
            // MenuItemStudentUserProcess
            // 
            this.MenuItemStudentUserProcess.Name = "MenuItemStudentUserProcess";
            this.MenuItemStudentUserProcess.Size = new System.Drawing.Size(148, 22);
            this.MenuItemStudentUserProcess.Text = "用户信息处理";
            this.MenuItemStudentUserProcess.Click += new System.EventHandler(this.MenuItemStudentUserProcess_Click);
            // 
            // MenuItemStudentUserQuery
            // 
            this.MenuItemStudentUserQuery.Name = "MenuItemStudentUserQuery";
            this.MenuItemStudentUserQuery.Size = new System.Drawing.Size(148, 22);
            this.MenuItemStudentUserQuery.Text = "学生用户查询";
            this.MenuItemStudentUserQuery.Click += new System.EventHandler(this.MenuItemStudentUserQuery_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(86, 21);
            this.MenuItemExit.Text = "注销系统(&Q)";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemDataMining
            // 
            this.MenuItemDataMining.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTurnData,
            this.MenuItemMining});
            this.MenuItemDataMining.Name = "MenuItemDataMining";
            this.MenuItemDataMining.Size = new System.Drawing.Size(85, 21);
            this.MenuItemDataMining.Text = "智能分析(&D)";
            // 
            // MenuItemTurnData
            // 
            this.MenuItemTurnData.Name = "MenuItemTurnData";
            this.MenuItemTurnData.Size = new System.Drawing.Size(152, 22);
            this.MenuItemTurnData.Text = "数据转换(&T)";
            this.MenuItemTurnData.Click += new System.EventHandler(this.MenuItemTurnData_Click);
            // 
            // MenuItemMining
            // 
            this.MenuItemMining.Name = "MenuItemMining";
            this.MenuItemMining.Size = new System.Drawing.Size(152, 22);
            this.MenuItemMining.Text = "关联分析(&A)";
            this.MenuItemMining.Click += new System.EventHandler(this.MenuItemMining_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 326);
            this.Controls.Add(this.menuStripHome);
            this.MainMenuStrip = this.menuStripHome;
            this.Name = "FormHome";
            this.Text = "高校学生选课管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudentManage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCourseManage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChoose;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUserManage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudentProcess;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudentQuery;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCourseProcess;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCourseQuery;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChooseProcess;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChooseQuery;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUpdatePassword;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudentUserManage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudentUserProcess;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudentUserQuery;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDataMining;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTurnData;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMining;
    }
}