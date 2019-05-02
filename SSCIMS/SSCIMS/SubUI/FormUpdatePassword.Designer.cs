namespace SSCIMS
{
    partial class FormUpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdatePassword));
            this.gBUpdatePassword = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblNewPasswordAgain = new System.Windows.Forms.Label();
            this.txtNewPasswordFirst = new System.Windows.Forms.TextBox();
            this.lblNewPasswordFirst = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.ePUpdatePassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBUpdatePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePUpdatePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // gBUpdatePassword
            // 
            this.gBUpdatePassword.BackColor = System.Drawing.Color.Transparent;
            this.gBUpdatePassword.Controls.Add(this.btnReset);
            this.gBUpdatePassword.Controls.Add(this.btnUpdate);
            this.gBUpdatePassword.Controls.Add(this.txtNewPasswordAgain);
            this.gBUpdatePassword.Controls.Add(this.lblNewPasswordAgain);
            this.gBUpdatePassword.Controls.Add(this.txtNewPasswordFirst);
            this.gBUpdatePassword.Controls.Add(this.lblNewPasswordFirst);
            this.gBUpdatePassword.Controls.Add(this.txtOldPassword);
            this.gBUpdatePassword.Controls.Add(this.lblOldPassword);
            this.gBUpdatePassword.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBUpdatePassword.Location = new System.Drawing.Point(179, 63);
            this.gBUpdatePassword.Name = "gBUpdatePassword";
            this.gBUpdatePassword.Size = new System.Drawing.Size(253, 210);
            this.gBUpdatePassword.TabIndex = 8;
            this.gBUpdatePassword.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(177, 151);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 15;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(35, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(125, 102);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.PasswordChar = '*';
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(100, 23);
            this.txtNewPasswordAgain.TabIndex = 13;
            // 
            // lblNewPasswordAgain
            // 
            this.lblNewPasswordAgain.AutoSize = true;
            this.lblNewPasswordAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPasswordAgain.Location = new System.Drawing.Point(21, 106);
            this.lblNewPasswordAgain.Name = "lblNewPasswordAgain";
            this.lblNewPasswordAgain.Size = new System.Drawing.Size(105, 14);
            this.lblNewPasswordAgain.TabIndex = 12;
            this.lblNewPasswordAgain.Text = "请重输新密码：";
            // 
            // txtNewPasswordFirst
            // 
            this.txtNewPasswordFirst.Location = new System.Drawing.Point(125, 68);
            this.txtNewPasswordFirst.Name = "txtNewPasswordFirst";
            this.txtNewPasswordFirst.PasswordChar = '*';
            this.txtNewPasswordFirst.Size = new System.Drawing.Size(100, 23);
            this.txtNewPasswordFirst.TabIndex = 11;
            // 
            // lblNewPasswordFirst
            // 
            this.lblNewPasswordFirst.AutoSize = true;
            this.lblNewPasswordFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPasswordFirst.Location = new System.Drawing.Point(21, 72);
            this.lblNewPasswordFirst.Name = "lblNewPasswordFirst";
            this.lblNewPasswordFirst.Size = new System.Drawing.Size(105, 14);
            this.lblNewPasswordFirst.TabIndex = 10;
            this.lblNewPasswordFirst.Text = "请输入新密码：";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(125, 32);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(100, 23);
            this.txtOldPassword.TabIndex = 9;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassword.Location = new System.Drawing.Point(21, 36);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(105, 14);
            this.lblOldPassword.TabIndex = 8;
            this.lblOldPassword.Text = "请输入旧密码：";
            // 
            // ePUpdatePassword
            // 
            this.ePUpdatePassword.ContainerControl = this;
            // 
            // FormUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 336);
            this.Controls.Add(this.gBUpdatePassword);
            this.Name = "FormUpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户密码修改";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormUpdatePassword_Layout);
            this.gBUpdatePassword.ResumeLayout(false);
            this.gBUpdatePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePUpdatePassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBUpdatePassword;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.Label lblNewPasswordAgain;
        private System.Windows.Forms.TextBox txtNewPasswordFirst;
        private System.Windows.Forms.Label lblNewPasswordFirst;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.ErrorProvider ePUpdatePassword;

    }
}