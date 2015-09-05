/*
Problem 2.	Laptop Shop
Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, RAM, graphics card,
HDD, screen, battery, battery life in hours and price.
•	The model and price are mandatory. All other values are optional.
•	Define two separate classes: a class Laptop holding an instance of class Battery.
•	Define several constructors that take different sets of arguments (full laptop + battery information or only part of it).
Use proper variable types.
•	Add a method in the Laptop class that displays information about the given instance
o	Tip: override the ToString() method
•	Put validation in all property setters and constructors. String values cannot be empty, and numeric data cannot be negative. 
Throw exceptions when improper data is entered.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Problem_2_Laptop_Shop.Battery;

namespace Problem_2_Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicscard;
        private string hdd;
        private string screen;
        private Battery battery;
        private int batterylife;
        private int price;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid argument!");
                }
                this.model = value;
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid argument!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid argument!");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Negative input!");
                }
                this.ram = value;
            }
        }

        public string Graphicscard
        {
            get
            {
                return this.graphicscard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid argument!");
                }
                this.graphicscard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid argument!");
                }
                this.hdd = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
