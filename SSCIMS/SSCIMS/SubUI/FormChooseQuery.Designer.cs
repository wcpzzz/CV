namespace SSCIMS
{
    partial class FormChooseQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChooseQuery));
            this.sCChooseQueryMain = new System.Windows.Forms.SplitContainer();
            this.cBInputGrade = new System.Windows.Forms.CheckBox();
            this.cBGiveYear = new System.Windows.Forms.CheckBox();
            this.gBGiveYear = new System.Windows.Forms.GroupBox();
            this.lblYearOutEnd = new System.Windows.Forms.Label();
            this.lblYearOutBegin = new System.Windows.Forms.Label();
            this.lblYearInEnd = new System.Windows.Forms.Label();
            this.lblYearInBegin = new System.Windows.Forms.Label();
            this.dTPYearOutEnd = new System.Windows.Forms.DateTimePicker();
            this.dTPYearOutBegin = new System.Windows.Forms.DateTimePicker();
            this.rBYearOut = new System.Windows.Forms.RadioButton();
            this.dTPYearInEnd = new System.Windows.Forms.DateTimePicker();
            this.dTPYearInBegin = new System.Windows.Forms.DateTimePicker();
            this.rBYearIn = new System.Windows.Forms.RadioButton();
            this.dTPGivenYearSingle = new System.Windows.Forms.DateTimePicker();
            this.cbxSignYear = new System.Windows.Forms.ComboBox();
            this.rBSingleYear = new System.Windows.Forms.RadioButton();
            this.cbxGiveTerm = new System.Windows.Forms.ComboBox();
            this.cBGiveTerm = new System.Windows.Forms.CheckBox();
            this.lblCourseNameQueryText = new System.Windows.Forms.Label();
            this.cBCourseID = new System.Windows.Forms.CheckBox();
            this.lblCourseNameQuery = new System.Windows.Forms.Label();
            this.cBStuID = new System.Windows.Forms.CheckBox();
            this.cbxCourseIDQuery = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.pChooseQuery = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxStuID = new System.Windows.Forms.ComboBox();
            this.dGVChooseQuery = new System.Windows.Forms.DataGridView();
            this.sCChooseQueryMain.Panel1.SuspendLayout();
            this.sCChooseQueryMain.Panel2.SuspendLayout();
            this.sCChooseQueryMain.SuspendLayout();
            this.gBGiveYear.SuspendLayout();
            this.pChooseQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChooseQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // sCChooseQueryMain
            // 
            this.sCChooseQueryMain.BackColor = System.Drawing.Color.Transparent;
            this.sCChooseQueryMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCChooseQueryMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCChooseQueryMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCChooseQueryMain.Location = new System.Drawing.Point(0, 0);
            this.sCChooseQueryMain.Name = "sCChooseQueryMain";
            this.sCChooseQueryMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCChooseQueryMain.Panel1
            // 
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cBInputGrade);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cBGiveYear);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.gBGiveYear);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cbxGiveTerm);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cBGiveTerm);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.lblCourseNameQueryText);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cBCourseID);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.lblCourseNameQuery);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cBStuID);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cbxCourseIDQuery);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.lblName);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.lblStuName);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.pChooseQuery);
            this.sCChooseQueryMain.Panel1.Controls.Add(this.cbxStuID);
            // 
            // sCChooseQueryMain.Panel2
            // 
            this.sCChooseQueryMain.Panel2.Controls.Add(this.dGVChooseQuery);
            this.sCChooseQueryMain.Size = new System.Drawing.Size(889, 436);
            this.sCChooseQueryMain.SplitterDistance = 229;
            this.sCChooseQueryMain.TabIndex = 0;
            // 
            // cBInputGrade
            // 
            this.cBInputGrade.AutoSize = true;
            this.cBInputGrade.Location = new System.Drawing.Point(585, 86);
            this.cBInputGrade.Name = "cBInputGrade";
            this.cBInputGrade.Size = new System.Drawing.Size(82, 18);
            this.cBInputGrade.TabIndex = 51;
            this.cBInputGrade.Text = "录入成绩";
            this.cBInputGrade.UseVisualStyleBackColor = true;
            this.cBInputGrade.CheckStateChanged += new System.EventHandler(this.cBInputGrade_CheckStateChanged);
            // 
            // cBGiveYear
            // 
            this.cBGiveYear.AutoSize = true;
            this.cBGiveYear.Location = new System.Drawing.Point(18, 125);
            this.cBGiveYear.Name = "cBGiveYear";
            this.cBGiveYear.Size = new System.Drawing.Size(82, 18);
            this.cBGiveYear.TabIndex = 50;
            this.cBGiveYear.Text = "授课年份";
            this.cBGiveYear.UseVisualStyleBackColor = true;
            this.cBGiveYear.CheckStateChanged += new System.EventHandler(this.cBGiveYear_CheckStateChanged);
            // 
            // gBGiveYear
            // 
            this.gBGiveYear.Controls.Add(this.lblYearOutEnd);
            this.gBGiveYear.Controls.Add(this.lblYearOutBegin);
            this.gBGiveYear.Controls.Add(this.lblYearInEnd);
            this.gBGiveYear.Controls.Add(this.lblYearInBegin);
            this.gBGiveYear.Controls.Add(this.dTPYearOutEnd);
            this.gBGiveYear.Controls.Add(this.dTPYearOutBegin);
            this.gBGiveYear.Controls.Add(this.rBYearOut);
            this.gBGiveYear.Controls.Add(this.dTPYearInEnd);
            this.gBGiveYear.Controls.Add(this.dTPYearInBegin);
            this.gBGiveYear.Controls.Add(this.rBYearIn);
            this.gBGiveYear.Controls.Add(this.dTPGivenYearSingle);
            this.gBGiveYear.Controls.Add(this.cbxSignYear);
            this.gBGiveYear.Controls.Add(this.rBSingleYear);
            this.gBGiveYear.Location = new System.Drawing.Point(118, 114);
            this.gBGiveYear.Name = "gBGiveYear";
            this.gBGiveYear.Size = new System.Drawing.Size(652, 71);
            this.gBGiveYear.TabIndex = 49;
            this.gBGiveYear.TabStop = false;
            // 
            // lblYearOutEnd
            // 
            this.lblYearOutEnd.AutoSize = true;
            this.lblYearOutEnd.Location = new System.Drawing.Point(526, 46);
            this.lblYearOutEnd.Name = "lblYearOutEnd";
            this.lblYearOutEnd.Size = new System.Drawing.Size(35, 14);
            this.lblYearOutEnd.TabIndex = 47;
            this.lblYearOutEnd.Text = "或>=";
            // 
            // lblYearOutBegin
            // 
            this.lblYearOutBegin.AutoSize = true;
            this.lblYearOutBegin.Location = new System.Drawing.Point(371, 46);
            this.lblYearOutBegin.Name = "lblYearOutBegin";
            this.lblYearOutBegin.Size = new System.Drawing.Size(21, 14);
            this.lblYearOutBegin.TabIndex = 46;
            this.lblYearOutBegin.Text = "<=";
            // 
            // lblYearInEnd
            // 
            this.lblYearInEnd.AutoSize = true;
            this.lblYearInEnd.Location = new System.Drawing.Point(526, 20);
            this.lblYearInEnd.Name = "lblYearInEnd";
            this.lblYearInEnd.Size = new System.Drawing.Size(35, 14);
            this.lblYearInEnd.TabIndex = 45;
            this.lblYearInEnd.Text = "且<=";
            // 
            // lblYearInBegin
            // 
            this.lblYearInBegin.AutoSize = true;
            this.lblYearInBegin.Location = new System.Drawing.Point(371, 20);
            this.lblYearInBegin.Name = "lblYearInBegin";
            this.lblYearInBegin.Size = new System.Drawing.Size(21, 14);
            this.lblYearInBegin.TabIndex = 44;
            this.lblYearInBegin.Text = ">=";
            // 
            // dTPYearOutEnd
            // 
            this.dTPYearOutEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPYearOutEnd.CustomFormat = "yyyy";
            this.dTPYearOutEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPYearOutEnd.Location = new System.Drawing.Point(567, 42);
            this.dTPYearOutEnd.Name = "dTPYearOutEnd";
            this.dTPYearOutEnd.ShowUpDown = true;
            this.dTPYearOutEnd.Size = new System.Drawing.Size(64, 23);
            this.dTPYearOutEnd.TabIndex = 43;
            // 
            // dTPYearOutBegin
            // 
            this.dTPYearOutBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPYearOutBegin.CustomFormat = "yyyy";
            this.dTPYearOutBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPYearOutBegin.Location = new System.Drawing.Point(404, 42);
            this.dTPYearOutBegin.Name = "dTPYearOutBegin";
            this.dTPYearOutBegin.ShowUpDown = true;
            this.dTPYearOutBegin.Size = new System.Drawing.Size(61, 23);
            this.dTPYearOutBegin.TabIndex = 42;
            // 
            // rBYearOut
            // 
            this.rBYearOut.AutoSize = true;
            this.rBYearOut.Location = new System.Drawing.Point(274, 44);
            this.rBYearOut.Name = "rBYearOut";
            this.rBYearOut.Size = new System.Drawing.Size(81, 18);
            this.rBYearOut.TabIndex = 41;
            this.rBYearOut.Text = "多重条件";
            this.rBYearOut.UseVisualStyleBackColor = true;
            this.rBYearOut.CheckedChanged += new System.EventHandler(this.rBYearOut_CheckedChanged);
            // 
            // dTPYearInEnd
            // 
            this.dTPYearInEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPYearInEnd.CustomFormat = "yyyy";
            this.dTPYearInEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPYearInEnd.Location = new System.Drawing.Point(567, 16);
            this.dTPYearInEnd.Name = "dTPYearInEnd";
            this.dTPYearInEnd.ShowUpDown = true;
            this.dTPYearInEnd.Size = new System.Drawing.Size(64, 23);
            this.dTPYearInEnd.TabIndex = 40;
            // 
            // dTPYearInBegin
            // 
            this.dTPYearInBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPYearInBegin.CustomFormat = "yyyy";
            this.dTPYearInBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPYearInBegin.Location = new System.Drawing.Point(404, 16);
            this.dTPYearInBegin.Name = "dTPYearInBegin";
            this.dTPYearInBegin.ShowUpDown = true;
            this.dTPYearInBegin.Size = new System.Drawing.Size(61, 23);
            this.dTPYearInBegin.TabIndex = 39;
            // 
            // rBYearIn
            // 
            this.rBYearIn.AutoSize = true;
            this.rBYearIn.Location = new System.Drawing.Point(274, 18);
            this.rBYearIn.Name = "rBYearIn";
            this.rBYearIn.Size = new System.Drawing.Size(81, 18);
            this.rBYearIn.TabIndex = 37;
            this.rBYearIn.Text = "区间条件";
            this.rBYearIn.UseVisualStyleBackColor = true;
            this.rBYearIn.CheckedChanged += new System.EventHandler(this.rBYearIn_CheckedChanged);
            // 
            // dTPGivenYearSingle
            // 
            this.dTPGivenYearSingle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPGivenYearSingle.CustomFormat = "yyyy";
            this.dTPGivenYearSingle.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPGivenYearSingle.Location = new System.Drawing.Point(140, 16);
            this.dTPGivenYearSingle.Name = "dTPGivenYearSingle";
            this.dTPGivenYearSingle.ShowUpDown = true;
            this.dTPGivenYearSingle.Size = new System.Drawing.Size(61, 23);
            this.dTPGivenYearSingle.TabIndex = 36;
            // 
            // cbxSignYear
            // 
            this.cbxSignYear.FormattingEnabled = true;
            this.cbxSignYear.Items.AddRange(new object[] {
            ">=",
            "<=",
            "="});
            this.cbxSignYear.Location = new System.Drawing.Point(84, 17);
            this.cbxSignYear.Name = "cbxSignYear";
            this.cbxSignYear.Size = new System.Drawing.Size(47, 21);
            this.cbxSignYear.TabIndex = 1;
            // 
            // rBSingleYear
            // 
            this.rBSingleYear.AutoSize = true;
            this.rBSingleYear.Checked = true;
            this.rBSingleYear.Location = new System.Drawing.Point(11, 18);
            this.rBSingleYear.Name = "rBSingleYear";
            this.rBSingleYear.Size = new System.Drawing.Size(67, 18);
            this.rBSingleYear.TabIndex = 0;
            this.rBSingleYear.TabStop = true;
            this.rBSingleYear.Text = "单条件";
            this.rBSingleYear.UseVisualStyleBackColor = true;
            this.rBSingleYear.CheckedChanged += new System.EventHandler(this.rBSingleYear_CheckedChanged);
            // 
            // cbxGiveTerm
            // 
            this.cbxGiveTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGiveTerm.FormattingEnabled = true;
            this.cbxGiveTerm.Items.AddRange(new object[] {
            "春期",
            "秋期"});
            this.cbxGiveTerm.Location = new System.Drawing.Point(118, 193);
            this.cbxGiveTerm.Name = "cbxGiveTerm";
            this.cbxGiveTerm.Size = new System.Drawing.Size(160, 21);
            this.cbxGiveTerm.TabIndex = 48;
            // 
            // cBGiveTerm
            // 
            this.cBGiveTerm.AutoSize = true;
            this.cBGiveTerm.Location = new System.Drawing.Point(18, 194);
            this.cBGiveTerm.Name = "cBGiveTerm";
            this.cBGiveTerm.Size = new System.Drawing.Size(82, 18);
            this.cBGiveTerm.TabIndex = 47;
            this.cBGiveTerm.Text = "授课学期";
            this.cBGiveTerm.UseVisualStyleBackColor = true;
            this.cBGiveTerm.CheckStateChanged += new System.EventHandler(this.cBGiveTerm_CheckStateChanged);
            // 
            // lblCourseNameQueryText
            // 
            this.lblCourseNameQueryText.AutoSize = true;
            this.lblCourseNameQueryText.Location = new System.Drawing.Point(393, 88);
            this.lblCourseNameQueryText.Name = "lblCourseNameQueryText";
            this.lblCourseNameQueryText.Size = new System.Drawing.Size(35, 14);
            this.lblCourseNameQueryText.TabIndex = 46;
            this.lblCourseNameQueryText.Text = "****";
            // 
            // cBCourseID
            // 
            this.cBCourseID.AutoSize = true;
            this.cBCourseID.Location = new System.Drawing.Point(18, 86);
            this.cBCourseID.Name = "cBCourseID";
            this.cBCourseID.Size = new System.Drawing.Size(96, 18);
            this.cBCourseID.TabIndex = 16;
            this.cBCourseID.Text = "课程编号：";
            this.cBCourseID.UseVisualStyleBackColor = true;
            this.cBCourseID.CheckStateChanged += new System.EventHandler(this.cBCourseID_CheckStateChanged);
            // 
            // lblCourseNameQuery
            // 
            this.lblCourseNameQuery.AutoSize = true;
            this.lblCourseNameQuery.Location = new System.Drawing.Point(305, 88);
            this.lblCourseNameQuery.Name = "lblCourseNameQuery";
            this.lblCourseNameQuery.Size = new System.Drawing.Size(77, 14);
            this.lblCourseNameQuery.TabIndex = 45;
            this.lblCourseNameQuery.Text = "课程名称：";
            // 
            // cBStuID
            // 
            this.cBStuID.AutoSize = true;
            this.cBStuID.Location = new System.Drawing.Point(18, 56);
            this.cBStuID.Name = "cBStuID";
            this.cBStuID.Size = new System.Drawing.Size(96, 18);
            this.cBStuID.TabIndex = 15;
            this.cBStuID.Text = "学    号：";
            this.cBStuID.UseVisualStyleBackColor = true;
            this.cBStuID.CheckStateChanged += new System.EventHandler(this.cBStuID_CheckStateChanged);
            // 
            // cbxCourseIDQuery
            // 
            this.cbxCourseIDQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourseIDQuery.FormattingEnabled = true;
            this.cbxCourseIDQuery.Location = new System.Drawing.Point(118, 85);
            this.cbxCourseIDQuery.Name = "cbxCourseIDQuery";
            this.cbxCourseIDQuery.Size = new System.Drawing.Size(160, 21);
            this.cbxCourseIDQuery.TabIndex = 44;
            this.cbxCourseIDQuery.SelectedIndexChanged += new System.EventHandler(this.cbxCourseIDQuery_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(305, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 14);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "姓    名：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(393, 58);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(35, 14);
            this.lblStuName.TabIndex = 40;
            this.lblStuName.Text = "****";
            // 
            // pChooseQuery
            // 
            this.pChooseQuery.Controls.Add(this.btnReset);
            this.pChooseQuery.Controls.Add(this.btnQuery);
            this.pChooseQuery.Controls.Add(this.btnUpdate);
            this.pChooseQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pChooseQuery.Location = new System.Drawing.Point(0, 0);
            this.pChooseQuery.Name = "pChooseQuery";
            this.pChooseQuery.Size = new System.Drawing.Size(885, 43);
            this.pChooseQuery.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(56, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.Location = new System.Drawing.Point(16, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(40, 40);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(96, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxStuID
            // 
            this.cbxStuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStuID.FormattingEnabled = true;
            this.cbxStuID.Location = new System.Drawing.Point(118, 55);
            this.cbxStuID.Name = "cbxStuID";
            this.cbxStuID.Size = new System.Drawing.Size(160, 21);
            this.cbxStuID.TabIndex = 14;
            this.cbxStuID.SelectedIndexChanged += new System.EventHandler(this.cbxStuID_SelectedIndexChanged);
            // 
            // dGVChooseQuery
            // 
            this.dGVChooseQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVChooseQuery.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVChooseQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVChooseQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChooseQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVChooseQuery.Location = new System.Drawing.Point(0, 0);
            this.dGVChooseQuery.Name = "dGVChooseQuery";
            this.dGVChooseQuery.RowTemplate.Height = 23;
            this.dGVChooseQuery.Size = new System.Drawing.Size(885, 199);
            this.dGVChooseQuery.TabIndex = 0;
            // 
            // FormChooseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 436);
            this.Controls.Add(this.sCChooseQueryMain);
            this.Name = "FormChooseQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课信息查询";
            this.Load += new System.EventHandler(this.FormChooseQuery_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormChooseQuery_Layout);
            this.sCChooseQueryMain.Panel1.ResumeLayout(false);
            this.sCChooseQueryMain.Panel1.PerformLayout();
            this.sCChooseQueryMain.Panel2.ResumeLayout(false);
            this.sCChooseQueryMain.ResumeLayout(false);
            this.gBGiveYear.ResumeLayout(false);
            this.gBGiveYear.PerformLayout();
            this.pChooseQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVChooseQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sCChooseQueryMain;
        private System.Windows.Forms.DataGridView dGVChooseQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.ComboBox cbxStuID;
        private System.Windows.Forms.Label lblCourseNameQueryText;
        private System.Windows.Forms.Label lblCourseNameQuery;
        private System.Windows.Forms.ComboBox cbxCourseIDQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pChooseQuery;
        private System.Windows.Forms.CheckBox cBCourseID;
        private System.Windows.Forms.CheckBox cBStuID;
        private System.Windows.Forms.ComboBox cbxGiveTerm;
        private System.Windows.Forms.CheckBox cBGiveTerm;
        private System.Windows.Forms.CheckBox cBGiveYear;
        private System.Windows.Forms.GroupBox gBGiveYear;
        private System.Windows.Forms.Label lblYearOutEnd;
        private System.Windows.Forms.Label lblYearOutBegin;
        private System.Windows.Forms.Label lblYearInEnd;
        private System.Windows.Forms.Label lblYearInBegin;
        private System.Windows.Forms.DateTimePicker dTPYearOutEnd;
        private System.Windows.Forms.DateTimePicker dTPYearOutBegin;
        private System.Windows.Forms.RadioButton rBYearOut;
        private System.Windows.Forms.DateTimePicker dTPYearInEnd;
        private System.Windows.Forms.DateTimePicker dTPYearInBegin;
        private System.Windows.Forms.RadioButton rBYearIn;
        private System.Windows.Forms.DateTimePicker dTPGivenYearSingle;
        private System.Windows.Forms.ComboBox cbxSignYear;
        private System.Windows.Forms.RadioButton rBSingleYear;
        private System.Windows.Forms.CheckBox cBInputGrade;
        private System.Windows.Forms.Button btnReset;

    }
}