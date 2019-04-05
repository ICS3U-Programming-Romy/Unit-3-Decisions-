namespace _23.RunningAverageRChuIII
{
    partial class frmRunningAverage
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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.lblWannaExit = new System.Windows.Forms.Label();
            this.lblTheAverage = new System.Windows.Forms.Label();
            this.btnCalcualte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(15, 28);
            this.lblEnterNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(366, 25);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter a number between 0 and 100 : ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(390, 25);
            this.txtInput.Multiline = false;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(136, 34);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            // 
            // lblWannaExit
            // 
            this.lblWannaExit.AutoSize = true;
            this.lblWannaExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWannaExit.Location = new System.Drawing.Point(15, 53);
            this.lblWannaExit.Name = "lblWannaExit";
            this.lblWannaExit.Size = new System.Drawing.Size(166, 25);
            this.lblWannaExit.TabIndex = 2;
            this.lblWannaExit.Text = "(Enter -1 to exit)";
            // 
            // lblTheAverage
            // 
            this.lblTheAverage.AutoSize = true;
            this.lblTheAverage.Location = new System.Drawing.Point(15, 177);
            this.lblTheAverage.Name = "lblTheAverage";
            this.lblTheAverage.Size = new System.Drawing.Size(251, 25);
            this.lblTheAverage.TabIndex = 3;
            this.lblTheAverage.Text = "The running average is : ";
            // 
            // btnCalcualte
            // 
            this.btnCalcualte.Location = new System.Drawing.Point(20, 99);
            this.btnCalcualte.Name = "btnCalcualte";
            this.btnCalcualte.Size = new System.Drawing.Size(202, 49);
            this.btnCalcualte.TabIndex = 4;
            this.btnCalcualte.Text = "Calculate Average";
            this.btnCalcualte.UseVisualStyleBackColor = true;
            this.btnCalcualte.Click += new System.EventHandler(this.btnCalcualte_Click);
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 237);
            this.Controls.Add(this.btnCalcualte);
            this.Controls.Add(this.lblTheAverage);
            this.Controls.Add(this.lblWannaExit);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblEnterNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average Program By Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label lblWannaExit;
        private System.Windows.Forms.Label lblTheAverage;
        private System.Windows.Forms.Button btnCalcualte;
    }
}

