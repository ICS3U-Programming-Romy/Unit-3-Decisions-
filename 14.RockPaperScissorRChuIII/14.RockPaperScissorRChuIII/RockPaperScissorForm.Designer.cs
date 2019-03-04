namespace _14.RockPaperScissorRChuIII
{
    partial class frmRockPaperScissor
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
            this.grbPlayerChoice = new System.Windows.Forms.GroupBox();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerScissor = new System.Windows.Forms.RadioButton();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerScissor = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grbPlayerChoice.SuspendLayout();
            this.grbComputerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayerChoice
            // 
            this.grbPlayerChoice.Controls.Add(this.radPlayerScissor);
            this.grbPlayerChoice.Controls.Add(this.radPlayerPaper);
            this.grbPlayerChoice.Controls.Add(this.radPlayerRock);
            this.grbPlayerChoice.Location = new System.Drawing.Point(0, 0);
            this.grbPlayerChoice.Name = "grbPlayerChoice";
            this.grbPlayerChoice.Size = new System.Drawing.Size(139, 99);
            this.grbPlayerChoice.TabIndex = 0;
            this.grbPlayerChoice.TabStop = false;
            this.grbPlayerChoice.Text = "Player\'s Choice";
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radComputerScissor);
            this.grbComputerChoice.Controls.Add(this.radComputerPaper);
            this.grbComputerChoice.Controls.Add(this.radComputerRock);
            this.grbComputerChoice.Location = new System.Drawing.Point(0, 105);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(139, 98);
            this.grbComputerChoice.TabIndex = 1;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer\'s Choice";
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Location = new System.Drawing.Point(12, 19);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(51, 17);
            this.radPlayerRock.TabIndex = 1;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Location = new System.Drawing.Point(12, 42);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(53, 17);
            this.radPlayerPaper.TabIndex = 2;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerScissor
            // 
            this.radPlayerScissor.AutoSize = true;
            this.radPlayerScissor.Location = new System.Drawing.Point(12, 65);
            this.radPlayerScissor.Name = "radPlayerScissor";
            this.radPlayerScissor.Size = new System.Drawing.Size(59, 17);
            this.radPlayerScissor.TabIndex = 3;
            this.radPlayerScissor.TabStop = true;
            this.radPlayerScissor.Text = "Scissor";
            this.radPlayerScissor.UseVisualStyleBackColor = true;
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(12, 19);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 17);
            this.radComputerRock.TabIndex = 4;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(12, 42);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(53, 17);
            this.radComputerPaper.TabIndex = 5;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerScissor
            // 
            this.radComputerScissor.AutoSize = true;
            this.radComputerScissor.Location = new System.Drawing.Point(12, 65);
            this.radComputerScissor.Name = "radComputerScissor";
            this.radComputerScissor.Size = new System.Drawing.Size(59, 17);
            this.radComputerScissor.TabIndex = 6;
            this.radComputerScissor.Text = "Scissor";
            this.radComputerScissor.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(145, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Location = new System.Drawing.Point(191, 67);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(0, 13);
            this.lblWinLose.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(159, 19);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmRockPaperScissor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.grbPlayerChoice);
            this.Name = "frmRockPaperScissor";
            this.Text = "Rock Paper Scissor Program By Romy I. Chu III";
            this.grbPlayerChoice.ResumeLayout(false);
            this.grbPlayerChoice.PerformLayout();
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayerChoice;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.RadioButton radPlayerScissor;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.RadioButton radComputerScissor;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Button btnCheck;
    }
}

