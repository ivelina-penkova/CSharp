using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private int price;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid argument!");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid argument!");
                }
                this.details = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Negative argument!");
                }
                this.price = value;
            }
        }

        public Component(string name, string details, int price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, int price):this(name, "details", price)
        {
        }
    }
}
