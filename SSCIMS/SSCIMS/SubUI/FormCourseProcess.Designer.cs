namespace SSCIMS
{
    partial class FormCourseProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCourseProcess));
            this.sCCourseProcessMain = new System.Windows.Forms.SplitContainer();
            this.gBCourseProcessLeftTop = new System.Windows.Forms.GroupBox();
            this.lblCreditNotice = new System.Windows.Forms.Label();
            this.lblTeacherNotice = new System.Windows.Forms.Label();
            this.lblPeriodsNotice = new System.Windows.Forms.Label();
            this.lblGiveTermNotice = new System.Windows.Forms.Label();
            this.dTPGivenYear = new System.Windows.Forms.DateTimePicker();
            this.lblCourseNameNotice = new System.Windows.Forms.Label();
            this.lblCourseIDNotice = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.lblPeriods = new System.Windows.Forms.Label();
            this.cbxGiveTerm = new System.Windows.Forms.ComboBox();
            this.lblGiveTerm = new System.Windows.Forms.Label();
            this.lblGiveYear = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dGVCourseProcess = new System.Windows.Forms.DataGridView();
            this.panelCourseProcess = new System.Windows.Forms.Panel();
            this.sCCourseProcessMain.Panel1.SuspendLayout();
            this.sCCourseProcessMain.Panel2.SuspendLayout();
            this.sCCourseProcessMain.SuspendLayout();
            this.gBCourseProcessLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCourseProcess)).BeginInit();
            this.panelCourseProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // sCCourseProcessMain
            // 
            this.sCCourseProcessMain.BackColor = System.Drawing.Color.Transparent;
            this.sCCourseProcessMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCCourseProcessMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCCourseProcessMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCCourseProcessMain.Location = new System.Drawing.Point(0, 0);
            this.sCCourseProcessMain.Name = "sCCourseProcessMain";
            this.sCCourseProcessMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCCourseProcessMain.Panel1
            // 
            this.sCCourseProcessMain.Panel1.Controls.Add(this.gBCourseProcessLeftTop);
            this.sCCourseProcessMain.Panel1.Controls.Add(this.panelCourseProcess);
            // 
            // sCCourseProcessMain.Panel2
            // 
            this.sCCourseProcessMain.Panel2.Controls.Add(this.dGVCourseProcess);
            this.sCCourseProcessMain.Size = new System.Drawing.Size(838, 466);
            this.sCCourseProcessMain.SplitterDistance = 277;
            this.sCCourseProcessMain.TabIndex = 0;
            // 
            // gBCourseProcessLeftTop
            // 
            this.gBCourseProcessLeftTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gBCourseProcessLeftTop.Controls.Add(this.lblCreditNotice);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblTeacherNotice);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblPeriodsNotice);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblGiveTermNotice);
            this.gBCourseProcessLeftTop.Controls.Add(this.dTPGivenYear);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblCourseNameNotice);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblCourseIDNotice);
            this.gBCourseProcessLeftTop.Controls.Add(this.txtCredit);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblCredit);
            this.gBCourseProcessLeftTop.Controls.Add(this.txtTeacher);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblTeacher);
            this.gBCourseProcessLeftTop.Controls.Add(this.txtPeriods);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblPeriods);
            this.gBCourseProcessLeftTop.Controls.Add(this.cbxGiveTerm);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblGiveTerm);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblGiveYear);
            this.gBCourseProcessLeftTop.Controls.Add(this.txtCourseName);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblCourseName);
            this.gBCourseProcessLeftTop.Controls.Add(this.txtCourseID);
            this.gBCourseProcessLeftTop.Controls.Add(this.lblCourseID);
            this.gBCourseProcessLeftTop.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBCourseProcessLeftTop.Location = new System.Drawing.Point(10, 51);
            this.gBCourseProcessLeftTop.Name = "gBCourseProcessLeftTop";
            this.gBCourseProcessLeftTop.Size = new System.Drawing.Size(814, 214);
            this.gBCourseProcessLeftTop.TabIndex = 1;
            this.gBCourseProcessLeftTop.TabStop = false;
            this.gBCourseProcessLeftTop.Text = "请输入课程信息";
            // 
            // lblCreditNotice
            // 
            this.lblCreditNotice.AutoSize = true;
            this.lblCreditNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditNotice.ForeColor = System.Drawing.Color.Red;
            this.lblCreditNotice.Location = new System.Drawing.Point(295, 183);
            this.lblCreditNotice.Name = "lblCreditNotice";
            this.lblCreditNotice.Size = new System.Drawing.Size(98, 14);
            this.lblCreditNotice.TabIndex = 39;
            this.lblCreditNotice.Text = "(只能1位小数)";
            // 
            // lblTeacherNotice
            // 
            this.lblTeacherNotice.AutoSize = true;
            this.lblTeacherNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherNotice.ForeColor = System.Drawing.Color.Red;
            this.lblTeacherNotice.Location = new System.Drawing.Point(295, 157);
            this.lblTeacherNotice.Name = "lblTeacherNotice";
            this.lblTeacherNotice.Size = new System.Drawing.Size(70, 14);
            this.lblTeacherNotice.TabIndex = 38;
            this.lblTeacherNotice.Text = "(8个字符)";
            // 
            // lblPeriodsNotice
            // 
            this.lblPeriodsNotice.AutoSize = true;
            this.lblPeriodsNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodsNotice.ForeColor = System.Drawing.Color.Red;
            this.lblPeriodsNotice.Location = new System.Drawing.Point(295, 131);
            this.lblPeriodsNotice.Name = "lblPeriodsNotice";
            this.lblPeriodsNotice.Size = new System.Drawing.Size(70, 14);
            this.lblPeriodsNotice.TabIndex = 37;
            this.lblPeriodsNotice.Text = "(4位整数)";
            // 
            // lblGiveTermNotice
            // 
            this.lblGiveTermNotice.AutoSize = true;
            this.lblGiveTermNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblGiveTermNotice.ForeColor = System.Drawing.Color.Red;
            this.lblGiveTermNotice.Location = new System.Drawing.Point(295, 105);
            this.lblGiveTermNotice.Name = "lblGiveTermNotice";
            this.lblGiveTermNotice.Size = new System.Drawing.Size(56, 14);
            this.lblGiveTermNotice.TabIndex = 36;
            this.lblGiveTermNotice.Text = "*(必选)";
            // 
            // dTPGivenYear
            // 
            this.dTPGivenYear.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPGivenYear.CustomFormat = "yyyy";
            this.dTPGivenYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPGivenYear.Location = new System.Drawing.Point(115, 75);
            this.dTPGivenYear.Name = "dTPGivenYear";
            this.dTPGivenYear.ShowUpDown = true;
            this.dTPGivenYear.Size = new System.Drawing.Size(160, 23);
            this.dTPGivenYear.TabIndex = 35;
            // 
            // lblCourseNameNotice
            // 
            this.lblCourseNameNotice.AutoSize = true;
            this.lblCourseNameNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseNameNotice.ForeColor = System.Drawing.Color.Red;
            this.lblCourseNameNotice.Location = new System.Drawing.Point(295, 53);
            this.lblCourseNameNotice.Name = "lblCourseNameNotice";
            this.lblCourseNameNotice.Size = new System.Drawing.Size(77, 14);
            this.lblCourseNameNotice.TabIndex = 34;
            this.lblCourseNameNotice.Text = "(20个字符)";
            // 
            // lblCourseIDNotice
            // 
            this.lblCourseIDNotice.AutoSize = true;
            this.lblCourseIDNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseIDNotice.ForeColor = System.Drawing.Color.Red;
            this.lblCourseIDNotice.Location = new System.Drawing.Point(295, 27);
            this.lblCourseIDNotice.Name = "lblCourseIDNotice";
            this.lblCourseIDNotice.Size = new System.Drawing.Size(112, 14);
            this.lblCourseIDNotice.TabIndex = 33;
            this.lblCourseIDNotice.Text = "*(必填,4位数字)";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(115, 179);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(160, 23);
            this.txtCredit.TabIndex = 32;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(25, 183);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(70, 14);
            this.lblCredit.TabIndex = 31;
            this.lblCredit.Text = "课程学分:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(115, 153);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(160, 23);
            this.txtTeacher.TabIndex = 30;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(25, 157);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(70, 14);
            this.lblTeacher.TabIndex = 29;
            this.lblTeacher.Text = "任课教师:";
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(115, 127);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(160, 23);
            this.txtPeriods.TabIndex = 28;
            // 
            // lblPeriods
            // 
            this.lblPeriods.AutoSize = true;
            this.lblPeriods.Location = new System.Drawing.Point(25, 131);
            this.lblPeriods.Name = "lblPeriods";
            this.lblPeriods.Size = new System.Drawing.Size(70, 14);
            this.lblPeriods.TabIndex = 27;
            this.lblPeriods.Text = "讲授学时:";
            // 
            // cbxGiveTerm
            // 
            this.cbxGiveTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGiveTerm.FormattingEnabled = true;
            this.cbxGiveTerm.Items.AddRange(new object[] {
            "春期",
            "秋期"});
            this.cbxGiveTerm.Location = new System.Drawing.Point(115, 102);
            this.cbxGiveTerm.Name = "cbxGiveTerm";
            this.cbxGiveTerm.Size = new System.Drawing.Size(160, 21);
            this.cbxGiveTerm.TabIndex = 26;
            // 
            // lblGiveTerm
            // 
            this.lblGiveTerm.AutoSize = true;
            this.lblGiveTerm.Location = new System.Drawing.Point(25, 105);
            this.lblGiveTerm.Name = "lblGiveTerm";
            this.lblGiveTerm.Size = new System.Drawing.Size(70, 14);
            this.lblGiveTerm.TabIndex = 25;
            this.lblGiveTerm.Text = "授课学期:";
            // 
            // lblGiveYear
            // 
            this.lblGiveYear.AutoSize = true;
            this.lblGiveYear.Location = new System.Drawing.Point(25, 79);
            this.lblGiveYear.Name = "lblGiveYear";
            this.lblGiveYear.Size = new System.Drawing.Size(70, 14);
            this.lblGiveYear.TabIndex = 23;
            this.lblGiveYear.Text = "授课年份:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(115, 49);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(160, 23);
            this.txtCourseName.TabIndex = 22;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(25, 53);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(70, 14);
            this.lblCourseName.TabIndex = 21;
            this.lblCourseName.Text = "课程名称:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(115, 23);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(160, 23);
            this.txtCourseID.TabIndex = 20;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(25, 27);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(70, 14);
            this.lblCourseID.TabIndex = 19;
            this.lblCourseID.Text = "课程编号:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(699, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 45);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "刷新";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsert.Location = new System.Drawing.Point(654, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(45, 45);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdate.Location = new System.Drawing.Point(789, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(45, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(744, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dGVCourseProcess
            // 
            this.dGVCourseProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVCourseProcess.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVCourseProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVCourseProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCourseProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVCourseProcess.Location = new System.Drawing.Point(0, 0);
            this.dGVCourseProcess.Name = "dGVCourseProcess";
            this.dGVCourseProcess.RowTemplate.Height = 23;
            this.dGVCourseProcess.Size = new System.Drawing.Size(834, 181);
            this.dGVCourseProcess.TabIndex = 0;
            this.dGVCourseProcess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dGVCourseProcess_MouseClick);
            // 
            // panelCourseProcess
            // 
            this.panelCourseProcess.Controls.Add(this.btnInsert);
            this.panelCourseProcess.Controls.Add(this.btnClear);
            this.panelCourseProcess.Controls.Add(this.btnDelete);
            this.panelCourseProcess.Controls.Add(this.btnUpdate);
            this.panelCourseProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCourseProcess.Location = new System.Drawing.Point(0, 0);
            this.panelCourseProcess.Name = "panelCourseProcess";
            this.panelCourseProcess.Size = new System.Drawing.Size(834, 45);
            this.panelCourseProcess.TabIndex = 0;
            // 
            // FormCourseProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 466);
            this.Controls.Add(this.sCCourseProcessMain);
            this.Name = "FormCourseProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息处理";
            this.Load += new System.EventHandler(this.FormCourseProcess_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormCourseProcess_Layout);
            this.sCCourseProcessMain.Panel1.ResumeLayout(false);
            this.sCCourseProcessMain.Panel2.ResumeLayout(false);
            this.sCCourseProcessMain.ResumeLayout(false);
            this.gBCourseProcessLeftTop.ResumeLayout(false);
            this.gBCourseProcessLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCourseProcess)).EndInit();
            this.panelCourseProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCourseProcess;
        protected internal System.Windows.Forms.Button btnClear;
        protected internal System.Windows.Forms.Button btnDelete;
        protected internal System.Windows.Forms.Button btnUpdate;
        protected internal System.Windows.Forms.Button btnInsert;
        protected internal System.Windows.Forms.SplitContainer sCCourseProcessMain;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.Label lblPeriods;
        private System.Windows.Forms.ComboBox cbxGiveTerm;
        private System.Windows.Forms.Label lblGiveTerm;
        private System.Windows.Forms.Label lblGiveYear;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseID;
        protected internal System.Windows.Forms.GroupBox gBCourseProcessLeftTop;
        private System.Windows.Forms.Label lblCourseIDNotice;
        private System.Windows.Forms.DateTimePicker dTPGivenYear;
        private System.Windows.Forms.Label lblCourseNameNotice;
        private System.Windows.Forms.Label lblCreditNotice;
        private System.Windows.Forms.Label lblTeacherNotice;
        private System.Windows.Forms.Label lblPeriodsNotice;
        private System.Windows.Forms.Label lblGiveTermNotice;
        private System.Windows.Forms.Panel panelCourseProcess;

    }
}