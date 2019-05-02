namespace SSCIMS
{
    partial class FormChooseProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChooseProcess));
            this.sCChooseProcessMain = new System.Windows.Forms.SplitContainer();
            this.gBChooseProcess = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxGiveYear = new System.Windows.Forms.ComboBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.cbxGiveTerm = new System.Windows.Forms.ComboBox();
            this.lblGiveTerm = new System.Windows.Forms.Label();
            this.lblGiveYear = new System.Windows.Forms.Label();
            this.cbxStuID = new System.Windows.Forms.ComboBox();
            this.lblStuID = new System.Windows.Forms.Label();
            this.panelChooseProcessTop = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChooseAllChoose = new System.Windows.Forms.Button();
            this.btnCourseAllCancel = new System.Windows.Forms.Button();
            this.btnChooseAllCancel = new System.Windows.Forms.Button();
            this.btnCourseAllChoose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.sCChooseProcessBottom = new System.Windows.Forms.SplitContainer();
            this.dGVChooseProcessLeft = new System.Windows.Forms.DataGridView();
            this.dGVChooseProcessRight = new System.Windows.Forms.DataGridView();
            this.sCChooseProcessMain.Panel1.SuspendLayout();
            this.sCChooseProcessMain.Panel2.SuspendLayout();
            this.sCChooseProcessMain.SuspendLayout();
            this.gBChooseProcess.SuspendLayout();
            this.panelChooseProcessTop.SuspendLayout();
            this.sCChooseProcessBottom.Panel1.SuspendLayout();
            this.sCChooseProcessBottom.Panel2.SuspendLayout();
            this.sCChooseProcessBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChooseProcessLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChooseProcessRight)).BeginInit();
            this.SuspendLayout();
            // 
            // sCChooseProcessMain
            // 
            this.sCChooseProcessMain.BackColor = System.Drawing.Color.Transparent;
            this.sCChooseProcessMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCChooseProcessMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCChooseProcessMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCChooseProcessMain.Location = new System.Drawing.Point(0, 0);
            this.sCChooseProcessMain.Name = "sCChooseProcessMain";
            this.sCChooseProcessMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCChooseProcessMain.Panel1
            // 
            this.sCChooseProcessMain.Panel1.Controls.Add(this.gBChooseProcess);
            this.sCChooseProcessMain.Panel1.Controls.Add(this.panelChooseProcessTop);
            // 
            // sCChooseProcessMain.Panel2
            // 
            this.sCChooseProcessMain.Panel2.Controls.Add(this.sCChooseProcessBottom);
            this.sCChooseProcessMain.Size = new System.Drawing.Size(783, 429);
            this.sCChooseProcessMain.SplitterDistance = 156;
            this.sCChooseProcessMain.TabIndex = 0;
            // 
            // gBChooseProcess
            // 
            this.gBChooseProcess.Controls.Add(this.lblName);
            this.gBChooseProcess.Controls.Add(this.cbxGiveYear);
            this.gBChooseProcess.Controls.Add(this.lblStuName);
            this.gBChooseProcess.Controls.Add(this.cbxGiveTerm);
            this.gBChooseProcess.Controls.Add(this.lblGiveTerm);
            this.gBChooseProcess.Controls.Add(this.lblGiveYear);
            this.gBChooseProcess.Controls.Add(this.cbxStuID);
            this.gBChooseProcess.Controls.Add(this.lblStuID);
            this.gBChooseProcess.Location = new System.Drawing.Point(5, 47);
            this.gBChooseProcess.Name = "gBChooseProcess";
            this.gBChooseProcess.Size = new System.Drawing.Size(769, 100);
            this.gBChooseProcess.TabIndex = 0;
            this.gBChooseProcess.TabStop = false;
            this.gBChooseProcess.Text = "请设置选课条件";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(281, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 14);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "姓    名：";
            // 
            // cbxGiveYear
            // 
            this.cbxGiveYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGiveYear.FormattingEnabled = true;
            this.cbxGiveYear.Location = new System.Drawing.Point(114, 52);
            this.cbxGiveYear.Name = "cbxGiveYear";
            this.cbxGiveYear.Size = new System.Drawing.Size(160, 21);
            this.cbxGiveYear.TabIndex = 41;
            this.cbxGiveYear.SelectedIndexChanged += new System.EventHandler(this.cbxGiveYear_SelectedIndexChanged);
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(366, 29);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(35, 14);
            this.lblStuName.TabIndex = 40;
            this.lblStuName.Text = "****";
            // 
            // cbxGiveTerm
            // 
            this.cbxGiveTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGiveTerm.FormattingEnabled = true;
            this.cbxGiveTerm.Items.AddRange(new object[] {
            "春期",
            "秋期"});
            this.cbxGiveTerm.Location = new System.Drawing.Point(114, 79);
            this.cbxGiveTerm.Name = "cbxGiveTerm";
            this.cbxGiveTerm.Size = new System.Drawing.Size(160, 21);
            this.cbxGiveTerm.TabIndex = 38;
            this.cbxGiveTerm.SelectedIndexChanged += new System.EventHandler(this.cbxGiveTerm_SelectedIndexChanged);
            // 
            // lblGiveTerm
            // 
            this.lblGiveTerm.AutoSize = true;
            this.lblGiveTerm.Location = new System.Drawing.Point(24, 82);
            this.lblGiveTerm.Name = "lblGiveTerm";
            this.lblGiveTerm.Size = new System.Drawing.Size(70, 14);
            this.lblGiveTerm.TabIndex = 37;
            this.lblGiveTerm.Text = "授课学期:";
            // 
            // lblGiveYear
            // 
            this.lblGiveYear.AutoSize = true;
            this.lblGiveYear.Location = new System.Drawing.Point(24, 55);
            this.lblGiveYear.Name = "lblGiveYear";
            this.lblGiveYear.Size = new System.Drawing.Size(70, 14);
            this.lblGiveYear.TabIndex = 36;
            this.lblGiveYear.Text = "授课年份:";
            // 
            // cbxStuID
            // 
            this.cbxStuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStuID.FormattingEnabled = true;
            this.cbxStuID.Location = new System.Drawing.Point(114, 26);
            this.cbxStuID.Name = "cbxStuID";
            this.cbxStuID.Size = new System.Drawing.Size(160, 21);
            this.cbxStuID.TabIndex = 14;
            this.cbxStuID.SelectedIndexChanged += new System.EventHandler(this.cbxStuID_SelectedIndexChanged);
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(24, 28);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(77, 14);
            this.lblStuID.TabIndex = 13;
            this.lblStuID.Text = "学    号：";
            // 
            // panelChooseProcessTop
            // 
            this.panelChooseProcessTop.Controls.Add(this.btnClear);
            this.panelChooseProcessTop.Controls.Add(this.btnChooseAllChoose);
            this.panelChooseProcessTop.Controls.Add(this.btnCourseAllCancel);
            this.panelChooseProcessTop.Controls.Add(this.btnChooseAllCancel);
            this.panelChooseProcessTop.Controls.Add(this.btnCourseAllChoose);
            this.panelChooseProcessTop.Controls.Add(this.btnDelete);
            this.panelChooseProcessTop.Controls.Add(this.btnInsert);
            this.panelChooseProcessTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChooseProcessTop.Location = new System.Drawing.Point(0, 0);
            this.panelChooseProcessTop.Name = "panelChooseProcessTop";
            this.panelChooseProcessTop.Size = new System.Drawing.Size(779, 45);
            this.panelChooseProcessTop.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.Location = new System.Drawing.Point(135, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 45);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "刷新";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChooseAllChoose
            // 
            this.btnChooseAllChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseAllChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseAllChoose.BackgroundImage")));
            this.btnChooseAllChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseAllChoose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChooseAllChoose.Location = new System.Drawing.Point(644, 0);
            this.btnChooseAllChoose.Name = "btnChooseAllChoose";
            this.btnChooseAllChoose.Size = new System.Drawing.Size(45, 45);
            this.btnChooseAllChoose.TabIndex = 13;
            this.btnChooseAllChoose.Text = "全选";
            this.btnChooseAllChoose.UseVisualStyleBackColor = false;
            this.btnChooseAllChoose.Click += new System.EventHandler(this.btnChooseAllChoose_Click);
            // 
            // btnCourseAllCancel
            // 
            this.btnCourseAllCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCourseAllCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCourseAllCancel.BackgroundImage")));
            this.btnCourseAllCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCourseAllCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCourseAllCancel.Location = new System.Drawing.Point(90, 0);
            this.btnCourseAllCancel.Name = "btnCourseAllCancel";
            this.btnCourseAllCancel.Size = new System.Drawing.Size(45, 45);
            this.btnCourseAllCancel.TabIndex = 12;
            this.btnCourseAllCancel.Text = "取消";
            this.btnCourseAllCancel.UseVisualStyleBackColor = false;
            this.btnCourseAllCancel.Click += new System.EventHandler(this.btnCourseAllCancel_Click);
            // 
            // btnChooseAllCancel
            // 
            this.btnChooseAllCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseAllCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseAllCancel.BackgroundImage")));
            this.btnChooseAllCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseAllCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChooseAllCancel.Location = new System.Drawing.Point(689, 0);
            this.btnChooseAllCancel.Name = "btnChooseAllCancel";
            this.btnChooseAllCancel.Size = new System.Drawing.Size(45, 45);
            this.btnChooseAllCancel.TabIndex = 14;
            this.btnChooseAllCancel.Text = "取消";
            this.btnChooseAllCancel.UseVisualStyleBackColor = false;
            this.btnChooseAllCancel.Click += new System.EventHandler(this.btnChooseAllCancel_Click);
            // 
            // btnCourseAllChoose
            // 
            this.btnCourseAllChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnCourseAllChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCourseAllChoose.BackgroundImage")));
            this.btnCourseAllChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCourseAllChoose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCourseAllChoose.Location = new System.Drawing.Point(45, 0);
            this.btnCourseAllChoose.Name = "btnCourseAllChoose";
            this.btnCourseAllChoose.Size = new System.Drawing.Size(45, 45);
            this.btnCourseAllChoose.TabIndex = 11;
            this.btnCourseAllChoose.Text = "全选";
            this.btnCourseAllChoose.UseVisualStyleBackColor = false;
            this.btnCourseAllChoose.Click += new System.EventHandler(this.btnCourseAllChoose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(734, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(45, 45);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "选课";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // sCChooseProcessBottom
            // 
            this.sCChooseProcessBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCChooseProcessBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCChooseProcessBottom.Location = new System.Drawing.Point(0, 0);
            this.sCChooseProcessBottom.Name = "sCChooseProcessBottom";
            // 
            // sCChooseProcessBottom.Panel1
            // 
            this.sCChooseProcessBottom.Panel1.Controls.Add(this.dGVChooseProcessLeft);
            // 
            // sCChooseProcessBottom.Panel2
            // 
            this.sCChooseProcessBottom.Panel2.Controls.Add(this.dGVChooseProcessRight);
            this.sCChooseProcessBottom.Size = new System.Drawing.Size(783, 269);
            this.sCChooseProcessBottom.SplitterDistance = 440;
            this.sCChooseProcessBottom.TabIndex = 1;
            // 
            // dGVChooseProcessLeft
            // 
            this.dGVChooseProcessLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVChooseProcessLeft.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVChooseProcessLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVChooseProcessLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChooseProcessLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVChooseProcessLeft.Location = new System.Drawing.Point(0, 0);
            this.dGVChooseProcessLeft.Name = "dGVChooseProcessLeft";
            this.dGVChooseProcessLeft.RowTemplate.Height = 23;
            this.dGVChooseProcessLeft.Size = new System.Drawing.Size(436, 265);
            this.dGVChooseProcessLeft.TabIndex = 0;
            // 
            // dGVChooseProcessRight
            // 
            this.dGVChooseProcessRight.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVChooseProcessRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChooseProcessRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVChooseProcessRight.Location = new System.Drawing.Point(0, 0);
            this.dGVChooseProcessRight.Name = "dGVChooseProcessRight";
            this.dGVChooseProcessRight.RowTemplate.Height = 23;
            this.dGVChooseProcessRight.Size = new System.Drawing.Size(335, 265);
            this.dGVChooseProcessRight.TabIndex = 0;
            // 
            // FormChooseProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 429);
            this.Controls.Add(this.sCChooseProcessMain);
            this.Name = "FormChooseProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课信息处理";
            this.Load += new System.EventHandler(this.FormChooseProcess_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormChooseProcess_Layout);
            this.sCChooseProcessMain.Panel1.ResumeLayout(false);
            this.sCChooseProcessMain.Panel2.ResumeLayout(false);
            this.sCChooseProcessMain.ResumeLayout(false);
            this.gBChooseProcess.ResumeLayout(false);
            this.gBChooseProcess.PerformLayout();
            this.panelChooseProcessTop.ResumeLayout(false);
            this.sCChooseProcessBottom.Panel1.ResumeLayout(false);
            this.sCChooseProcessBottom.Panel2.ResumeLayout(false);
            this.sCChooseProcessBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVChooseProcessLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChooseProcessRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sCChooseProcessMain;
        private System.Windows.Forms.GroupBox gBChooseProcess;
        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.ComboBox cbxStuID;
        private System.Windows.Forms.ComboBox cbxGiveTerm;
        private System.Windows.Forms.Label lblGiveTerm;
        private System.Windows.Forms.Label lblGiveYear;
        private System.Windows.Forms.Label lblStuName;
        protected internal System.Windows.Forms.Button btnClear;
        protected internal System.Windows.Forms.Button btnInsert;
        protected internal System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dGVChooseProcessLeft;
        private System.Windows.Forms.ComboBox cbxGiveYear;
        private System.Windows.Forms.SplitContainer sCChooseProcessBottom;
        private System.Windows.Forms.DataGridView dGVChooseProcessRight;
        protected internal System.Windows.Forms.Button btnCourseAllChoose;
        protected internal System.Windows.Forms.Button btnChooseAllCancel;
        protected internal System.Windows.Forms.Button btnChooseAllChoose;
        protected internal System.Windows.Forms.Button btnCourseAllCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelChooseProcessTop;
    }
}