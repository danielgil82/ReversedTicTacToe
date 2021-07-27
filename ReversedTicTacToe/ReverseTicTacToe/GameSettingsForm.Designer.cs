namespace ReverseTicTacToe
{
    public partial class GameSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstPlayer = new System.Windows.Forms.Label();
            this.textBoxNameFirstPlayer = new System.Windows.Forms.TextBox();
            this.textBoxNameSecondPlayer = new System.Windows.Forms.TextBox();
            this.cbComputerModeOrNot = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nUDRows = new System.Windows.Forms.NumericUpDown();
            this.nUDCols = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCols)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players:";
            // 
            // labelFirstPlayer
            // 
            this.labelFirstPlayer.AutoSize = true;
            this.labelFirstPlayer.Location = new System.Drawing.Point(86, 73);
            this.labelFirstPlayer.Name = "labelFirstPlayer";
            this.labelFirstPlayer.Size = new System.Drawing.Size(64, 17);
            this.labelFirstPlayer.TabIndex = 1;
            this.labelFirstPlayer.Text = "Player 1:";
            // 
            // textBoxNameFirstPlayer
            // 
            this.textBoxNameFirstPlayer.Location = new System.Drawing.Point(191, 73);
            this.textBoxNameFirstPlayer.Name = "textBoxNameFirstPlayer";
            this.textBoxNameFirstPlayer.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameFirstPlayer.TabIndex = 2;
            // 
            // textBoxNameSecondPlayer
            // 
            this.textBoxNameSecondPlayer.Enabled = false;
            this.textBoxNameSecondPlayer.Location = new System.Drawing.Point(191, 123);
            this.textBoxNameSecondPlayer.Name = "textBoxNameSecondPlayer";
            this.textBoxNameSecondPlayer.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameSecondPlayer.TabIndex = 3;
            this.textBoxNameSecondPlayer.Text = "Computer";
            // 
            // cbComputerModeOrNot
            // 
            this.cbComputerModeOrNot.AutoSize = true;
            this.cbComputerModeOrNot.Location = new System.Drawing.Point(89, 123);
            this.cbComputerModeOrNot.Name = "cbComputerModeOrNot";
            this.cbComputerModeOrNot.Size = new System.Drawing.Size(86, 21);
            this.cbComputerModeOrNot.TabIndex = 4;
            this.cbComputerModeOrNot.Text = "Player 2:";
            this.cbComputerModeOrNot.UseVisualStyleBackColor = true;
            this.cbComputerModeOrNot.CheckedChanged += new System.EventHandler(this.checkBoxComputerModeOrNot_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "BoardSize:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cols :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rows :";
            // 
            // nUDRows
            // 
            this.nUDRows.Location = new System.Drawing.Point(139, 242);
            this.nUDRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nUDRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDRows.Name = "nUDRows";
            this.nUDRows.Size = new System.Drawing.Size(36, 22);
            this.nUDRows.TabIndex = 8;
            this.nUDRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // nUDCols
            // 
            this.nUDCols.Location = new System.Drawing.Point(278, 242);
            this.nUDCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nUDCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDCols.Name = "nUDCols";
            this.nUDCols.Size = new System.Drawing.Size(35, 22);
            this.nUDCols.TabIndex = 9;
            this.nUDCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDCols.ValueChanged += new System.EventHandler(this.numberUpDownCols_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Location = new System.Drawing.Point(110, 311);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(223, 31);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 380);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nUDCols);
            this.Controls.Add(this.nUDRows);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbComputerModeOrNot);
            this.Controls.Add(this.textBoxNameSecondPlayer);
            this.Controls.Add(this.textBoxNameFirstPlayer);
            this.Controls.Add(this.labelFirstPlayer);
            this.Controls.Add(this.label1);
            this.Name = "GameSettingsForm";
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nUDRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstPlayer;
        private System.Windows.Forms.TextBox textBoxNameFirstPlayer;
        private System.Windows.Forms.TextBox textBoxNameSecondPlayer;
        private System.Windows.Forms.CheckBox cbComputerModeOrNot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDRows;
        private System.Windows.Forms.NumericUpDown nUDCols;
        private System.Windows.Forms.Button btnStart;
    }
}