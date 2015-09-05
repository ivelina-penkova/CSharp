using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Laptop_Shop
{
    class Battery
    {
        private string type;
        private int cells;
        private int mah;

        public Battery(string type,int cells, int mah)
        {
            this.Type = type;
            this.Cells = cells;
            this.Mah = mah;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid type!");
                }
                this.type = value;
            }
        }

        public int Cells
        {
            get
            {
                return this.cells;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Negative argument!");
                }
                this.cells = value;
            }
        }

        public int Mah
        {
            get
            {
                return this.mah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative argument!");
                }
                this.mah = value;
            }
        }
    }
}
