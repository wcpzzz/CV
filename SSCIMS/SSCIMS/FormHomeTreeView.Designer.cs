namespace SSCIMS
{
    partial class FormHomeTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeTreeView));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("学生信息处理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("学生信息查询");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("学生信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("课程信息处理");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("课程信息查询");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("课程信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("选课信息处理");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("选课信息查询");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("选课信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("用户密码修改");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("用户信息处理");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("学生用户查询");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("学生用户管理", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("用户信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("注销系统");
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.splitContainerHome = new System.Windows.Forms.SplitContainer();
            this.groupBoxNav = new System.Windows.Forms.GroupBox();
            this.treeViewHome = new System.Windows.Forms.TreeView();
            this.imageListleft = new System.Windows.Forms.ImageList(this.components);
            this.panelTop.SuspendLayout();
            this.splitContainerHome.Panel1.SuspendLayout();
            this.splitContainerHome.SuspendLayout();
            this.groupBoxNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.lblCaption);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(744, 110);
            this.panelTop.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("华文行楷", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(115, 26);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(578, 42);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "欢迎访问高校学生选课管理系统";
            // 
            // splitContainerHome
            // 
            this.splitContainerHome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainerHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHome.Location = new System.Drawing.Point(0, 110);
            this.splitContainerHome.Name = "splitContainerHome";
            // 
            // splitContainerHome.Panel1
            // 
            this.splitContainerHome.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerHome.Panel1.Controls.Add(this.groupBoxNav);
            // 
            // splitContainerHome.Panel2
            // 
            this.splitContainerHome.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainerHome.Panel2.BackgroundImage")));
            this.splitContainerHome.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerHome.Size = new System.Drawing.Size(744, 306);
            this.splitContainerHome.SplitterDistance = 138;
            this.splitContainerHome.TabIndex = 1;
            // 
            // groupBoxNav
            // 
            this.groupBoxNav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxNav.Controls.Add(this.treeViewHome);
            this.groupBoxNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNav.Font = new System.Drawing.Font("华文隶书", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxNav.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBoxNav.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNav.Name = "groupBoxNav";
            this.groupBoxNav.Size = new System.Drawing.Size(134, 302);
            this.groupBoxNav.TabIndex = 0;
            this.groupBoxNav.TabStop = false;
            this.groupBoxNav.Text = "系统导航";
            // 
            // treeViewHome
            // 
            this.treeViewHome.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.treeViewHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewHome.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewHome.ImageIndex = 0;
            this.treeViewHome.ImageList = this.imageListleft;
            this.treeViewHome.ItemHeight = 25;
            this.treeViewHome.Location = new System.Drawing.Point(3, 23);
            this.treeViewHome.Name = "treeViewHome";
            treeNode1.Name = "StudentProcess";
            treeNode1.Text = "学生信息处理";
            treeNode2.Name = "StudentQuery";
            treeNode2.Text = "学生信息查询";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "StudentManage";
            treeNode3.Text = "学生信息管理";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "CourseProcess";
            treeNode4.Text = "课程信息处理";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "CourseQuery";
            treeNode5.Text = "课程信息查询";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "CourseManage";
            treeNode6.Text = "课程信息管理";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "ChooseProcess";
            treeNode7.Text = "选课信息处理";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "ChooseQuery";
            treeNode8.Text = "选课信息查询";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "ChooseManage";
            treeNode9.Text = "选课信息管理";
            treeNode10.ImageIndex = 3;
            treeNode10.Name = "UpdatePassword";
            treeNode10.Text = "用户密码修改";
            treeNode11.ImageIndex = 3;
            treeNode11.Name = "StudentUserProcess";
            treeNode11.Text = "用户信息处理";
            treeNode12.ImageIndex = 3;
            treeNode12.Name = "StudentUserQuery";
            treeNode12.Text = "学生用户查询";
            treeNode13.ImageIndex = 3;
            treeNode13.Name = "StudentUserManage";
            treeNode13.Text = "学生用户管理";
            treeNode14.ImageIndex = 3;
            treeNode14.Name = "UserManage";
            treeNode14.Text = "用户信息管理";
            treeNode15.ImageIndex = 4;
            treeNode15.Name = "ExitSystem";
            treeNode15.Text = "注销系统";
            this.treeViewHome.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode14,
            treeNode15});
            this.treeViewHome.SelectedImageIndex = 0;
            this.treeViewHome.Size = new System.Drawing.Size(128, 276);
            this.treeViewHome.TabIndex = 0;
            this.treeViewHome.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewHome_AfterSelect);
            // 
            // imageListleft
            // 
            this.imageListleft.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListleft.ImageStream")));
            this.imageListleft.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListleft.Images.SetKeyName(0, "btnstyle_3.png");
            this.imageListleft.Images.SetKeyName(1, "btnstyle_1.png");
            this.imageListleft.Images.SetKeyName(2, "btnstyle_2.png");
            this.imageListleft.Images.SetKeyName(3, "btnstyle_3.jpg");
            this.imageListleft.Images.SetKeyName(4, "btnstyle_2.jpg");
            // 
            // FormHomeTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 416);
            this.Controls.Add(this.splitContainerHome);
            this.Controls.Add(this.panelTop);
            this.Name = "FormHomeTreeView";
            this.Text = "高校学生选课管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainerHome.Panel1.ResumeLayout(false);
            this.splitContainerHome.ResumeLayout(false);
            this.groupBoxNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitContainerHome;
        private System.Windows.Forms.TreeView treeViewHome;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.ImageList imageListleft;
        private System.Windows.Forms.GroupBox groupBoxNav;
    }
}