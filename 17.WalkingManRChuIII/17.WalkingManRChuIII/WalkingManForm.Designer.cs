namespace _17.WalkingManRChuIII
{
    partial class frmWalkingMan
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
            this.btnWalk = new System.Windows.Forms.Button();
            this.picMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(85, 12);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(75, 23);
            this.btnWalk.TabIndex = 0;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // picMan
            // 
            this.picMan.Image = global::_17.WalkingManRChuIII.Properties.Resources.walk9;
            this.picMan.Location = new System.Drawing.Point(44, 51);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(180, 180);
            this.picMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMan.TabIndex = 1;
            this.picMan.TabStop = false;
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 261);
            this.Controls.Add(this.picMan);
            this.Controls.Add(this.btnWalk);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man Program by Romy I. Chu III";
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.PictureBox picMan;
    }
}

