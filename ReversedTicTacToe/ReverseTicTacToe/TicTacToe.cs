using System;
using System.Drawing;
using System.Windows.Forms;
using LogicImplementation;

namespace ReverseTicTacToe
{
   
    public partial class TicTacToe : Form
    {
        private const string k_WinPhrase = "The winner is: ";
        private const string k_TiePhrase = "Tie!";
        private const string k_TieTitle = "A Tie!";
        private const string k_WinTitle = "A Win!";
        private const string k_SuffixPhrase = "Would you like to play another round?";
        private GameManager m_Game;

        internal TicTacToe(GameSettingsForm i_GameSettingsForm)
        {
            this.CenterToParent();
            InitializeComponent();
            initializeGameProperties(i_GameSettingsForm);
            this.Resize += ticTacToe_Resize;
            intializeCellButtons();
        }
        
        private void initializeGameProperties(GameSettingsForm i_GameSettingsForm)
        {
            m_Game = new GameManager(i_GameSettingsForm.BoardSize);

            m_Game.PlayingMode = i_GameSettingsForm.PlayingAgainstPlayerOrNot
                ? ePlayingMode.Player
                : ePlayingMode.Computer;
            m_Game.ListOfPlayers[0].Name = i_GameSettingsForm.FirstPlayersName;
            m_Game.ListOfPlayers[1].Name = i_GameSettingsForm.SecondPlayersName;
            this.labelFirstPlayerScore.Text = m_Game.ListOfPlayers[0].Name + ": " + m_Game.ListOfPlayers[0].Score;
            this.labelSecondPlayerScore.Text = m_Game.ListOfPlayers[1].Name + ": " + m_Game.ListOfPlayers[1].Score;
        }

        private void ticTacToe_Resize(object sender, EventArgs e)
        {
            byte boardSize = m_Game.BoardOfTheGame.BoardSize;
            int clientSizeHeight = labelFirstPlayerScore.Top / boardSize;
            int clientSizeWidth = ClientSize.Width / boardSize;

            foreach (Control control in this.Controls)
            {
                if (control is ButtonCell)
                {
                    (control as ButtonCell).Left = (int)(((control as ButtonCell).CellCoordinates.Row - 1) * clientSizeWidth);
                    (control as ButtonCell).Top = (int)(((control as ButtonCell).CellCoordinates.Col - 1) * clientSizeHeight);
                    control.Size = new Size(clientSizeWidth, clientSizeHeight);
                }
            }
        }

        /// <summary>
        /// i Represents the Row
        /// j Represents the Col
        /// </summary>
        private void intializeCellButtons()
        {
            byte boardSize = m_Game.BoardOfTheGame.BoardSize;
            int clientSizeHeight = labelFirstPlayerScore.Top / boardSize;
            int clientSizeWidth = ClientSize.Width / boardSize;

            for (byte i = 0; i < boardSize; i++)
            {
                for (byte j = 0; j < boardSize; j++)
                {
                    ButtonCell buttonCell = new ButtonCell((byte)(i + 1), (byte)(j + 1));
                    buttonCell.Left = i * clientSizeWidth;
                    buttonCell.Top = j * clientSizeHeight;
                    buttonCell.Size = new Size(clientSizeWidth, clientSizeHeight);
                    buttonCell.Click += this.buttonCell_Clicked;
                    this.Controls.Add(buttonCell);
                }
            }
        }

        private void buttonCell_Clicked(object sender, EventArgs e)
        {
            ButtonCell buttonCell = sender as ButtonCell;
            Move cellCoordinates = buttonCell.CellCoordinates;
            
            buttonCell.Text = m_Game.WhoseTurnIsIt == 0 ? "X" : "O";
            m_Game.CurrentMove = cellCoordinates;
            m_Game.AddMoveToTheMatrix();
            buttonCell.Enabled = false;
            if (m_Game.IsTheGameFinished())
            {
                gameEnded();
            }

            if (m_Game.PlayingMode == ePlayingMode.Computer && m_Game.WhoseTurnIsIt == 1 && m_Game.ContinueOrNot == eContinueOrNot.Yes) 
            {
                generateComputersNextMove();
            }
        }

        private void generateComputersNextMove()
        {
            m_Game.RandomizedLogicOfTheComputer();
            updateCellButtonAccordingToComputersRandomizedChoice();
            m_Game.AddMoveToTheMatrix();
            if (m_Game.IsTheGameFinished())
            { 
                gameEnded();
            }
        }

        private void updateCellButtonAccordingToComputersRandomizedChoice()
        {
            ButtonCell buttonCellCordinates;

            foreach (object controller in this.Controls)
            {
                if (controller is ButtonCell)
                {
                    buttonCellCordinates = controller as ButtonCell;
                    if (buttonCellCordinates.CellCoordinates.Row == m_Game.CurrentMove.Row &&
                        buttonCellCordinates.CellCoordinates.Col == m_Game.CurrentMove.Col)
                    {
                        buttonCellCordinates.Text = "O";
                        buttonCellCordinates.Enabled = false;
                    }
                }
            }
        }

        private void gameEnded()
        {
            DialogResult result;
            string winnersName = m_Game.ListOfPlayers[m_Game.WhoseTurnIsIt].Name;
            string tieMessage = string.Format(
@"{0}
{1}", 
k_TiePhrase,
k_SuffixPhrase);
            string winnerMessage = string.Format(
@"{0}{1}!
{2}",
k_WinPhrase,
winnersName,
k_SuffixPhrase);

            m_Game.UpdatingScoreAndTheWinnerOfTheCurrentGame();
            this.labelFirstPlayerScore.Text = m_Game.ListOfPlayers[0].Name + ": " + m_Game.ListOfPlayers[0].Score;
            this.labelSecondPlayerScore.Text = m_Game.ListOfPlayers[1].Name + ": " + m_Game.ListOfPlayers[1].Score;
            if (m_Game.CheckIfThereIsASequence())
            {
                result = MessageBox.Show(winnerMessage, k_WinTitle, MessageBoxButtons.YesNo);
            }
            else
            {
                result = MessageBox.Show(tieMessage, k_TieTitle, MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.Yes)
            {
                resetTheBoard();
            }
            else
            {
                m_Game.ContinueOrNot = eContinueOrNot.No;
                this.Close();
            }
        }

        private void resetTheBoard()
        {
            m_Game.ResetForAnotherRound();

            foreach (object controller in this.Controls)
            {
                if (controller is ButtonCell)
                {
                    (controller as ButtonCell).Text = string.Empty;
                    (controller as ButtonCell).Enabled = true;
                }
            }
        }
    }
}
