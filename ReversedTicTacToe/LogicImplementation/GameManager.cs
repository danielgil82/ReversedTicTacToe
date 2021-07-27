using System;
using System.Collections.Generic;

namespace LogicImplementation
{
    public class GameManager
    {
        private static Board m_BoardOfTheGame;
        private readonly List<Player> m_ListOfPlayers;
        private byte m_CurrentMovesCounter;
        private byte m_WhoseTurnIsIt;
        private Move m_CurrentMove;
        private eSingleGameResult m_GameResult;
        private ePlayingMode m_PlayingMode;
        private eContinueOrNot m_ContinueOrNot;
        
        public GameManager(byte i_SizeOfBoard)
        {
            m_BoardOfTheGame = new Board(i_SizeOfBoard);
            m_ContinueOrNot = eContinueOrNot.Yes;
            m_CurrentMove = new Move(0, 0);
            m_ListOfPlayers = new List<Player>(2);
            m_ListOfPlayers.Add(new Player());
            m_ListOfPlayers.Add(new Player());
        }

        public List<Player> ListOfPlayers
        {
            get
            {
                return m_ListOfPlayers;
            }
        }

        public byte WhoseTurnIsIt
        {
            get
            {
                return m_WhoseTurnIsIt;
            }

            set
            {
                m_WhoseTurnIsIt = value;
            }
        }

        public eContinueOrNot ContinueOrNot
        {
            get
            {
                return m_ContinueOrNot;
            }

            set
            {
                m_ContinueOrNot = value;
            }
        }

        internal eSingleGameResult GameResult
        {
            get
            {
                return m_GameResult;
            }

            set
            {
                m_GameResult = value;
            }
        }

        public ePlayingMode PlayingMode
        {
            get
            {
                return m_PlayingMode;
            }

            set
            {
                m_PlayingMode = value;
            }
        }

        public Move CurrentMove
        {
            get
            {
                return m_CurrentMove;
            }

            set
            {
                m_CurrentMove = value;
            }
        }

        public Board BoardOfTheGame
        {
            get
            {
                return m_BoardOfTheGame;
            }

            set
            {
                m_BoardOfTheGame = value;
            }
        }

        private byte MovesCounter
        {
            get
            {
                return m_CurrentMovesCounter;
            }

            set
            {
                m_CurrentMovesCounter = value;
            }
        }

        public void RandomizedLogicOfTheComputer()
        {
            ////Generates different random each time
            Random cell = new Random(DateTime.Now.Ticks.GetHashCode());

            m_CurrentMove.Row = (byte)cell.Next(1, m_BoardOfTheGame.BoardSize + 1);
            m_CurrentMove.Col = (byte)cell.Next(1, m_BoardOfTheGame.BoardSize + 1);

            while (!moveValidation())
            {
                m_CurrentMove.Row = (byte)cell.Next(1, m_BoardOfTheGame.BoardSize + 1);
                m_CurrentMove.Col = (byte)cell.Next(1, m_BoardOfTheGame.BoardSize + 1);
            }
        }

        public void AddMoveToTheMatrix()
        {
            if (m_CurrentMovesCounter % 2 == 0)
            {
                m_BoardOfTheGame.MatrixMoves[(byte)(CurrentMove.Row - 1), (byte)CurrentMove.Col - 1].CellsSymbol = eSymbol.FirstPlayerSign;
            }
            else
            {
                m_BoardOfTheGame.MatrixMoves[(byte)CurrentMove.Row - 1, (byte)CurrentMove.Col - 1].CellsSymbol = eSymbol.SecondPlayerSign;
            }

            m_CurrentMovesCounter++;
            m_WhoseTurnIsIt = (byte)(m_CurrentMovesCounter % 2);
        }

        private bool moveValidation()
        {
            return (this.CurrentMove.Row - 1 >= 0 && this.CurrentMove.Row - 1 < m_BoardOfTheGame.BoardSize) &&
                   (this.CurrentMove.Col - 1 >= 0 && this.CurrentMove.Col - 1 < m_BoardOfTheGame.BoardSize) &&
                   (m_BoardOfTheGame.MatrixMoves[(byte)CurrentMove.Row - 1, (byte)CurrentMove.Col - 1].CellsSymbol == eSymbol.Empty);
        }

        public bool CheckIfThereIsASequence()
        {
            return sequenceInRow() || sequenceInCol() || sequenceInMainDiagonal() || sequenceInSecondDiagonal();
        }

