namespace SSCIMS
{
    partial class FormStudentProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentProcess));
            this.sCStudentProcessMain = new System.Windows.Forms.SplitContainer();
            this.panelStudentProcess = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gBStudentProcess = new System.Windows.Forms.GroupBox();
            this.lblTelNotice = new System.Windows.Forms.Label();
            this.lblClassNotice = new System.Windows.Forms.Label();
            this.lblProfessionNotice = new System.Windows.Forms.Label();
            this.lblSexNotice = new System.Windows.Forms.Label();
            this.lblStuNameNotice = new System.Windows.Forms.Label();
            this.lblStuIDNotice = new System.Windows.Forms.Label();
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.dGVStudentProcess = new System.Windows.Forms.DataGridView();
            this.sCStudentProcessMain.Panel1.SuspendLayout();
            this.sCStudentProcessMain.Panel2.SuspendLayout();
            this.sCStudentProcessMain.SuspendLayout();
            this.panelStudentProcess.SuspendLayout();
            this.gBStudentProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // sCStudentProcessMain
            // 
            this.sCStudentProcessMain.BackColor = System.Drawing.Color.Transparent;
            this.sCStudentProcessMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCStudentProcessMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCStudentProcessMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCStudentProcessMain.Location = new System.Drawing.Point(0, 0);
            this.sCStudentProcessMain.Name = "sCStudentProcessMain";
            this.sCStudentProcessMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCStudentProcessMain.Panel1
            // 
            this.sCStudentProcessMain.Panel1.Controls.Add(this.panelStudentProcess);
            this.sCStudentProcessMain.Panel1.Controls.Add(this.gBStudentProcess);
            // 
            // sCStudentProcessMain.Panel2
            // 
            this.sCStudentProcessMain.Panel2.Controls.Add(this.dGVStudentProcess);
            this.sCStudentProcessMain.Size = new System.Drawing.Size(750, 446);
            this.sCStudentProcessMain.SplitterDistance = 282;
            this.sCStudentProcessMain.TabIndex = 0;
            // 
            // panelStudentProcess
            // 
            this.panelStudentProcess.Controls.Add(this.btnInsert);
            this.panelStudentProcess.Controls.Add(this.btnClear);
            this.panelStudentProcess.Controls.Add(this.btnUpdate);
            this.panelStudentProcess.Controls.Add(this.btnDelete);
            this.panelStudentProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentProcess.Location = new System.Drawing.Point(0, 0);
            this.panelStudentProcess.Name = "panelStudentProcess";
            this.panelStudentProcess.Size = new System.Drawing.Size(746, 45);
            this.panelStudentProcess.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsert.Location = new System.Drawing.Point(566, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(45, 45);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(611, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "刷新";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdate.Location = new System.Drawing.Point(656, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(45, 45);
            this.btnUpdate.TabIndex = 1;
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
            this.btnDelete.Location = new System.Drawing.Point(701, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gBStudentProcess
            // 
            this.gBStudentProcess.Controls.Add(this.lblTelNotice);
            this.gBStudentProcess.Controls.Add(this.lblClassNotice);
            this.gBStudentProcess.Controls.Add(this.lblProfessionNotice);
            this.gBStudentProcess.Controls.Add(this.lblSexNotice);
            this.gBStudentProcess.Controls.Add(this.lblStuNameNotice);
            this.gBStudentProcess.Controls.Add(this.lblStuIDNotice);
            this.gBStudentProcess.Controls.Add(this.lblStuID);
            this.gBStudentProcess.Controls.Add(this.lblProfession);
            this.gBStudentProcess.Controls.Add(this.txtClass);
            this.gBStudentProcess.Controls.Add(this.txtStuID);
            this.gBStudentProcess.Controls.Add(this.lblClass);
            this.gBStudentProcess.Controls.Add(this.lblStuName);
            this.gBStudentProcess.Controls.Add(this.lblTel);
            this.gBStudentProcess.Controls.Add(this.cbxSex);
            this.gBStudentProcess.Controls.Add(this.txtTel);
            this.gBStudentProcess.Controls.Add(this.txtStuName);
            this.gBStudentProcess.Controls.Add(this.txtProfession);
            this.gBStudentProcess.Controls.Add(this.lblSex);
            this.gBStudentProcess.Location = new System.Drawing.Point(16, 52);
            this.gBStudentProcess.Name = "gBStudentProcess";
            this.gBStudentProcess.Size = new System.Drawing.Size(714, 223);
            this.gBStudentProcess.TabIndex = 1;
            this.gBStudentProcess.TabStop = false;
            this.gBStudentProcess.Text = "请输入学生信息:";
            // 
            // lblTelNotice
            // 
            this.lblTelNotice.AutoSize = true;
            this.lblTelNotice.ForeColor = System.Drawing.Color.Red;
            this.lblTelNotice.Location = new System.Drawing.Point(270, 197);
            this.lblTelNotice.Name = "lblTelNotice";
            this.lblTelNotice.Size = new System.Drawing.Size(77, 14);
            this.lblTelNotice.TabIndex = 23;
            this.lblTelNotice.Text = "(11位数字)";
            // 
            // lblClassNotice
            // 
            this.lblClassNotice.AutoSize = true;
            this.lblClassNotice.ForeColor = System.Drawing.Color.Red;
            this.lblClassNotice.Location = new System.Drawing.Point(270, 164);
            this.lblClassNotice.Name = "lblClassNotice";
            this.lblClassNotice.Size = new System.Drawing.Size(182, 14);
            this.lblClassNotice.TabIndex = 22;
            this.lblClassNotice.Text = "(格式:年份+班号,如201601)";
            // 
            // lblProfessionNotice
            // 
            this.lblProfessionNotice.AutoSize = true;
            this.lblProfessionNotice.ForeColor = System.Drawing.Color.Red;
            this.lblProfessionNotice.Location = new System.Drawing.Point(270, 131);
            this.lblProfessionNotice.Name = "lblProfessionNotice";
            this.lblProfessionNotice.Size = new System.Drawing.Size(77, 14);
            this.lblProfessionNotice.TabIndex = 21;
            this.lblProfessionNotice.Text = "(20个字符)";
            // 
            // lblSexNotice
            // 
            this.lblSexNotice.AutoSize = true;
            this.lblSexNotice.ForeColor = System.Drawing.Color.Red;
            this.lblSexNotice.Location = new System.Drawing.Point(270, 98);
            this.lblSexNotice.Name = "lblSexNotice";
            this.lblSexNotice.Size = new System.Drawing.Size(119, 14);
            this.lblSexNotice.TabIndex = 20;
            this.lblSexNotice.Text = "*(必选,仅能选择)";
            // 
            // lblStuNameNotice
            // 
            this.lblStuNameNotice.AutoSize = true;
            this.lblStuNameNotice.ForeColor = System.Drawing.Color.Red;
            this.lblStuNameNotice.Location = new System.Drawing.Point(270, 65);
            this.lblStuNameNotice.Name = "lblStuNameNotice";
            this.lblStuNameNotice.Size = new System.Drawing.Size(70, 14);
            this.lblStuNameNotice.TabIndex = 19;
            this.lblStuNameNotice.Text = "(4个字符)";
            // 
            // lblStuIDNotice
            // 
            this.lblStuIDNotice.AutoSize = true;
            this.lblStuIDNotice.ForeColor = System.Drawing.Color.Red;
            this.lblStuIDNotice.Location = new System.Drawing.Point(270, 32);
            this.lblStuIDNotice.Name = "lblStuIDNotice";
            this.lblStuIDNotice.Size = new System.Drawing.Size(119, 14);
            this.lblStuIDNotice.TabIndex = 18;
            this.lblStuIDNotice.Text = "*(必填,12个数字)";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(19, 32);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(77, 14);
            this.lblStuID.TabIndex = 12;
            this.lblStuID.Text = "学    号：";
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Location = new System.Drawing.Point(19, 131);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(77, 14);
            this.lblProfession.TabIndex = 6;
            this.lblProfession.Text = "专    业：";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(103, 160);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(150, 23);
            this.txtClass.TabIndex = 9;
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(103, 28);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(150, 23);
            this.txtStuID.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(19, 164);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(77, 14);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "班    级：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(19, 65);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(77, 14);
            this.lblStuName.TabIndex = 14;
            this.lblStuName.Text = "姓    名：";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(19, 197);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(77, 14);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "联系电话：";
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxSex.Location = new System.Drawing.Point(103, 95);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(150, 21);
            this.cbxSex.TabIndex = 17;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(103, 193);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(150, 23);
            this.txtTel.TabIndex = 5;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(103, 61);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(150, 23);
            this.txtStuName.TabIndex = 15;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(103, 127);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(150, 23);
            this.txtProfession.TabIndex = 7;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(19, 98);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(77, 14);
            this.lblSex.TabIndex = 16;
            this.lblSex.Text = "性    别：";
            // 
            // dGVStudentProcess
            // 
            this.dGVStudentProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVStudentProcess.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVStudentProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVStudentProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudentProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVStudentProcess.Location = new System.Drawing.Point(0, 0);
            this.dGVStudentProcess.Name = "dGVStudentProcess";
            this.dGVStudentProcess.RowTemplate.Height = 23;
            this.dGVStudentProcess.Size = new System.Drawing.Size(746, 156);
            this.dGVStudentProcess.TabIndex = 0;
            this.dGVStudentProcess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dGVStudentProcess_MouseClick);
            // 
            // FormStudentProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 446);
            this.Controls.Add(this.sCStudentProcessMain);
            this.Name = "FormStudentProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息处理";
            this.Load += new System.EventHandler(this.FormStudentProcess_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormStudentProcess_Layout);
            this.sCStudentProcessMain.Panel1.ResumeLayout(false);
            this.sCStudentProcessMain.Panel2.ResumeLayout(false);
            this.sCStudentProcessMain.ResumeLayout(false);
            this.panelStudentProcess.ResumeLayout(false);
            this.gBStudentProcess.ResumeLayout(false);
            this.gBStudentProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVStudentProcess;
        protected internal System.Windows.Forms.Button btnInsert;
        protected internal System.Windows.Forms.Button btnDelete;
        protected internal System.Windows.Forms.Button btnUpdate;
        protected internal System.Windows.Forms.Button btnClear;
        protected internal System.Windows.Forms.SplitContainer sCStudentProcessMain;
        private System.Windows.Forms.GroupBox gBStudentProcess;
        private System.Windows.Forms.Label lblTelNotice;
        private System.Windows.Forms.Label lblClassNotice;
        private System.Windows.Forms.Label lblProfessionNotice;
        private System.Windows.Forms.Label lblSexNotice;
        private System.Windows.Forms.Label lblStuNameNotice;
        private System.Windows.Forms.Label lblStuIDNotice;
        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Panel panelStudentProcess;




    }
}