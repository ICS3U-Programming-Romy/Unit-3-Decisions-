namespace _18.PerfectSquareRootsRChuIII
{
    partial class frmPerfectSquareRoots
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
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstAnswers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(77, 12);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(200, 49);
            this.nudNumber.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(108, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstAnswers
            // 
            this.lstAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnswers.FormattingEnabled = true;
            this.lstAnswers.ItemHeight = 25;
            this.lstAnswers.Location = new System.Drawing.Point(56, 126);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(256, 279);
            this.lstAnswers.TabIndex = 2;
            // 
            // frmPerfectSquareRoots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 448);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "frmPerfectSquareRoots";
            this.Text = "Perfect Square Roots Program By Romy I. Chu III";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstAnswers;
    }
}

