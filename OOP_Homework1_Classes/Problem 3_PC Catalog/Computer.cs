/*
Define a class Computer that holds name, several components and price. The components (processor, graphics card, motherboard, etc.) 
should be objects of class Component, which holds name, details (optional) and price. 
•	Define several constructors that take different sets of arguments. Use proper variable types. Use properties to validate the data. 
Throw exceptions when improper data is entered.
•	Add a method in the Computer class that displays the name, each of the components' name and price and the total computer price. 
The total price is the sum of all components' price. Print the prices in BGN currency format.
•	Create several Computer objects, sort them by price, and print them on the console using the created display method.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Problem_3_PC_Catalog.Component;

namespace Problem_3_PC_Catalog
{
    class Computer
    {
        private string name;
        private Component component;
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

        public Component Component
        {
            get
            {
                return this.component;
            }
            set
            {
                this.component = value;
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

        public Computer(string name, Component component, int price)
        {
            this.Name = name;
            this.Component = component;
            this.Price = price;
        }
        public Computer(string name, string comname, string details, int comprice, int price)
        {
            this.Name = name;
            this.Component = new Component(comname,details,comprice);
            this.Price = price;
        }

        public override string ToString()
        {
            string result = "Name: " + this.Name + "\nComponent's name: " + this.Component.Name + "\nComponent's Details: " + this.Component.Details
                           + "\nComponent's Price: " + this.Component.Price + " lv.\nPrice: " + this.price + " lv.";
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc1 = new Computer("Lenovo", "A","B",22500,1000);
            Computer pc2 = new Computer("HP", "A", "B", 23500, 2000);
            Computer pc3 = new Computer("Sony Vaio", "A", "B", 24500, 3000);
            Computer pc4 = new Computer("Samsung", "A", "B", 25500, 4000);
            Computer pc5 = new Computer("Acer", "A", "B", 26500, 5000);

            List<Computer> l = new List<Computer>();
            l.Add(pc1);
            l.Add(pc2);
            l.Add(pc3);
            l.Add(pc4);
            l.Add(pc5);
            l = l.OrderBy(o => o.Price).ToList<Computer>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(l[i].ToString());
            }

        }
    }
}
