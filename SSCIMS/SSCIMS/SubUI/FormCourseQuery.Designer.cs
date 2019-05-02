namespace SSCIMS
{
    partial class FormCourseQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCourseQuery));
            this.sCCourseQueryMain = new System.Windows.Forms.SplitContainer();
            this.gBCourseQuery = new System.Windows.Forms.GroupBox();
            this.cBCredit = new System.Windows.Forms.CheckBox();
            this.gBCredit = new System.Windows.Forms.GroupBox();
            this.lblCreditOutEnd = new System.Windows.Forms.Label();
            this.lblCreditOutBegin = new System.Windows.Forms.Label();
            this.lblCreditInEnd = new System.Windows.Forms.Label();
            this.lblCreditInBegion = new System.Windows.Forms.Label();
            this.txtCreditOutEnd = new System.Windows.Forms.TextBox();
            this.txtCreditOutBegin = new System.Windows.Forms.TextBox();
            this.txtCreditInEnd = new System.Windows.Forms.TextBox();
            this.txtCreditInBegin = new System.Windows.Forms.TextBox();
            this.txtCreditSingle = new System.Windows.Forms.TextBox();
            this.rBCreditOut = new System.Windows.Forms.RadioButton();
            this.rBCreditIn = new System.Windows.Forms.RadioButton();
            this.cbxCreditSign = new System.Windows.Forms.ComboBox();
            this.rBCreditSingle = new System.Windows.Forms.RadioButton();
            this.cBPeriods = new System.Windows.Forms.CheckBox();
            this.gBPeriods = new System.Windows.Forms.GroupBox();
            this.lblPeriodsOutEnd = new System.Windows.Forms.Label();
            this.lbltPeriodsOutBegin = new System.Windows.Forms.Label();
            this.lblPeriodsInEnd = new System.Windows.Forms.Label();
            this.lblPeriodsInBegin = new System.Windows.Forms.Label();
            this.txtPeriodsOutEnd = new System.Windows.Forms.TextBox();
            this.txtPeriodsOutBegin = new System.Windows.Forms.TextBox();
            this.txtPeriodsInEnd = new System.Windows.Forms.TextBox();
            this.txtPeriodsInBegin = new System.Windows.Forms.TextBox();
            this.txtPeriodsSingle = new System.Windows.Forms.TextBox();
            this.rBPeriodsOut = new System.Windows.Forms.RadioButton();
            this.rBPeriodsIn = new System.Windows.Forms.RadioButton();
            this.cbxPeriodsSign = new System.Windows.Forms.ComboBox();
            this.rBPeriodsSingle = new System.Windows.Forms.RadioButton();
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
            this.cBTeacher = new System.Windows.Forms.CheckBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.cBCourseID = new System.Windows.Forms.CheckBox();
            this.cBGiveTerm = new System.Windows.Forms.CheckBox();
            this.cBCourseName = new System.Windows.Forms.CheckBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dGVSCourseQuery = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sCCourseQueryMain.Panel1.SuspendLayout();
            this.sCCourseQueryMain.Panel2.SuspendLayout();
            this.sCCourseQueryMain.SuspendLayout();
            this.gBCourseQuery.SuspendLayout();
            this.gBCredit.SuspendLayout();
            this.gBPeriods.SuspendLayout();
            this.gBGiveYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSCourseQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sCCourseQueryMain
            // 
            this.sCCourseQueryMain.BackColor = System.Drawing.Color.Transparent;
            this.sCCourseQueryMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCCourseQueryMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCCourseQueryMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sCCourseQueryMain.Location = new System.Drawing.Point(0, 0);
            this.sCCourseQueryMain.Name = "sCCourseQueryMain";
            this.sCCourseQueryMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCCourseQueryMain.Panel1
            // 
            this.sCCourseQueryMain.Panel1.Controls.Add(this.btnReset);
            this.sCCourseQueryMain.Panel1.Controls.Add(this.gBCourseQuery);
            this.sCCourseQueryMain.Panel1.Controls.Add(this.btnQuery);
            // 
            // sCCourseQueryMain.Panel2
            // 
            this.sCCourseQueryMain.Panel2.Controls.Add(this.dGVSCourseQuery);
            this.sCCourseQueryMain.Panel2.Controls.Add(this.dataGridView1);
            this.sCCourseQueryMain.Size = new System.Drawing.Size(900, 541);
            this.sCCourseQueryMain.SplitterDistance = 305;
            this.sCCourseQueryMain.TabIndex = 0;
            // 
            // gBCourseQuery
            // 
            this.gBCourseQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gBCourseQuery.Controls.Add(this.cBCredit);
            this.gBCourseQuery.Controls.Add(this.gBCredit);
            this.gBCourseQuery.Controls.Add(this.cBPeriods);
            this.gBCourseQuery.Controls.Add(this.gBPeriods);
            this.gBCourseQuery.Controls.Add(this.cBGiveYear);
            this.gBCourseQuery.Controls.Add(this.gBGiveYear);
            this.gBCourseQuery.Controls.Add(this.cbxGiveTerm);
            this.gBCourseQuery.Controls.Add(this.cBTeacher);
            this.gBCourseQuery.Controls.Add(this.txtTeacher);
            this.gBCourseQuery.Controls.Add(this.cBCourseID);
            this.gBCourseQuery.Controls.Add(this.cBGiveTerm);
            this.gBCourseQuery.Controls.Add(this.cBCourseName);
            this.gBCourseQuery.Controls.Add(this.txtCourseID);
            this.gBCourseQuery.Controls.Add(this.txtCourseName);
            this.gBCourseQuery.Location = new System.Drawing.Point(10, 4);
            this.gBCourseQuery.Name = "gBCourseQuery";
            this.gBCourseQuery.Size = new System.Drawing.Size(768, 292);
            this.gBCourseQuery.TabIndex = 2;
            this.gBCourseQuery.TabStop = false;
            this.gBCourseQuery.Text = "请设置查询条件(无选择时查询全部，课程编号，课程名称和任课老师支持模糊查询):";
            // 
            // cBCredit
            // 
            this.cBCredit.AutoSize = true;
            this.cBCredit.Location = new System.Drawing.Point(13, 227);
            this.cBCredit.Name = "cBCredit";
            this.cBCredit.Size = new System.Drawing.Size(82, 18);
            this.cBCredit.TabIndex = 38;
            this.cBCredit.Text = "课程学分";
            this.cBCredit.UseVisualStyleBackColor = true;
            this.cBCredit.CheckStateChanged += new System.EventHandler(this.cBCredit_CheckStateChanged);
            // 
            // gBCredit
            // 
            this.gBCredit.Controls.Add(this.lblCreditOutEnd);
            this.gBCredit.Controls.Add(this.lblCreditOutBegin);
            this.gBCredit.Controls.Add(this.lblCreditInEnd);
            this.gBCredit.Controls.Add(this.lblCreditInBegion);
            this.gBCredit.Controls.Add(this.txtCreditOutEnd);
            this.gBCredit.Controls.Add(this.txtCreditOutBegin);
            this.gBCredit.Controls.Add(this.txtCreditInEnd);
            this.gBCredit.Controls.Add(this.txtCreditInBegin);
            this.gBCredit.Controls.Add(this.txtCreditSingle);
            this.gBCredit.Controls.Add(this.rBCreditOut);
            this.gBCredit.Controls.Add(this.rBCreditIn);
            this.gBCredit.Controls.Add(this.cbxCreditSign);
            this.gBCredit.Controls.Add(this.rBCreditSingle);
            this.gBCredit.Location = new System.Drawing.Point(98, 213);
            this.gBCredit.Name = "gBCredit";
            this.gBCredit.Size = new System.Drawing.Size(652, 70);
            this.gBCredit.TabIndex = 37;
            this.gBCredit.TabStop = false;
            // 
            // lblCreditOutEnd
            // 
            this.lblCreditOutEnd.AutoSize = true;
            this.lblCreditOutEnd.Location = new System.Drawing.Point(526, 45);
            this.lblCreditOutEnd.Name = "lblCreditOutEnd";
            this.lblCreditOutEnd.Size = new System.Drawing.Size(35, 14);
            this.lblCreditOutEnd.TabIndex = 48;
            this.lblCreditOutEnd.Text = "或>=";
            // 
            // lblCreditOutBegin
            // 
            this.lblCreditOutBegin.AutoSize = true;
            this.lblCreditOutBegin.Location = new System.Drawing.Point(371, 45);
            this.lblCreditOutBegin.Name = "lblCreditOutBegin";
            this.lblCreditOutBegin.Size = new System.Drawing.Size(21, 14);
            this.lblCreditOutBegin.TabIndex = 48;
            this.lblCreditOutBegin.Text = "<=";
            // 
            // lblCreditInEnd
            // 
            this.lblCreditInEnd.AutoSize = true;
            this.lblCreditInEnd.Location = new System.Drawing.Point(526, 18);
            this.lblCreditInEnd.Name = "lblCreditInEnd";
            this.lblCreditInEnd.Size = new System.Drawing.Size(35, 14);
            this.lblCreditInEnd.TabIndex = 48;
            this.lblCreditInEnd.Text = "且<=";
            // 
            // lblCreditInBegion
            // 
            this.lblCreditInBegion.AutoSize = true;
            this.lblCreditInBegion.Location = new System.Drawing.Point(371, 18);
            this.lblCreditInBegion.Name = "lblCreditInBegion";
            this.lblCreditInBegion.Size = new System.Drawing.Size(21, 14);
            this.lblCreditInBegion.TabIndex = 48;
            this.lblCreditInBegion.Text = ">=";
            // 
            // txtCreditOutEnd
            // 
            this.txtCreditOutEnd.Location = new System.Drawing.Point(567, 41);
            this.txtCreditOutEnd.Name = "txtCreditOutEnd";
            this.txtCreditOutEnd.Size = new System.Drawing.Size(61, 23);
            this.txtCreditOutEnd.TabIndex = 48;
            // 
            // txtCreditOutBegin
            // 
            this.txtCreditOutBegin.Location = new System.Drawing.Point(404, 41);
            this.txtCreditOutBegin.Name = "txtCreditOutBegin";
            this.txtCreditOutBegin.Size = new System.Drawing.Size(61, 23);
            this.txtCreditOutBegin.TabIndex = 47;
            // 
            // txtCreditInEnd
            // 
            this.txtCreditInEnd.Location = new System.Drawing.Point(567, 14);
            this.txtCreditInEnd.Name = "txtCreditInEnd";
            this.txtCreditInEnd.Size = new System.Drawing.Size(61, 23);
            this.txtCreditInEnd.TabIndex = 46;
            // 
            // txtCreditInBegin
            // 
            this.txtCreditInBegin.Location = new System.Drawing.Point(404, 14);
            this.txtCreditInBegin.Name = "txtCreditInBegin";
            this.txtCreditInBegin.Size = new System.Drawing.Size(61, 23);
            this.txtCreditInBegin.TabIndex = 45;
            // 
            // txtCreditSingle
            // 
            this.txtCreditSingle.Location = new System.Drawing.Point(140, 14);
            this.txtCreditSingle.Name = "txtCreditSingle";
            this.txtCreditSingle.Size = new System.Drawing.Size(61, 23);
            this.txtCreditSingle.TabIndex = 44;
            // 
            // rBCreditOut
            // 
            this.rBCreditOut.AutoSize = true;
            this.rBCreditOut.Location = new System.Drawing.Point(275, 43);
            this.rBCreditOut.Name = "rBCreditOut";
            this.rBCreditOut.Size = new System.Drawing.Size(81, 18);
            this.rBCreditOut.TabIndex = 41;
            this.rBCreditOut.TabStop = true;
            this.rBCreditOut.Text = "多重条件";
            this.rBCreditOut.UseVisualStyleBackColor = true;
            this.rBCreditOut.CheckedChanged += new System.EventHandler(this.rBCreditOut_CheckedChanged);
            // 
            // rBCreditIn
            // 
            this.rBCreditIn.AutoSize = true;
            this.rBCreditIn.Location = new System.Drawing.Point(275, 16);
            this.rBCreditIn.Name = "rBCreditIn";
            this.rBCreditIn.Size = new System.Drawing.Size(81, 18);
            this.rBCreditIn.TabIndex = 37;
            this.rBCreditIn.TabStop = true;
            this.rBCreditIn.Text = "区间条件";
            this.rBCreditIn.UseVisualStyleBackColor = true;
            this.rBCreditIn.CheckedChanged += new System.EventHandler(this.rBCreditIn_CheckedChanged);
            // 
            // cbxCreditSign
            // 
            this.cbxCreditSign.FormattingEnabled = true;
            this.cbxCreditSign.Items.AddRange(new object[] {
            ">=",
            "<=",
            "="});
            this.cbxCreditSign.Location = new System.Drawing.Point(84, 15);
            this.cbxCreditSign.Name = "cbxCreditSign";
            this.cbxCreditSign.Size = new System.Drawing.Size(47, 21);
            this.cbxCreditSign.TabIndex = 1;
            // 
            // rBCreditSingle
            // 
            this.rBCreditSingle.AutoSize = true;
            this.rBCreditSingle.Location = new System.Drawing.Point(11, 16);
            this.rBCreditSingle.Name = "rBCreditSingle";
            this.rBCreditSingle.Size = new System.Drawing.Size(67, 18);
            this.rBCreditSingle.TabIndex = 0;
            this.rBCreditSingle.TabStop = true;
            this.rBCreditSingle.Text = "单条件";
            this.rBCreditSingle.UseVisualStyleBackColor = true;
            this.rBCreditSingle.CheckedChanged += new System.EventHandler(this.rBCreditSingle_CheckedChanged);
            // 
            // cBPeriods
            // 
            this.cBPeriods.AutoSize = true;
            this.cBPeriods.Location = new System.Drawing.Point(13, 147);
            this.cBPeriods.Name = "cBPeriods";
            this.cBPeriods.Size = new System.Drawing.Size(82, 18);
            this.cBPeriods.TabIndex = 36;
            this.cBPeriods.Text = "讲授学时";
            this.cBPeriods.UseVisualStyleBackColor = true;
            this.cBPeriods.CheckStateChanged += new System.EventHandler(this.cBPeriods_CheckStateChanged);
            // 
            // gBPeriods
            // 
            this.gBPeriods.Controls.Add(this.lblPeriodsOutEnd);
            this.gBPeriods.Controls.Add(this.lbltPeriodsOutBegin);
            this.gBPeriods.Controls.Add(this.lblPeriodsInEnd);
            this.gBPeriods.Controls.Add(this.lblPeriodsInBegin);
            this.gBPeriods.Controls.Add(this.txtPeriodsOutEnd);
            this.gBPeriods.Controls.Add(this.txtPeriodsOutBegin);
            this.gBPeriods.Controls.Add(this.txtPeriodsInEnd);
            this.gBPeriods.Controls.Add(this.txtPeriodsInBegin);
            this.gBPeriods.Controls.Add(this.txtPeriodsSingle);
            this.gBPeriods.Controls.Add(this.rBPeriodsOut);
            this.gBPeriods.Controls.Add(this.rBPeriodsIn);
            this.gBPeriods.Controls.Add(this.cbxPeriodsSign);
            this.gBPeriods.Controls.Add(this.rBPeriodsSingle);
            this.gBPeriods.Location = new System.Drawing.Point(98, 137);
            this.gBPeriods.Name = "gBPeriods";
            this.gBPeriods.Size = new System.Drawing.Size(652, 71);
            this.gBPeriods.TabIndex = 35;
            this.gBPeriods.TabStop = false;
            // 
            // lblPeriodsOutEnd
            // 
            this.lblPeriodsOutEnd.AutoSize = true;
            this.lblPeriodsOutEnd.Location = new System.Drawing.Point(526, 45);
            this.lblPeriodsOutEnd.Name = "lblPeriodsOutEnd";
            this.lblPeriodsOutEnd.Size = new System.Drawing.Size(35, 14);
            this.lblPeriodsOutEnd.TabIndex = 48;
            this.lblPeriodsOutEnd.Text = "或>=";
            // 
            // lbltPeriodsOutBegin
            // 
            this.lbltPeriodsOutBegin.AutoSize = true;
            this.lbltPeriodsOutBegin.Location = new System.Drawing.Point(371, 45);
            this.lbltPeriodsOutBegin.Name = "lbltPeriodsOutBegin";
            this.lbltPeriodsOutBegin.Size = new System.Drawing.Size(21, 14);
            this.lbltPeriodsOutBegin.TabIndex = 48;
            this.lbltPeriodsOutBegin.Text = "<=";
            // 
            // lblPeriodsInEnd
            // 
            this.lblPeriodsInEnd.AutoSize = true;
            this.lblPeriodsInEnd.Location = new System.Drawing.Point(526, 18);
            this.lblPeriodsInEnd.Name = "lblPeriodsInEnd";
            this.lblPeriodsInEnd.Size = new System.Drawing.Size(35, 14);
            this.lblPeriodsInEnd.TabIndex = 48;
            this.lblPeriodsInEnd.Text = "且<=";
            // 
            // lblPeriodsInBegin
            // 
            this.lblPeriodsInBegin.AutoSize = true;
            this.lblPeriodsInBegin.Location = new System.Drawing.Point(371, 18);
            this.lblPeriodsInBegin.Name = "lblPeriodsInBegin";
            this.lblPeriodsInBegin.Size = new System.Drawing.Size(21, 14);
            this.lblPeriodsInBegin.TabIndex = 48;
            this.lblPeriodsInBegin.Text = ">=";
            // 
            // txtPeriodsOutEnd
            // 
            this.txtPeriodsOutEnd.Location = new System.Drawing.Point(567, 41);
            this.txtPeriodsOutEnd.Name = "txtPeriodsOutEnd";
            this.txtPeriodsOutEnd.Size = new System.Drawing.Size(61, 23);
            this.txtPeriodsOutEnd.TabIndex = 48;
            // 
            // txtPeriodsOutBegin
            // 
            this.txtPeriodsOutBegin.Location = new System.Drawing.Point(404, 41);
            this.txtPeriodsOutBegin.Name = "txtPeriodsOutBegin";
            this.txtPeriodsOutBegin.Size = new System.Drawing.Size(61, 23);
            this.txtPeriodsOutBegin.TabIndex = 47;
            // 
            // txtPeriodsInEnd
            // 
            this.txtPeriodsInEnd.Location = new System.Drawing.Point(567, 14);
            this.txtPeriodsInEnd.Name = "txtPeriodsInEnd";
            this.txtPeriodsInEnd.Size = new System.Drawing.Size(61, 23);
            this.txtPeriodsInEnd.TabIndex = 46;
            // 
            // txtPeriodsInBegin
            // 
            this.txtPeriodsInBegin.Location = new System.Drawing.Point(404, 14);
            this.txtPeriodsInBegin.Name = "txtPeriodsInBegin";
            this.txtPeriodsInBegin.Size = new System.Drawing.Size(61, 23);
            this.txtPeriodsInBegin.TabIndex = 45;
            // 
            // txtPeriodsSingle
            // 
            this.txtPeriodsSingle.Location = new System.Drawing.Point(140, 14);
            this.txtPeriodsSingle.Name = "txtPeriodsSingle";
            this.txtPeriodsSingle.Size = new System.Drawing.Size(61, 23);
            this.txtPeriodsSingle.TabIndex = 44;
            // 
            // rBPeriodsOut
            // 
            this.rBPeriodsOut.AutoSize = true;
            this.rBPeriodsOut.Location = new System.Drawing.Point(275, 43);
            this.rBPeriodsOut.Name = "rBPeriodsOut";
            this.rBPeriodsOut.Size = new System.Drawing.Size(81, 18);
            this.rBPeriodsOut.TabIndex = 41;
            this.rBPeriodsOut.TabStop = true;
            this.rBPeriodsOut.Text = "多重条件";
            this.rBPeriodsOut.UseVisualStyleBackColor = true;
            this.rBPeriodsOut.CheckedChanged += new System.EventHandler(this.rBPeriodsOut_CheckedChanged);
            // 
            // rBPeriodsIn
            // 
            this.rBPeriodsIn.AutoSize = true;
            this.rBPeriodsIn.Location = new System.Drawing.Point(275, 16);
            this.rBPeriodsIn.Name = "rBPeriodsIn";
            this.rBPeriodsIn.Size = new System.Drawing.Size(81, 18);
            this.rBPeriodsIn.TabIndex = 37;
            this.rBPeriodsIn.TabStop = true;
            this.rBPeriodsIn.Text = "区间条件";
            this.rBPeriodsIn.UseVisualStyleBackColor = true;
            this.rBPeriodsIn.CheckedChanged += new System.EventHandler(this.rBPeriodsIn_CheckedChanged);
            // 
            // cbxPeriodsSign
            // 
            this.cbxPeriodsSign.FormattingEnabled = true;
            this.cbxPeriodsSign.Items.AddRange(new object[] {
            ">=",
            "<=",
            "="});
            this.cbxPeriodsSign.Location = new System.Drawing.Point(84, 15);
            this.cbxPeriodsSign.Name = "cbxPeriodsSign";
            this.cbxPeriodsSign.Size = new System.Drawing.Size(47, 21);
            this.cbxPeriodsSign.TabIndex = 1;
            // 
            // rBPeriodsSingle
            // 
            this.rBPeriodsSingle.AutoSize = true;
            this.rBPeriodsSingle.Location = new System.Drawing.Point(11, 16);
            this.rBPeriodsSingle.Name = "rBPeriodsSingle";
            this.rBPeriodsSingle.Size = new System.Drawing.Size(67, 18);
            this.rBPeriodsSingle.TabIndex = 0;
            this.rBPeriodsSingle.TabStop = true;
            this.rBPeriodsSingle.Text = "单条件";
            this.rBPeriodsSingle.UseVisualStyleBackColor = true;
            this.rBPeriodsSingle.CheckedChanged += new System.EventHandler(this.rBPeriodsSingle_CheckedChanged);
            // 
            // cBGiveYear
            // 
            this.cBGiveYear.AutoSize = true;
            this.cBGiveYear.Location = new System.Drawing.Point(13, 71);
            this.cBGiveYear.Name = "cBGiveYear";
            this.cBGiveYear.Size = new System.Drawing.Size(82, 18);
            this.cBGiveYear.TabIndex = 34;
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
            this.gBGiveYear.Location = new System.Drawing.Point(98, 60);
            this.gBGiveYear.Name = "gBGiveYear";
            this.gBGiveYear.Size = new System.Drawing.Size(652, 71);
            this.gBGiveYear.TabIndex = 33;
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
            this.rBYearOut.TabStop = true;
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
            this.rBYearIn.TabStop = true;
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
            this.cbxGiveTerm.Location = new System.Drawing.Point(510, 30);
            this.cbxGiveTerm.Name = "cbxGiveTerm";
            this.cbxGiveTerm.Size = new System.Drawing.Size(55, 21);
            this.cbxGiveTerm.TabIndex = 32;
            // 
            // cBTeacher
            // 
            this.cBTeacher.AutoSize = true;
            this.cBTeacher.Location = new System.Drawing.Point(581, 31);
            this.cBTeacher.Name = "cBTeacher";
            this.cBTeacher.Size = new System.Drawing.Size(82, 18);
            this.cBTeacher.TabIndex = 31;
            this.cBTeacher.Text = "任课教师";
            this.cBTeacher.UseVisualStyleBackColor = true;
            this.cBTeacher.CheckStateChanged += new System.EventHandler(this.cBTeacher_CheckStateChanged);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(668, 29);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(85, 23);
            this.txtTeacher.TabIndex = 30;
            // 
            // cBCourseID
            // 
            this.cBCourseID.AutoSize = true;
            this.cBCourseID.Location = new System.Drawing.Point(13, 31);
            this.cBCourseID.Name = "cBCourseID";
            this.cBCourseID.Size = new System.Drawing.Size(82, 18);
            this.cBCourseID.TabIndex = 25;
            this.cBCourseID.Text = "课程编号";
            this.cBCourseID.UseVisualStyleBackColor = true;
            this.cBCourseID.CheckStateChanged += new System.EventHandler(this.cBCourseID_CheckStateChanged);
            // 
            // cBGiveTerm
            // 
            this.cBGiveTerm.AutoSize = true;
            this.cBGiveTerm.Location = new System.Drawing.Point(423, 31);
            this.cBGiveTerm.Name = "cBGiveTerm";
            this.cBGiveTerm.Size = new System.Drawing.Size(82, 18);
            this.cBGiveTerm.TabIndex = 29;
            this.cBGiveTerm.Text = "授课学期";
            this.cBGiveTerm.UseVisualStyleBackColor = true;
            this.cBGiveTerm.CheckStateChanged += new System.EventHandler(this.cBGiveTerm_CheckStateChanged);
            // 
            // cBCourseName
            // 
            this.cBCourseName.AutoSize = true;
            this.cBCourseName.Location = new System.Drawing.Point(196, 31);
            this.cBCourseName.Name = "cBCourseName";
            this.cBCourseName.Size = new System.Drawing.Size(82, 18);
            this.cBCourseName.TabIndex = 27;
            this.cBCourseName.Text = "课程名称";
            this.cBCourseName.UseVisualStyleBackColor = true;
            this.cBCourseName.CheckStateChanged += new System.EventHandler(this.cBCourseName_CheckStateChanged);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(100, 29);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(76, 23);
            this.txtCourseID.TabIndex = 24;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(283, 29);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(124, 23);
            this.txtCourseName.TabIndex = 26;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(846, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.Location = new System.Drawing.Point(801, 250);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(45, 45);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dGVSCourseQuery
            // 
            this.dGVSCourseQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSCourseQuery.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dGVSCourseQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVSCourseQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSCourseQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVSCourseQuery.Location = new System.Drawing.Point(0, 0);
            this.dGVSCourseQuery.Name = "dGVSCourseQuery";
            this.dGVSCourseQuery.RowTemplate.Height = 23;
            this.dGVSCourseQuery.Size = new System.Drawing.Size(896, 228);
            this.dGVSCourseQuery.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(896, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormCourseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 541);
            this.Controls.Add(this.sCCourseQueryMain);
            this.Name = "FormCourseQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息查询";
            this.Load += new System.EventHandler(this.FormCourseQuery_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.dGVCourseQuery_Layout);
            this.sCCourseQueryMain.Panel1.ResumeLayout(false);
            this.sCCourseQueryMain.Panel2.ResumeLayout(false);
            this.sCCourseQueryMain.ResumeLayout(false);
            this.gBCourseQuery.ResumeLayout(false);
            this.gBCourseQuery.PerformLayout();
            this.gBCredit.ResumeLayout(false);
            this.gBCredit.PerformLayout();
            this.gBPeriods.ResumeLayout(false);
            this.gBPeriods.PerformLayout();
            this.gBGiveYear.ResumeLayout(false);
            this.gBGiveYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSCourseQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sCCourseQueryMain;
        protected internal System.Windows.Forms.Button btnReset;
        protected internal System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBCourseQuery;
        private System.Windows.Forms.CheckBox cBCredit;
        private System.Windows.Forms.GroupBox gBCredit;
        private System.Windows.Forms.Label lblCreditOutEnd;
        private System.Windows.Forms.Label lblCreditOutBegin;
        private System.Windows.Forms.Label lblCreditInEnd;
        private System.Windows.Forms.Label lblCreditInBegion;
        private System.Windows.Forms.TextBox txtCreditOutEnd;
        private System.Windows.Forms.TextBox txtCreditOutBegin;
        private System.Windows.Forms.TextBox txtCreditInEnd;
        private System.Windows.Forms.TextBox txtCreditInBegin;
        private System.Windows.Forms.TextBox txtCreditSingle;
        private System.Windows.Forms.RadioButton rBCreditOut;
        private System.Windows.Forms.RadioButton rBCreditIn;
        private System.Windows.Forms.ComboBox cbxCreditSign;
        private System.Windows.Forms.RadioButton rBCreditSingle;
        private System.Windows.Forms.CheckBox cBPeriods;
        private System.Windows.Forms.GroupBox gBPeriods;
        private System.Windows.Forms.Label lblPeriodsOutEnd;
        private System.Windows.Forms.Label lbltPeriodsOutBegin;
        private System.Windows.Forms.Label lblPeriodsInEnd;
        private System.Windows.Forms.Label lblPeriodsInBegin;
        private System.Windows.Forms.TextBox txtPeriodsOutEnd;
        private System.Windows.Forms.TextBox txtPeriodsOutBegin;
        private System.Windows.Forms.TextBox txtPeriodsInEnd;
        private System.Windows.Forms.TextBox txtPeriodsInBegin;
        private System.Windows.Forms.TextBox txtPeriodsSingle;
        private System.Windows.Forms.RadioButton rBPeriodsOut;
        private System.Windows.Forms.RadioButton rBPeriodsIn;
        private System.Windows.Forms.ComboBox cbxPeriodsSign;
        private System.Windows.Forms.RadioButton rBPeriodsSingle;
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
        private System.Windows.Forms.ComboBox cbxGiveTerm;
        private System.Windows.Forms.CheckBox cBTeacher;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.CheckBox cBCourseID;
        private System.Windows.Forms.CheckBox cBGiveTerm;
        private System.Windows.Forms.CheckBox cBCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.DataGridView dGVSCourseQuery;



    }
}