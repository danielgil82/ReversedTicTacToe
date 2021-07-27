using System;
using System.Collections.Generic;
using System.Text;

namespace LogicImplementation
{
    internal class BoardCell
    {
        private eSymbol m_CellSymbol = eSymbol.Empty;

        internal eSymbol CellsSymbol
        {
            get
            {
                return m_CellSymbol;
            }

            set
            {
                m_CellSymbol = value;
            }
        }
    }
}
