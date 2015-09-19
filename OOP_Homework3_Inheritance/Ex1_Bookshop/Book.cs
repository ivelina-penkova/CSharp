using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Bookshop
{
    class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) new ArgumentException("Not a valid input!");
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) new ArgumentException("Not a valid input!");
                this.author = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0) new ArgumentException("Negative input!");
                this.price = value;
            }
        }

        public override string ToString()
        {
            return "-Type: " + this.GetType().Name + "\n-Title: " + this.Title + "\n-Author: " + this.Author + "\n-Price: " + this.Price;
        }
    }
}
