namespace _15.ChocolateBoxesRChuIII
{
    partial class frmChocolateBoxes
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
            this.lblHowMany = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.nudBoxCount = new System.Windows.Forms.NumericUpDown();
            this.btnReward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHowMany
            // 
            this.lblHowMany.AutoSize = true;
            this.lblHowMany.Location = new System.Drawing.Point(15, 9);
            this.lblHowMany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHowMany.Name = "lblHowMany";
            this.lblHowMany.Size = new System.Drawing.Size(384, 25);
            this.lblHowMany.TabIndex = 0;
            this.lblHowMany.Text = "How Many Boxes did the Student Sell?";
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Location = new System.Drawing.Point(167, 117);
            this.lblReward.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(50, 25);
            this.lblReward.TabIndex = 1;
            this.lblReward.Text = "Yes";
            this.lblReward.Visible = false;
            // 
            // nudBoxCount
            // 
            this.nudBoxCount.Location = new System.Drawing.Point(408, 12);
            this.nudBoxCount.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudBoxCount.Name = "nudBoxCount";
            this.nudBoxCount.Size = new System.Drawing.Size(120, 31);
            this.nudBoxCount.TabIndex = 2;
            // 
            // btnReward
            // 
            this.btnReward.Location = new System.Drawing.Point(172, 55);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(146, 32);
            this.btnReward.TabIndex = 3;
            this.btnReward.Text = "Get Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 187);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.nudBoxCount);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.lblHowMany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocholate Boxes Program";
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHowMany;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.NumericUpDown nudBoxCount;
        private System.Windows.Forms.Button btnReward;
    }
}

