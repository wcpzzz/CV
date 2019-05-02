namespace SSCIMS.SubUI
{
    partial class FormDataMining
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
            this.txtSupport = new System.Windows.Forms.TextBox();
            this.lblSupport = new System.Windows.Forms.Label();
            this.listboxResults = new System.Windows.Forms.ListBox();
            this.lblFrequentPatterns = new System.Windows.Forms.Label();
            this.btnMining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSupport
            // 
            this.txtSupport.Location = new System.Drawing.Point(118, 51);
            this.txtSupport.Name = "txtSupport";
            this.txtSupport.Size = new System.Drawing.Size(100, 21);
            this.txtSupport.TabIndex = 3;
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.Location = new System.Drawing.Point(62, 55);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(41, 12);
            this.lblSupport.TabIndex = 2;
            this.lblSupport.Text = "支持度";
            // 
            // listboxResults
            // 
            this.listboxResults.FormattingEnabled = true;
            this.listboxResults.ItemHeight = 12;
            this.listboxResults.Location = new System.Drawing.Point(62, 123);
            this.listboxResults.Name = "listboxResults";
            this.listboxResults.Size = new System.Drawing.Size(411, 172);
            this.listboxResults.TabIndex = 4;
            // 
            // lblFrequentPatterns
            // 
            this.lblFrequentPatterns.AutoSize = true;
            this.lblFrequentPatterns.Location = new System.Drawing.Point(64, 91);
            this.lblFrequentPatterns.Name = "lblFrequentPatterns";
            this.lblFrequentPatterns.Size = new System.Drawing.Size(89, 12);
            this.lblFrequentPatterns.TabIndex = 5;
            this.lblFrequentPatterns.Text = "学习行为特点：";
            // 
            // btnMining
            // 
            this.btnMining.Location = new System.Drawing.Point(323, 50);
            this.btnMining.Name = "btnMining";
            this.btnMining.Size = new System.Drawing.Size(75, 23);
            this.btnMining.TabIndex = 6;
            this.btnMining.Text = "分析特点";
            this.btnMining.UseVisualStyleBackColor = true;
            this.btnMining.Click += new System.EventHandler(this.btnMining_Click);
            // 
            // FormDataMining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 340);
            this.Controls.Add(this.btnMining);
            this.Controls.Add(this.lblFrequentPatterns);
            this.Controls.Add(this.listboxResults);
            this.Controls.Add(this.txtSupport);
            this.Controls.Add(this.lblSupport);
            this.Name = "FormDataMining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能分析";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSupport;
        private System.Windows.Forms.Label lblSupport;
        private System.Windows.Forms.ListBox listboxResults;
        private System.Windows.Forms.Label lblFrequentPatterns;
        private System.Windows.Forms.Button btnMining;
    }
}