using System;
using System.Collections.Generic;
using System.Text;

namespace LogicImplementation
{ 
    public class Board
    {
        private readonly byte r_SizeOfBoard;
        private BoardCell[,] m_MatrixMoves;
     
        internal Board(byte i_SizeOfBoard)
        {
            r_SizeOfBoard = i_SizeOfBoard;
            MatrixMoves = new BoardCell[i_SizeOfBoard, i_SizeOfBoard]; // Initialization of the matrix 
            initializeBoard();
        }

        private void initializeBoard()
        {
            for (int i = 0; i < r_SizeOfBoard; i++)
            {
                for (int j = 0; j < r_SizeOfBoard; j++)
                {
                    MatrixMoves[i, j] = new BoardCell();
                }
            }
        }

        internal void ClearBoard() 
        {
            foreach (BoardCell bc in MatrixMoves)
            {
                bc.CellsSymbol = eSymbol.Empty;
            }
        }

        public byte BoardSize
        {
            get
            {
                return r_SizeOfBoard;
            }
        }

        internal BoardCell[,] MatrixMoves
        {
            get
            {
                return m_MatrixMoves;
            }

            set
            {
                m_MatrixMoves = value;
            }
        }
    }
}
