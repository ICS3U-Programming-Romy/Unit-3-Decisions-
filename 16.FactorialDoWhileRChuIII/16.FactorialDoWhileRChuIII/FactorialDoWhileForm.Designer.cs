namespace _16.FactorialDoWhileRChuIII
{
    partial class frmFactorialDoWhile
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
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblNums = new System.Windows.Forms.Label();
            this.txtfacNumber = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.AutoSize = true;
            this.lblEnterNum.Location = new System.Drawing.Point(12, 9);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(180, 25);
            this.lblEnterNum.TabIndex = 1;
            this.lblEnterNum.Text = "Enter a Number : ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(120, 46);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 25;
            this.lstNumbers.Location = new System.Drawing.Point(29, 137);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNumbers.Size = new System.Drawing.Size(294, 179);
            this.lstNumbers.TabIndex = 2;
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Location = new System.Drawing.Point(12, 109);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(337, 25);
            this.lblNums.TabIndex = 3;
            this.lblNums.Text = "Multiply these numbers together : ";
            // 
            // txtfacNumber
            // 
            this.txtfacNumber.Location = new System.Drawing.Point(198, 9);
            this.txtfacNumber.Name = "txtfacNumber";
            this.txtfacNumber.Size = new System.Drawing.Size(100, 31);
            this.txtfacNumber.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(24, 334);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 25);
            this.lblAnswer.TabIndex = 5;
            // 
            // frmFactorialDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 389);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtfacNumber);
            this.Controls.Add(this.lblNums);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEnterNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmFactorialDoWhile";
            this.Text = "Factorial Do While Program By Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.TextBox txtfacNumber;
        private System.Windows.Forms.Label lblAnswer;
    }
}