        private bool sequenceInCol()
        {
            byte counterOfO = 0;
            byte counterOfX = 0;
            bool flagThatIndicatesThatThereIsASequence = false;

            for (int i = 0; i < m_BoardOfTheGame.BoardSize; i++)
            {
                for (int k = 0; k < m_BoardOfTheGame.BoardSize; k++)
                {
                    if (m_BoardOfTheGame.MatrixMoves[k, i].CellsSymbol == eSymbol.FirstPlayerSign)
                    {
                        counterOfX++;
                    }
                    else if (m_BoardOfTheGame.MatrixMoves[k, i].CellsSymbol == eSymbol.SecondPlayerSign)
                    {
                        counterOfO++;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (checkCounterValidationForSequence(counterOfX, counterOfO))
                {
                    flagThatIndicatesThatThereIsASequence = true;
                    break;
                }

                counterOfX = 0;
                counterOfO = 0;
            }

            return flagThatIndicatesThatThereIsASequence;
        }

        private bool sequenceInRow()
        {
            byte counterOfO = 0;
            byte counterOfX = 0;
            bool flagThatIndicatesThatThereIsASequence = false;

            // check all columns
            for (int i = 0; i < m_BoardOfTheGame.BoardSize; i++)
            {
                for (int j = 0; j < m_BoardOfTheGame.BoardSize; j++)
                {
                    if (m_BoardOfTheGame.MatrixMoves[i, j].CellsSymbol == eSymbol.FirstPlayerSign)
                    {
                        counterOfX++;
                    }
                    else if (m_BoardOfTheGame.MatrixMoves[i, j].CellsSymbol == eSymbol.SecondPlayerSign)
                    {
                        counterOfO++;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (checkCounterValidationForSequence(counterOfX, counterOfO))
                {
                    flagThatIndicatesThatThereIsASequence = true;
                    break;
                }

                counterOfX = 0;
                counterOfO = 0;
            }

            return flagThatIndicatesThatThereIsASequence;
        }

        private bool sequenceInMainDiagonal()
        {
            byte counterOfO = 0;
            byte counterOfX = 0;
            
            for (int i = 0; i < m_BoardOfTheGame.BoardSize; i++)
            {
                if (m_BoardOfTheGame.MatrixMoves[i, i].CellsSymbol == eSymbol.FirstPlayerSign)
                {
                    counterOfX++;
                }
                else if (m_BoardOfTheGame.MatrixMoves[i, i].CellsSymbol == eSymbol.SecondPlayerSign)
                {
                    counterOfO++;
                }
                else
                {
                    break;
                }
            }

            return checkCounterValidationForSequence(counterOfX, counterOfO);
        }

        private bool sequenceInSecondDiagonal()
        {
            byte counterOfO = 0;
            byte counterOfX = 0;

            for (int i = 0; i < m_BoardOfTheGame.BoardSize; i++)
            {
                if (m_BoardOfTheGame.MatrixMoves[i, m_BoardOfTheGame.BoardSize - i - 1].CellsSymbol == eSymbol.FirstPlayerSign)
                {
                    counterOfX++;
                }
                else if (m_BoardOfTheGame.MatrixMoves[i, m_BoardOfTheGame.BoardSize - i - 1].CellsSymbol == eSymbol.SecondPlayerSign)
                {
                    counterOfO++;
                }
                else
                {
                    break;
                }
            }

            return checkCounterValidationForSequence(counterOfX, counterOfO);
        }

        private bool checkCounterValidationForSequence(byte i_FirstCounter, byte i_SecondCounter)
        {
            return (i_FirstCounter == m_BoardOfTheGame.BoardSize) || (i_SecondCounter == m_BoardOfTheGame.BoardSize);
        }

        // Checks if the game ended , by two tests(Tie / Win)
        public bool IsTheGameFinished()
        {
            return CheckIfThereIsASequence() || isThereATie();
        }

        private bool isThereATie()
        {
            return MovesCounter == (m_BoardOfTheGame.BoardSize * m_BoardOfTheGame.BoardSize);
        }
        
        public void UpdatingScoreAndTheWinnerOfTheCurrentGame()
        {
            /// Found sequence
            if (CheckIfThereIsASequence())
            {
                if (WhoseTurnIsIt == 0)
                {
                    ListOfPlayers[0].Score++;
                    GameResult = eSingleGameResult.FirstPlayerWon;
                }
                else
                {
                    ListOfPlayers[1].Score++;
                    GameResult = eSingleGameResult.SecondPlayerWon;
                }
            }
            else  
            {
                GameResult = eSingleGameResult.Tie;
            }
        }

        public void ResetForAnotherRound()
        {
            MovesCounter = 0;
            WhoseTurnIsIt = 0;
            m_BoardOfTheGame.ClearBoard();
        }
    }
}
