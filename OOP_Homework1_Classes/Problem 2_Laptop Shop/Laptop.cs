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
        private double batterylife;
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

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid argument!");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public double Batterylife
        {
            get
            {
                return this.batterylife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative argument!");
                }
                this.batterylife = value;
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
                if (value < 0)
                {
                    throw new ArgumentException("Negative argument!");
                }
                this.price = value;
            }
        }

        public Laptop(string model, int price, string manifacturer, string processor, 
                      int ram, string graphicscard, string hdd, string screen, Battery battery, double batterylife)
        {
            this.Model = model;
            this.Price = price;
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Graphicscard = graphicscard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Batterylife = batterylife;
        }

        public Laptop(string model, int price, string manifacturer, string processor,
                      int ram, string graphicscard, string hdd, string screen, string type, int cells, int mah, double batterylife)
        {
            this.Model = model;
            this.Price = price;
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Graphicscard = graphicscard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = new Battery(type, cells,mah);
            this.Batterylife = batterylife;
        }
        public Laptop(string model, int price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, int price, string processor,
                      int ram)
        {
            this.Model = model;
            this.Price = price;
            this.Processor = processor;
            this.Ram = ram;
        }

        public override string ToString()
        {
            string result = "Model: " + this.Model + "\nManifacturer: " + this.Manifacturer + "\nProcessor: " + this.Processor + "\nRAM: " + this.Ram + " GB"
                            + "\nGraphics Card: " + this.Graphicscard + "\nHDD: " + this.Hdd + "\nScreen: " + this.Screen + "\nBattery: " + this.Battery.Type + ", " + this.Battery.Cells + "cells, "
                            + this.Battery.Mah + " mAh\nBattery Life: " + this.Batterylife + "\nPrice: " + this.Price + " lv.";
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop("Lenovo Yoga 2 Pro", 2259, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                                8, "Intel HD Graphics 4400", "128GB SSD", "13.3 (33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
                                "Li-Ion", 4, 2550, 4.5);
            Console.WriteLine(l.ToString());
        }
    }
}
