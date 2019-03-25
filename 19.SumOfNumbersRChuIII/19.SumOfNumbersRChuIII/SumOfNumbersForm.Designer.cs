namespace _19.SumOfNumbersRChuIII
{
    partial class frmSumOfNumbers
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(16, 20);
            this.lblEnterNumber.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(200, 29);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter a Number : ";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoEllipsis = true;
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(16, 246);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(55, 29);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Yes";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(226, 20);
            this.txtUserInput.Multiline = false;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(205, 37);
            this.txtUserInput.TabIndex = 2;
            this.txtUserInput.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(226, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 44);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 29;
            this.lstNumbers.Location = new System.Drawing.Point(21, 134);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(220, 91);
            this.lstNumbers.TabIndex = 4;
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 354);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblEnterNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum Of Numbers Program By Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.RichTextBox txtUserInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstNumbers;
    }
}

