using System;
using System.Collections.Generic;
using System.Text;

namespace LogicImplementation
{
    public struct Move 
    {
        private byte? m_Row;
        private byte? m_Col;
        
        public Move(byte i_RowValue, byte i_ColValue)
        {
            m_Row = i_RowValue;
            m_Col = i_ColValue;
        }
 
        public byte? Row
        {
            get
            {
                return m_Row;
            }

            set
            {
                m_Row = value;
            }
        }

        public byte? Col
        {
            get
            {
                return m_Col;
            }

            set
            {
                m_Col = value;
            }
        }
    }
}
