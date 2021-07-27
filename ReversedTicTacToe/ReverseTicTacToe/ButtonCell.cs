using System;
using System.Text;
using System.Windows.Forms;
using LogicImplementation;

namespace ReverseTicTacToe
{ 
    internal class ButtonCell : Button
    {
        private Move m_CellCoordinates;

        internal ButtonCell(byte i_Row, byte i_Col)
        {
            m_CellCoordinates.Row = i_Row;
            m_CellCoordinates.Col = i_Col;
        }

        internal Move CellCoordinates
        {
            get
            {
                return m_CellCoordinates;
            }
        }
    }
}
