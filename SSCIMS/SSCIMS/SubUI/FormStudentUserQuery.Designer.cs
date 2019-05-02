namespace SSCIMS
{
    partial class FormStudentUserQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentUserQuery));
            this.sCStudentUserQueryMain = new System.Windows.Forms.SplitContainer();
            this.gBStudentProcessTop = new System.Windows.Forms.GroupBox();
            this.cBCreateDate = new System.Windows.Forms.CheckBox();
            this.cBUserName = new System.Windows.Forms.CheckBox();
            this.gBCreateDate = new System.Windows.Forms.GroupBox();
            this.dTPOutEnd = new System.Windows.Forms.DateTimePicker();
            this.lblOutEnd = new System.Windows.Forms.Label();
            this.dTPOutBegin = new System.Windows.Forms.DateTimePicker();
            this.lblOutIn = new System.Windows.Forms.Label();
            this.rBOut = new System.Windows.Forms.RadioButton();
            this.dTPInEnd = new System.Windows.Forms.DateTimePicker();
            this.lblInEnd = new System.Windows.Forms.Label();
            this.dTPInBegin = new System.Windows.Forms.DateTimePicker();
            this.lblInBegin = new System.Windows.Forms.Label();
            this.rBIn = new System.Windows.Forms.RadioButton();
            this.dTPSingle = new System.Windows.Forms.DateTimePicker();
            this.cbxSingle = new System.Windows.Forms.ComboBox();
            this.rBSingle = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panelStudentUserQuery = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.dGVStudentUserQuery = new System.Windows.Forms.DataGridView();
            this.btnCourseAllCancel = new System.Windows.Forms.Button();
            this.btnCourseAllChoose = new System.Windows.Forms.Button();
            this.sCStudentUserQueryMain.Panel1.SuspendLayout();
            this.sCStudentUserQueryMain.Panel2.SuspendLayout();
            this.sCStudentUserQueryMain.SuspendLayout();
            this.gBStudentProcessTop.SuspendLayout();
            this.gBCreateDate.SuspendLayout();
            this.panelStudentUserQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentUserQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // sCStudentUserQueryMain
            // 
            this.sCStudentUserQueryMain.BackColor = System.Drawing.Color.Transparent;
            this.sCStudentUserQueryMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCStudentUserQueryMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCStudentUserQueryMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCStudentUserQueryMain.Location = new System.Drawing.Point(0, 0);
            this.sCStudentUserQueryMain.Name = "sCStudentUserQueryMain";
            this.sCStudentUserQueryMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCStudentUserQueryMain.Panel1
            // 
            this.sCStudentUserQueryMain.Panel1.Controls.Add(this.gBStudentProcessTop);
            this.sCStudentUserQueryMain.Panel1.Controls.Add(this.panelStudentUserQuery);
            // 
            // sCStudentUserQueryMain.Panel2
            // 
            this.sCStudentUserQueryMain.Panel2.Controls.Add(this.dGVStudentUserQuery);
            this.sCStudentUserQueryMain.Size = new System.Drawing.Size(739, 415);
            this.sCStudentUserQueryMain.SplitterDistance = 248;
            this.sCStudentUserQueryMain.TabIndex = 0;
            // 
            // gBStudentProcessTop
            // 
            this.gBStudentProcessTop.Controls.Add(this.cBCreateDate);
            this.gBStudentProcessTop.Controls.Add(this.cBUserName);
            this.gBStudentProcessTop.Controls.Add(this.gBCreateDate);
            this.gBStudentProcessTop.Controls.Add(this.txtUserName);
            this.gBStudentProcessTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBStudentProcessTop.Location = new System.Drawing.Point(9, 51);
            this.gBStudentProcessTop.Name = "gBStudentProcessTop";
            this.gBStudentProcessTop.Size = new System.Drawing.Size(717, 181);
            this.gBStudentProcessTop.TabIndex = 0;
            this.gBStudentProcessTop.TabStop = false;
            this.gBStudentProcessTop.Text = "请输入查询条件";
            // 
            // cBCreateDate
            // 
            this.cBCreateDate.AutoSize = true;
            this.cBCreateDate.Location = new System.Drawing.Point(11, 69);
            this.cBCreateDate.Name = "cBCreateDate";
            this.cBCreateDate.Size = new System.Drawing.Size(96, 18);
            this.cBCreateDate.TabIndex = 5;
            this.cBCreateDate.Text = "创建日期：";
            this.cBCreateDate.UseVisualStyleBackColor = true;
            this.cBCreateDate.CheckStateChanged += new System.EventHandler(this.cBCreateDate_CheckStateChanged);
            // 
            // cBUserName
            // 
            this.cBUserName.AutoSize = true;
            this.cBUserName.Location = new System.Drawing.Point(11, 32);
            this.cBUserName.Name = "cBUserName";
            this.cBUserName.Size = new System.Drawing.Size(96, 18);
            this.cBUserName.TabIndex = 4;
            this.cBUserName.Text = "用 户 名：";
            this.cBUserName.UseVisualStyleBackColor = true;
            this.cBUserName.CheckStateChanged += new System.EventHandler(this.cBUserName_CheckStateChanged);
            // 
            // gBCreateDate
            // 
            this.gBCreateDate.Controls.Add(this.dTPOutEnd);
            this.gBCreateDate.Controls.Add(this.lblOutEnd);
            this.gBCreateDate.Controls.Add(this.dTPOutBegin);
            this.gBCreateDate.Controls.Add(this.lblOutIn);
            this.gBCreateDate.Controls.Add(this.rBOut);
            this.gBCreateDate.Controls.Add(this.dTPInEnd);
            this.gBCreateDate.Controls.Add(this.lblInEnd);
            this.gBCreateDate.Controls.Add(this.dTPInBegin);
            this.gBCreateDate.Controls.Add(this.lblInBegin);
            this.gBCreateDate.Controls.Add(this.rBIn);
            this.gBCreateDate.Controls.Add(this.dTPSingle);
            this.gBCreateDate.Controls.Add(this.cbxSingle);
            this.gBCreateDate.Controls.Add(this.rBSingle);
            this.gBCreateDate.Location = new System.Drawing.Point(112, 49);
            this.gBCreateDate.Name = "gBCreateDate";
            this.gBCreateDate.Size = new System.Drawing.Size(497, 117);
            this.gBCreateDate.TabIndex = 3;
            this.gBCreateDate.TabStop = false;
            // 
            // dTPOutEnd
            // 
            this.dTPOutEnd.Location = new System.Drawing.Point(366, 84);
            this.dTPOutEnd.Name = "dTPOutEnd";
            this.dTPOutEnd.Size = new System.Drawing.Size(122, 23);
            this.dTPOutEnd.TabIndex = 12;
            // 
            // lblOutEnd
            // 
            this.lblOutEnd.AutoSize = true;
            this.lblOutEnd.Location = new System.Drawing.Point(315, 89);
            this.lblOutEnd.Name = "lblOutEnd";
            this.lblOutEnd.Size = new System.Drawing.Size(35, 14);
            this.lblOutEnd.TabIndex = 11;
            this.lblOutEnd.Text = "后于";
            // 
            // dTPOutBegin
            // 
            this.dTPOutBegin.Location = new System.Drawing.Point(185, 84);
            this.dTPOutBegin.Name = "dTPOutBegin";
            this.dTPOutBegin.Size = new System.Drawing.Size(122, 23);
            this.dTPOutBegin.TabIndex = 10;
            // 
            // lblOutIn
            // 
            this.lblOutIn.AutoSize = true;
            this.lblOutIn.Location = new System.Drawing.Point(120, 89);
            this.lblOutIn.Name = "lblOutIn";
            this.lblOutIn.Size = new System.Drawing.Size(35, 14);
            this.lblOutIn.TabIndex = 9;
            this.lblOutIn.Text = "先于";
            // 
            // rBOut
            // 
            this.rBOut.AutoSize = true;
            this.rBOut.Location = new System.Drawing.Point(20, 86);
            this.rBOut.Name = "rBOut";
            this.rBOut.Size = new System.Drawing.Size(95, 18);
            this.rBOut.TabIndex = 8;
            this.rBOut.TabStop = true;
            this.rBOut.Text = "域外条件：";
            this.rBOut.UseVisualStyleBackColor = true;
            this.rBOut.CheckedChanged += new System.EventHandler(this.rBOut_CheckedChanged);
            // 
            // dTPInEnd
            // 
            this.dTPInEnd.Location = new System.Drawing.Point(366, 53);
            this.dTPInEnd.Name = "dTPInEnd";
            this.dTPInEnd.Size = new System.Drawing.Size(122, 23);
            this.dTPInEnd.TabIndex = 7;
            // 
            // lblInEnd
            // 
            this.lblInEnd.AutoSize = true;
            this.lblInEnd.Location = new System.Drawing.Point(315, 58);
            this.lblInEnd.Name = "lblInEnd";
            this.lblInEnd.Size = new System.Drawing.Size(35, 14);
            this.lblInEnd.TabIndex = 6;
            this.lblInEnd.Text = "止于";
            // 
            // dTPInBegin
            // 
            this.dTPInBegin.Location = new System.Drawing.Point(185, 53);
            this.dTPInBegin.Name = "dTPInBegin";
            this.dTPInBegin.Size = new System.Drawing.Size(122, 23);
            this.dTPInBegin.TabIndex = 5;
            // 
            // lblInBegin
            // 
            this.lblInBegin.AutoSize = true;
            this.lblInBegin.Location = new System.Drawing.Point(120, 58);
            this.lblInBegin.Name = "lblInBegin";
            this.lblInBegin.Size = new System.Drawing.Size(35, 14);
            this.lblInBegin.TabIndex = 4;
            this.lblInBegin.Text = "起于";
            // 
            // rBIn
            // 
            this.rBIn.AutoSize = true;
            this.rBIn.Location = new System.Drawing.Point(20, 55);
            this.rBIn.Name = "rBIn";
            this.rBIn.Size = new System.Drawing.Size(95, 18);
            this.rBIn.TabIndex = 3;
            this.rBIn.TabStop = true;
            this.rBIn.Text = "区域条件：";
            this.rBIn.UseVisualStyleBackColor = true;
            this.rBIn.CheckedChanged += new System.EventHandler(this.rBIn_CheckedChanged);
            // 
            // dTPSingle
            // 
            this.dTPSingle.Location = new System.Drawing.Point(185, 20);
            this.dTPSingle.Name = "dTPSingle";
            this.dTPSingle.Size = new System.Drawing.Size(122, 23);
            this.dTPSingle.TabIndex = 2;
            // 
            // cbxSingle
            // 
            this.cbxSingle.FormattingEnabled = true;
            this.cbxSingle.Items.AddRange(new object[] {
            ">=",
            "<=",
            "="});
            this.cbxSingle.Location = new System.Drawing.Point(117, 21);
            this.cbxSingle.Name = "cbxSingle";
            this.cbxSingle.Size = new System.Drawing.Size(62, 21);
            this.cbxSingle.TabIndex = 1;
            // 
            // rBSingle
            // 
            this.rBSingle.AutoSize = true;
            this.rBSingle.Location = new System.Drawing.Point(20, 22);
            this.rBSingle.Name = "rBSingle";
            this.rBSingle.Size = new System.Drawing.Size(81, 18);
            this.rBSingle.TabIndex = 0;
            this.rBSingle.TabStop = true;
            this.rBSingle.Text = "单条件：";
            this.rBSingle.UseVisualStyleBackColor = true;
            this.rBSingle.CheckedChanged += new System.EventHandler(this.rBSingle_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(112, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(127, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // panelStudentUserQuery
            // 
            this.panelStudentUserQuery.Controls.Add(this.btnCourseAllCancel);
            this.panelStudentUserQuery.Controls.Add(this.btnCourseAllChoose);
            this.panelStudentUserQuery.Controls.Add(this.btnQuery);
            this.panelStudentUserQuery.Controls.Add(this.btnReset);
            this.panelStudentUserQuery.Controls.Add(this.btnResetPassword);
            this.panelStudentUserQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentUserQuery.Location = new System.Drawing.Point(0, 0);
            this.panelStudentUserQuery.Name = "panelStudentUserQuery";
            this.panelStudentUserQuery.Size = new System.Drawing.Size(735, 45);
            this.panelStudentUserQuery.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.Location = new System.Drawing.Point(1, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(45, 45);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(46, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.BackgroundImage")));
            this.btnResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResetPassword.Location = new System.Drawing.Point(596, 0);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(45, 45);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "重置密码";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // dGVStudentUserQuery
            // 
            this.dGVStudentUserQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVStudentUserQuery.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVStudentUserQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVStudentUserQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudentUserQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVStudentUserQuery.Location = new System.Drawing.Point(0, 0);
            this.dGVStudentUserQuery.Name = "dGVStudentUserQuery";
            this.dGVStudentUserQuery.RowTemplate.Height = 23;
            this.dGVStudentUserQuery.Size = new System.Drawing.Size(735, 159);
            this.dGVStudentUserQuery.TabIndex = 0;
            this.dGVStudentUserQuery.Click += new System.EventHandler(this.dGVStudentUserQuery_Click);
            // 
            // btnCourseAllCancel
            // 
            this.btnCourseAllCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCourseAllCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCourseAllCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCourseAllCancel.BackgroundImage")));
            this.btnCourseAllCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCourseAllCancel.Location = new System.Drawing.Point(686, 0);
            this.btnCourseAllCancel.Name = "btnCourseAllCancel";
            this.btnCourseAllCancel.Size = new System.Drawing.Size(45, 45);
            this.btnCourseAllCancel.TabIndex = 4;
            this.btnCourseAllCancel.Text = "取消";
            this.btnCourseAllCancel.UseVisualStyleBackColor = false;
            this.btnCourseAllCancel.Click += new System.EventHandler(this.btnCourseAllCancel_Click);
            // 
            // btnCourseAllChoose
            // 
            this.btnCourseAllChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCourseAllChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnCourseAllChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCourseAllChoose.BackgroundImage")));
            this.btnCourseAllChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCourseAllChoose.Location = new System.Drawing.Point(641, 0);
            this.btnCourseAllChoose.Name = "btnCourseAllChoose";
            this.btnCourseAllChoose.Size = new System.Drawing.Size(45, 45);
            this.btnCourseAllChoose.TabIndex = 3;
            this.btnCourseAllChoose.Text = "全选";
            this.btnCourseAllChoose.UseVisualStyleBackColor = false;
            this.btnCourseAllChoose.Click += new System.EventHandler(this.btnCourseAllChoose_Click);
            // 
            // FormStudentUserQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 415);
            this.Controls.Add(this.sCStudentUserQueryMain);
            this.Name = "FormStudentUserQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生用户查询";
            this.Load += new System.EventHandler(this.FormStudentUserQuery_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormStudentUserQuery_Layout);
            this.sCStudentUserQueryMain.Panel1.ResumeLayout(false);
            this.sCStudentUserQueryMain.Panel2.ResumeLayout(false);
            this.sCStudentUserQueryMain.ResumeLayout(false);
            this.gBStudentProcessTop.ResumeLayout(false);
            this.gBStudentProcessTop.PerformLayout();
            this.gBCreateDate.ResumeLayout(false);
            this.gBCreateDate.PerformLayout();
            this.panelStudentUserQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentUserQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sCStudentUserQueryMain;
        private System.Windows.Forms.DataGridView dGVStudentUserQuery;
        private System.Windows.Forms.GroupBox gBStudentProcessTop;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox gBCreateDate;
        private System.Windows.Forms.RadioButton rBSingle;
        private System.Windows.Forms.RadioButton rBIn;
        private System.Windows.Forms.DateTimePicker dTPSingle;
        private System.Windows.Forms.ComboBox cbxSingle;
        private System.Windows.Forms.Label lblInBegin;
        private System.Windows.Forms.DateTimePicker dTPInEnd;
        private System.Windows.Forms.Label lblInEnd;
        private System.Windows.Forms.DateTimePicker dTPInBegin;
        private System.Windows.Forms.DateTimePicker dTPOutEnd;
        private System.Windows.Forms.Label lblOutEnd;
        private System.Windows.Forms.DateTimePicker dTPOutBegin;
        private System.Windows.Forms.Label lblOutIn;
        private System.Windows.Forms.RadioButton rBOut;
        protected internal System.Windows.Forms.Button btnResetPassword;
        protected internal System.Windows.Forms.Button btnReset;
        protected internal System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox cBUserName;
        private System.Windows.Forms.CheckBox cBCreateDate;
        private System.Windows.Forms.Panel panelStudentUserQuery;
        protected internal System.Windows.Forms.Button btnCourseAllCancel;
        protected internal System.Windows.Forms.Button btnCourseAllChoose;

    }
}