namespace SSCIMS.SubUI
{
    partial class FormTurnData
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
            this.btnTurnData = new System.Windows.Forms.Button();
            this.dGVTurndata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTurndata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTurnData
            // 
            this.btnTurnData.Location = new System.Drawing.Point(466, 31);
            this.btnTurnData.Name = "btnTurnData";
            this.btnTurnData.Size = new System.Drawing.Size(75, 23);
            this.btnTurnData.TabIndex = 0;
            this.btnTurnData.Text = "数据转换";
            this.btnTurnData.UseVisualStyleBackColor = true;
            this.btnTurnData.Click += new System.EventHandler(this.btnTurnData_Click);
            // 
            // dGVTurndata
            // 
            this.dGVTurndata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTurndata.Location = new System.Drawing.Point(38, 95);
            this.dGVTurndata.Name = "dGVTurndata";
            this.dGVTurndata.RowTemplate.Height = 23;
            this.dGVTurndata.Size = new System.Drawing.Size(487, 164);
            this.dGVTurndata.TabIndex = 1;
            // 
            // FormTurnData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 305);
            this.Controls.Add(this.dGVTurndata);
            this.Controls.Add(this.btnTurnData);
            this.Name = "FormTurnData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据转换";
            this.Load += new System.EventHandler(this.FormTurnData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTurndata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTurnData;
        private System.Windows.Forms.DataGridView dGVTurndata;
    }
}