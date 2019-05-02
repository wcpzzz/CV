namespace SSCIMS
{
    partial class FormStudentQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentQuery));
            this.sCStudentQueryMain = new System.Windows.Forms.SplitContainer();
            this.gBStudentQuery = new System.Windows.Forms.GroupBox();
            this.cBTel = new System.Windows.Forms.CheckBox();
            this.cBStuID = new System.Windows.Forms.CheckBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cBSex = new System.Windows.Forms.CheckBox();
            this.cBClass = new System.Windows.Forms.CheckBox();
            this.cBStuName = new System.Windows.Forms.CheckBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.cBProfession = new System.Windows.Forms.CheckBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.panelStudentQuery = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dGVStudentQuery = new System.Windows.Forms.DataGridView();
            this.sCStudentQueryMain.Panel1.SuspendLayout();
            this.sCStudentQueryMain.Panel2.SuspendLayout();
            this.sCStudentQueryMain.SuspendLayout();
            this.gBStudentQuery.SuspendLayout();
            this.panelStudentQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // sCStudentQueryMain
            // 
            this.sCStudentQueryMain.BackColor = System.Drawing.Color.Transparent;
            this.sCStudentQueryMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCStudentQueryMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCStudentQueryMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCStudentQueryMain.Location = new System.Drawing.Point(0, 0);
            this.sCStudentQueryMain.Name = "sCStudentQueryMain";
            this.sCStudentQueryMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCStudentQueryMain.Panel1
            // 
            this.sCStudentQueryMain.Panel1.Controls.Add(this.gBStudentQuery);
            this.sCStudentQueryMain.Panel1.Controls.Add(this.panelStudentQuery);
            // 
            // sCStudentQueryMain.Panel2
            // 
            this.sCStudentQueryMain.Panel2.Controls.Add(this.dGVStudentQuery);
            this.sCStudentQueryMain.Size = new System.Drawing.Size(747, 415);
            this.sCStudentQueryMain.SplitterDistance = 192;
            this.sCStudentQueryMain.TabIndex = 0;
            // 
            // gBStudentQuery
            // 
            this.gBStudentQuery.Controls.Add(this.cBTel);
            this.gBStudentQuery.Controls.Add(this.cBStuID);
            this.gBStudentQuery.Controls.Add(this.txtTel);
            this.gBStudentQuery.Controls.Add(this.cBSex);
            this.gBStudentQuery.Controls.Add(this.cBClass);
            this.gBStudentQuery.Controls.Add(this.cBStuName);
            this.gBStudentQuery.Controls.Add(this.txtClass);
            this.gBStudentQuery.Controls.Add(this.txtStuID);
            this.gBStudentQuery.Controls.Add(this.cBProfession);
            this.gBStudentQuery.Controls.Add(this.txtStuName);
            this.gBStudentQuery.Controls.Add(this.txtProfession);
            this.gBStudentQuery.Controls.Add(this.cbxSex);
            this.gBStudentQuery.Location = new System.Drawing.Point(24, 56);
            this.gBStudentQuery.Name = "gBStudentQuery";
            this.gBStudentQuery.Size = new System.Drawing.Size(691, 125);
            this.gBStudentQuery.TabIndex = 1;
            this.gBStudentQuery.TabStop = false;
            this.gBStudentQuery.Text = "请设置查询条件(无选择为查询全部,学号、姓名和专业支持模糊查找):";
            // 
            // cBTel
            // 
            this.cBTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cBTel.AutoSize = true;
            this.cBTel.Location = new System.Drawing.Point(449, 98);
            this.cBTel.Name = "cBTel";
            this.cBTel.Size = new System.Drawing.Size(54, 18);
            this.cBTel.TabIndex = 29;
            this.cBTel.Text = "电话";
            this.cBTel.UseVisualStyleBackColor = true;
            this.cBTel.CheckStateChanged += new System.EventHandler(this.cBTel_CheckStateChanged);
            // 
            // cBStuID
            // 
            this.cBStuID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBStuID.AutoSize = true;
            this.cBStuID.Location = new System.Drawing.Point(19, 32);
            this.cBStuID.Name = "cBStuID";
            this.cBStuID.Size = new System.Drawing.Size(54, 18);
            this.cBStuID.TabIndex = 19;
            this.cBStuID.Text = "学号";
            this.cBStuID.UseVisualStyleBackColor = true;
            this.cBStuID.CheckStateChanged += new System.EventHandler(this.cBStuID_CheckStateChanged);
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(533, 98);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(130, 23);
            this.txtTel.TabIndex = 28;
            // 
            // cBSex
            // 
            this.cBSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBSex.AutoSize = true;
            this.cBSex.Location = new System.Drawing.Point(19, 98);
            this.cBSex.Name = "cBSex";
            this.cBSex.Size = new System.Drawing.Size(54, 18);
            this.cBSex.TabIndex = 23;
            this.cBSex.Text = "性别";
            this.cBSex.UseVisualStyleBackColor = true;
            this.cBSex.CheckedChanged += new System.EventHandler(this.cBSex_CheckStateChanged);
            // 
            // cBClass
            // 
            this.cBClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cBClass.AutoSize = true;
            this.cBClass.Location = new System.Drawing.Point(449, 65);
            this.cBClass.Name = "cBClass";
            this.cBClass.Size = new System.Drawing.Size(54, 18);
            this.cBClass.TabIndex = 27;
            this.cBClass.Text = "班级";
            this.cBClass.UseVisualStyleBackColor = true;
            this.cBClass.CheckedChanged += new System.EventHandler(this.cBClass_CheckStateChanged);
            // 
            // cBStuName
            // 
            this.cBStuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBStuName.AutoSize = true;
            this.cBStuName.Location = new System.Drawing.Point(19, 65);
            this.cBStuName.Name = "cBStuName";
            this.cBStuName.Size = new System.Drawing.Size(54, 18);
            this.cBStuName.TabIndex = 21;
            this.cBStuName.Text = "姓名";
            this.cBStuName.UseVisualStyleBackColor = true;
            this.cBStuName.CheckedChanged += new System.EventHandler(this.cBStuName_CheckStateChanged);
            // 
            // txtClass
            // 
            this.txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClass.Location = new System.Drawing.Point(533, 65);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(130, 23);
            this.txtClass.TabIndex = 26;
            // 
            // txtStuID
            // 
            this.txtStuID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStuID.Location = new System.Drawing.Point(90, 33);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(130, 23);
            this.txtStuID.TabIndex = 18;
            // 
            // cBProfession
            // 
            this.cBProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cBProfession.AutoSize = true;
            this.cBProfession.Location = new System.Drawing.Point(449, 32);
            this.cBProfession.Name = "cBProfession";
            this.cBProfession.Size = new System.Drawing.Size(54, 18);
            this.cBProfession.TabIndex = 25;
            this.cBProfession.Text = "专业";
            this.cBProfession.UseVisualStyleBackColor = true;
            this.cBProfession.CheckedChanged += new System.EventHandler(this.cBProfession_CheckStateChanged);
            // 
            // txtStuName
            // 
            this.txtStuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStuName.Location = new System.Drawing.Point(90, 66);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(130, 23);
            this.txtStuName.TabIndex = 20;
            // 
            // txtProfession
            // 
            this.txtProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfession.Location = new System.Drawing.Point(533, 32);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(130, 23);
            this.txtProfession.TabIndex = 24;
            // 
            // cbxSex
            // 
            this.cbxSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxSex.Location = new System.Drawing.Point(90, 100);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(130, 21);
            this.cbxSex.TabIndex = 22;
            // 
            // panelStudentQuery
            // 
            this.panelStudentQuery.Controls.Add(this.btnReset);
            this.panelStudentQuery.Controls.Add(this.btnQuery);
            this.panelStudentQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentQuery.Location = new System.Drawing.Point(0, 0);
            this.panelStudentQuery.Name = "panelStudentQuery";
            this.panelStudentQuery.Size = new System.Drawing.Size(743, 45);
            this.panelStudentQuery.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReset.Location = new System.Drawing.Point(45, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuery.Location = new System.Drawing.Point(0, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(45, 45);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dGVStudentQuery
            // 
            this.dGVStudentQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVStudentQuery.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVStudentQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVStudentQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudentQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVStudentQuery.Location = new System.Drawing.Point(0, 0);
            this.dGVStudentQuery.Name = "dGVStudentQuery";
            this.dGVStudentQuery.RowTemplate.Height = 23;
            this.dGVStudentQuery.Size = new System.Drawing.Size(743, 215);
            this.dGVStudentQuery.TabIndex = 0;
            // 
            // FormStudentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.sCStudentQueryMain);
            this.Name = "FormStudentQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息查询";
            this.Load += new System.EventHandler(this.FormStudentQuery_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormStudentQuery_Layout);
            this.sCStudentQueryMain.Panel1.ResumeLayout(false);
            this.sCStudentQueryMain.Panel2.ResumeLayout(false);
            this.sCStudentQueryMain.ResumeLayout(false);
            this.gBStudentQuery.ResumeLayout(false);
            this.gBStudentQuery.PerformLayout();
            this.panelStudentQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVStudentQuery;
        protected internal System.Windows.Forms.SplitContainer sCStudentQueryMain;
        protected internal System.Windows.Forms.Button btnQuery;
        protected internal System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cBClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.CheckBox cBProfession;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.CheckBox cBSex;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.CheckBox cBStuName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.CheckBox cBStuID;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.CheckBox cBTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.GroupBox gBStudentQuery;
        private System.Windows.Forms.Panel panelStudentQuery;


    }
}