/*
Our program will work with the following classes:
•	Book - represents a book that holds title, author and price. Validate that the title and author are not null. 
The price should never be a negative number. A book should offer information about itself in the format shown in the output below.
•	GoldenEditionBook - represents a special book holds the same properties as any Book, but its price is always 30% higher.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex1_Bookshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Pod igoto", "Ivan Vazov", 15.90);
            Console.WriteLine(b.ToString());

            GoldenEditionBook goldenb = new GoldenEditionBook("Tutun", "Dimitur Dimov", 15.90);
            Console.WriteLine(goldenb.ToString());
        }
    }
}
