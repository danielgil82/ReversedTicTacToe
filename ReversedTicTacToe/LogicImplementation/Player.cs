using System;
using System.Collections.Generic;
using System.Text;

namespace LogicImplementation
{
    public class Player
    {
        private byte m_Score;
        private string m_Name;

        public byte Score
        {
            get
            {
                return m_Score;
            }

            set
            {
                m_Score = value;
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }
    }
}
