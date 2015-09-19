using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Bookshop
{
    class GoldenEditionBook:Book
    {
        private const double rate= 1.3;
        public GoldenEditionBook(string title, string author, double price):base(title,author,price)
        {
        }

        public override double Price
        {
            get
            {
                return base.Price * rate;
            }

            set
            {
                base.Price = value;
            }
        }

        
    }
}
