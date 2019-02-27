namespace _12.GuessingGameRChuIII
{
    partial class frmGuessingGame
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.picYesORNo = new System.Windows.Forms.PictureBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picYesORNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(12, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(371, 25);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Guess an integer between 1 and 15 : ";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(380, 9);
            this.txtInput.MaxLength = 2;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(138, 32);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            // 
            // picYesORNo
            // 
            this.picYesORNo.Image = global::_12.GuessingGameRChuIII.Properties.Resources.red_x;
            this.picYesORNo.Location = new System.Drawing.Point(390, 47);
            this.picYesORNo.Name = "picYesORNo";
            this.picYesORNo.Size = new System.Drawing.Size(119, 115);
            this.picYesORNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYesORNo.TabIndex = 2;
            this.picYesORNo.TabStop = false;
            this.picYesORNo.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 101);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(335, 29);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Your Answer is CORRECT!!";
            this.lblAnswer.Visible = false;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(92, 47);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(150, 35);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess!!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 191);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.picYesORNo);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInstruction);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing Game Program By: Romy I. Chu III";
            ((System.ComponentModel.ISupportInitialize)(this.picYesORNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.PictureBox picYesORNo;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnGuess;
    }
}

