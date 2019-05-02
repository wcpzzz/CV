namespace SSCIMS
{
    partial class FormStudentUserProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentUserProcess));
            this.labelcaption = new System.Windows.Forms.Label();
            this.sCStudentUserProcessMain = new System.Windows.Forms.SplitContainer();
            this.sCStudentProcessLeft = new System.Windows.Forms.SplitContainer();
            this.tSStudentProcessTopLeft = new System.Windows.Forms.ToolStrip();
            this.tSLabelStudentUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSButtonAllChosoe = new System.Windows.Forms.ToolStripButton();
            this.tSButtonClear = new System.Windows.Forms.ToolStripButton();
            this.tSButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cListStudentUserProcess = new System.Windows.Forms.CheckedListBox();
            this.sCStudentProcessRight = new System.Windows.Forms.SplitContainer();
            this.tSStudentProcessTopRight = new System.Windows.Forms.ToolStrip();
            this.tSLabelStudentUserList = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSButtonAllUserChoose = new System.Windows.Forms.ToolStripButton();
            this.tSButtonAllCancel = new System.Windows.Forms.ToolStripButton();
            this.tSButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.dGVStudentUserProcess = new System.Windows.Forms.DataGridView();
            this.sCStudentUserProcessMain.Panel1.SuspendLayout();
            this.sCStudentUserProcessMain.Panel2.SuspendLayout();
            this.sCStudentUserProcessMain.SuspendLayout();
            this.sCStudentProcessLeft.Panel1.SuspendLayout();
            this.sCStudentProcessLeft.Panel2.SuspendLayout();
            this.sCStudentProcessLeft.SuspendLayout();
            this.tSStudentProcessTopLeft.SuspendLayout();
            this.sCStudentProcessRight.Panel1.SuspendLayout();
            this.sCStudentProcessRight.Panel2.SuspendLayout();
            this.sCStudentProcessRight.SuspendLayout();
            this.tSStudentProcessTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentUserProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcaption
            // 
            this.labelcaption.AutoSize = true;
            this.labelcaption.Location = new System.Drawing.Point(125, 127);
            this.labelcaption.Name = "labelcaption";
            this.labelcaption.Size = new System.Drawing.Size(149, 12);
            this.labelcaption.TabIndex = 1;
            this.labelcaption.Text = "调用学生用户信息处理成功";
            // 
            // sCStudentUserProcessMain
            // 
            this.sCStudentUserProcessMain.BackColor = System.Drawing.Color.Transparent;
            this.sCStudentUserProcessMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCStudentUserProcessMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCStudentUserProcessMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCStudentUserProcessMain.Location = new System.Drawing.Point(0, 0);
            this.sCStudentUserProcessMain.Name = "sCStudentUserProcessMain";
            // 
            // sCStudentUserProcessMain.Panel1
            // 
            this.sCStudentUserProcessMain.Panel1.Controls.Add(this.sCStudentProcessLeft);
            // 
            // sCStudentUserProcessMain.Panel2
            // 
            this.sCStudentUserProcessMain.Panel2.Controls.Add(this.sCStudentProcessRight);
            this.sCStudentUserProcessMain.Size = new System.Drawing.Size(784, 362);
            this.sCStudentUserProcessMain.SplitterDistance = 237;
            this.sCStudentUserProcessMain.TabIndex = 2;
            // 
            // sCStudentProcessLeft
            // 
            this.sCStudentProcessLeft.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sCStudentProcessLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCStudentProcessLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCStudentProcessLeft.Location = new System.Drawing.Point(0, 0);
            this.sCStudentProcessLeft.Name = "sCStudentProcessLeft";
            this.sCStudentProcessLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCStudentProcessLeft.Panel1
            // 
            this.sCStudentProcessLeft.Panel1.Controls.Add(this.tSStudentProcessTopLeft);
            // 
            // sCStudentProcessLeft.Panel2
            // 
            this.sCStudentProcessLeft.Panel2.Controls.Add(this.cListStudentUserProcess);
            this.sCStudentProcessLeft.Size = new System.Drawing.Size(237, 362);
            this.sCStudentProcessLeft.SplitterDistance = 25;
            this.sCStudentProcessLeft.TabIndex = 2;
            // 
            // tSStudentProcessTopLeft
            // 
            this.tSStudentProcessTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSStudentProcessTopLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLabelStudentUser,
            this.toolStripSeparator1,
            this.tSButtonAllChosoe,
            this.tSButtonClear,
            this.tSButtonInsert,
            this.toolStripSeparator3});
            this.tSStudentProcessTopLeft.Location = new System.Drawing.Point(0, 0);
            this.tSStudentProcessTopLeft.Name = "tSStudentProcessTopLeft";
            this.tSStudentProcessTopLeft.Size = new System.Drawing.Size(233, 21);
            this.tSStudentProcessTopLeft.TabIndex = 0;
            this.tSStudentProcessTopLeft.Text = "操作区";
            // 
            // tSLabelStudentUser
            // 
            this.tSLabelStudentUser.Font = new System.Drawing.Font("宋体", 10F);
            this.tSLabelStudentUser.Name = "tSLabelStudentUser";
            this.tSLabelStudentUser.Size = new System.Drawing.Size(105, 18);
            this.tSLabelStudentUser.Text = "可添加学生用户";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 21);
            // 
            // tSButtonAllChosoe
            // 
            this.tSButtonAllChosoe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonAllChosoe.Image = ((System.Drawing.Image)(resources.GetObject("tSButtonAllChosoe.Image")));
            this.tSButtonAllChosoe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonAllChosoe.Name = "tSButtonAllChosoe";
            this.tSButtonAllChosoe.Size = new System.Drawing.Size(23, 18);
            this.tSButtonAllChosoe.Text = "全选";
            this.tSButtonAllChosoe.Click += new System.EventHandler(this.tSButtonAllChosoe_Click);
            // 
            // tSButtonClear
            // 
            this.tSButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("tSButtonClear.Image")));
            this.tSButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonClear.Name = "tSButtonClear";
            this.tSButtonClear.Size = new System.Drawing.Size(23, 18);
            this.tSButtonClear.Text = "清空";
            this.tSButtonClear.Click += new System.EventHandler(this.tSButtonClear_Click);
            // 
            // tSButtonInsert
            // 
            this.tSButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("tSButtonInsert.Image")));
            this.tSButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonInsert.Name = "tSButtonInsert";
            this.tSButtonInsert.Size = new System.Drawing.Size(23, 18);
            this.tSButtonInsert.Text = "添加";
            this.tSButtonInsert.Click += new System.EventHandler(this.tSButtonInsert_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 21);
            // 
            // cListStudentUserProcess
            // 
            this.cListStudentUserProcess.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cListStudentUserProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cListStudentUserProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cListStudentUserProcess.FormattingEnabled = true;
            this.cListStudentUserProcess.Location = new System.Drawing.Point(0, 0);
            this.cListStudentUserProcess.Name = "cListStudentUserProcess";
            this.cListStudentUserProcess.Size = new System.Drawing.Size(233, 324);
            this.cListStudentUserProcess.TabIndex = 0;
            // 
            // sCStudentProcessRight
            // 
            this.sCStudentProcessRight.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sCStudentProcessRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCStudentProcessRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCStudentProcessRight.Location = new System.Drawing.Point(0, 0);
            this.sCStudentProcessRight.Name = "sCStudentProcessRight";
            this.sCStudentProcessRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCStudentProcessRight.Panel1
            // 
            this.sCStudentProcessRight.Panel1.Controls.Add(this.tSStudentProcessTopRight);
            // 
            // sCStudentProcessRight.Panel2
            // 
            this.sCStudentProcessRight.Panel2.Controls.Add(this.dGVStudentUserProcess);
            this.sCStudentProcessRight.Size = new System.Drawing.Size(543, 362);
            this.sCStudentProcessRight.SplitterDistance = 25;
            this.sCStudentProcessRight.TabIndex = 2;
            // 
            // tSStudentProcessTopRight
            // 
            this.tSStudentProcessTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSStudentProcessTopRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLabelStudentUserList,
            this.toolStripSeparator2,
            this.tSButtonAllUserChoose,
            this.tSButtonAllCancel,
            this.tSButtonDelete});
            this.tSStudentProcessTopRight.Location = new System.Drawing.Point(0, 0);
            this.tSStudentProcessTopRight.Name = "tSStudentProcessTopRight";
            this.tSStudentProcessTopRight.Size = new System.Drawing.Size(539, 21);
            this.tSStudentProcessTopRight.TabIndex = 1;
            this.tSStudentProcessTopRight.Text = "toolStrip1";
            // 
            // tSLabelStudentUserList
            // 
            this.tSLabelStudentUserList.Font = new System.Drawing.Font("宋体", 10F);
            this.tSLabelStudentUserList.Name = "tSLabelStudentUserList";
            this.tSLabelStudentUserList.Size = new System.Drawing.Size(91, 18);
            this.tSLabelStudentUserList.Text = "学生用户列表";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // tSButtonAllUserChoose
            // 
            this.tSButtonAllUserChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonAllUserChoose.Image = ((System.Drawing.Image)(resources.GetObject("tSButtonAllUserChoose.Image")));
            this.tSButtonAllUserChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonAllUserChoose.Name = "tSButtonAllUserChoose";
            this.tSButtonAllUserChoose.Size = new System.Drawing.Size(23, 18);
            this.tSButtonAllUserChoose.Text = "全选";
            this.tSButtonAllUserChoose.Click += new System.EventHandler(this.tSButtonAllUserChoose_Click);
            // 
            // tSButtonAllCancel
            // 
            this.tSButtonAllCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonAllCancel.Image = ((System.Drawing.Image)(resources.GetObject("tSButtonAllCancel.Image")));
            this.tSButtonAllCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonAllCancel.Name = "tSButtonAllCancel";
            this.tSButtonAllCancel.Size = new System.Drawing.Size(23, 18);
            this.tSButtonAllCancel.Text = "清空";
            this.tSButtonAllCancel.Click += new System.EventHandler(this.tSButtonAllCancel_Click);
            // 
            // tSButtonDelete
            // 
            this.tSButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("tSButtonDelete.Image")));
            this.tSButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonDelete.Name = "tSButtonDelete";
            this.tSButtonDelete.Size = new System.Drawing.Size(23, 18);
            this.tSButtonDelete.Text = "删除";
            this.tSButtonDelete.Click += new System.EventHandler(this.tSButtonDelete_Click);
            // 
            // dGVStudentUserProcess
            // 
            this.dGVStudentUserProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVStudentUserProcess.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVStudentUserProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVStudentUserProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudentUserProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVStudentUserProcess.Location = new System.Drawing.Point(0, 0);
            this.dGVStudentUserProcess.Name = "dGVStudentUserProcess";
            this.dGVStudentUserProcess.RowTemplate.Height = 23;
            this.dGVStudentUserProcess.Size = new System.Drawing.Size(539, 329);
            this.dGVStudentUserProcess.TabIndex = 1;
            // 
            // FormStudentUserProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.sCStudentUserProcessMain);
            this.Controls.Add(this.labelcaption);
            this.Name = "FormStudentUserProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生用户信息处理";
            this.Load += new System.EventHandler(this.FormStudentUserProcess_Load);
            this.sCStudentUserProcessMain.Panel1.ResumeLayout(false);
            this.sCStudentUserProcessMain.Panel2.ResumeLayout(false);
            this.sCStudentUserProcessMain.ResumeLayout(false);
            this.sCStudentProcessLeft.Panel1.ResumeLayout(false);
            this.sCStudentProcessLeft.Panel1.PerformLayout();
            this.sCStudentProcessLeft.Panel2.ResumeLayout(false);
            this.sCStudentProcessLeft.ResumeLayout(false);
            this.tSStudentProcessTopLeft.ResumeLayout(false);
            this.tSStudentProcessTopLeft.PerformLayout();
            this.sCStudentProcessRight.Panel1.ResumeLayout(false);
            this.sCStudentProcessRight.Panel1.PerformLayout();
            this.sCStudentProcessRight.Panel2.ResumeLayout(false);
            this.sCStudentProcessRight.ResumeLayout(false);
            this.tSStudentProcessTopRight.ResumeLayout(false);
            this.tSStudentProcessTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentUserProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcaption;
        private System.Windows.Forms.SplitContainer sCStudentUserProcessMain;
        private System.Windows.Forms.ToolStrip tSStudentProcessTopRight;
        private System.Windows.Forms.ToolStrip tSStudentProcessTopLeft;
        private System.Windows.Forms.ToolStripLabel tSLabelStudentUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSButtonInsert;
        private System.Windows.Forms.ToolStripButton tSButtonAllChosoe;
        private System.Windows.Forms.ToolStripButton tSButtonClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tSLabelStudentUserList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tSButtonAllUserChoose;
        private System.Windows.Forms.ToolStripButton tSButtonDelete;
        private System.Windows.Forms.ToolStripButton tSButtonAllCancel;
        private System.Windows.Forms.SplitContainer sCStudentProcessRight;
        private System.Windows.Forms.SplitContainer sCStudentProcessLeft;
        private System.Windows.Forms.CheckedListBox cListStudentUserProcess;
        private System.Windows.Forms.DataGridView dGVStudentUserProcess;
    }
}