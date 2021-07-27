using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReverseTicTacToe
{
    public partial class GameSettingsForm : Form
    {
        private const string k_DefaultModeChoice = "Computer";
        private const string k_DefaultUnamedUser = "Unknown";

        internal GameSettingsForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ShowInTaskbar = false;
            this.CenterToScreen();
            InitializeComponent();
        }

        internal string FirstPlayersName
        {
            get
            {
                return textBoxNameFirstPlayer.Text;
            }
        }

        internal string SecondPlayersName
        {
            get
            {
                return textBoxNameSecondPlayer.Text;
            }
        }

        internal bool PlayingAgainstPlayerOrNot
        {
            get
            {
                return this.cbComputerModeOrNot.Checked;
            }
        }

        internal byte BoardSize
        {
            get
            {
                return (byte)nUDRows.Value;
            }
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            nUDCols.Value = nUDRows.Value;
        }

        private void numberUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            nUDRows.Value = nUDCols.Value;
        }

        private void checkBoxComputerModeOrNot_CheckedChanged(object sender, EventArgs e)
        {
            if (cbComputerModeOrNot.Checked)
            {
                textBoxNameSecondPlayer.Enabled = true;
                textBoxNameSecondPlayer.Text = string.Empty;
            }
            else
            {
                textBoxNameSecondPlayer.Enabled = false;
                textBoxNameSecondPlayer.Text = k_DefaultModeChoice;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (textBoxNameFirstPlayer.Text != "")
            {
                if (cbComputerModeOrNot.Checked)
                {
                    if (textBoxNameSecondPlayer.Text != "")
                    {
                        GenerateSecondForm();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(string.Format("You've " +
                            "clicked on regualr mode {0}Do you want to choose " +
                            "a name?", Environment.NewLine), "Error" ,buttons);
                        if(result == DialogResult.No)
                        {
                            textBoxNameSecondPlayer.Text = k_DefaultUnamedUser;
                            GenerateSecondForm();
                        }
                    }
                }
                else
                {
                    GenerateSecondForm();
                }
            }
            else
            {
                MessageBox.Show("You must choose a name before you start the game");
            }
        }

        private void GenerateSecondForm()
        {
            TicTacToe secondForm = new TicTacToe(this);
            this.Hide();
            secondForm.ShowDialog();
            this.Close();
        }
    }
}
