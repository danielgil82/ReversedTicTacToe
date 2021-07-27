namespace ReverseTicTacToe
{
    public partial class TicTacToe
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
            this.labelFirstPlayerScore = new System.Windows.Forms.Label();
            this.labelSecondPlayerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstPlayerScore
            // 
            this.labelFirstPlayerScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelFirstPlayerScore.AutoSize = true;
            this.labelFirstPlayerScore.Location = new System.Drawing.Point(183, 482);
            this.labelFirstPlayerScore.Name = "labelFirstPlayerScore";
            this.labelFirstPlayerScore.Size = new System.Drawing.Size(64, 17);
            this.labelFirstPlayerScore.TabIndex = 0;
            this.labelFirstPlayerScore.Text = "Player 1:";
            // 
            // labelSecondPlayerScore
            // 
            this.labelSecondPlayerScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSecondPlayerScore.AutoSize = true;
            this.labelSecondPlayerScore.Location = new System.Drawing.Point(304, 482);
            this.labelSecondPlayerScore.Name = "labelSecondPlayerScore";
            this.labelSecondPlayerScore.Size = new System.Drawing.Size(73, 17);
            this.labelSecondPlayerScore.TabIndex = 1;
            this.labelSecondPlayerScore.Text = "Computer:";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 508);
            this.Controls.Add(this.labelSecondPlayerScore);
            this.Controls.Add(this.labelFirstPlayerScore);
            this.Name = "TicTacToe";
            this.Text = "TicTacToeMisere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstPlayerScore;
        private System.Windows.Forms.Label labelSecondPlayerScore;
    }
}