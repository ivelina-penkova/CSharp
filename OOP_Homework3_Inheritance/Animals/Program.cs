using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Gender{ get; set;}

        public abstract void ProduceSound();
    }

    class Dog : Animal
    {
        public Dog(string name, int age, string gender):base(name, age, gender) { }

        public override void ProduceSound()
        {
            Console.WriteLine("bau");
        }

    }

    class Frog : Animal
    {
        public Frog(string name, int age, string gender):base(name, age, gender) { }

        public override void ProduceSound()
        {
            Console.WriteLine("ribbet");
        }
    }

    abstract class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("meow");
        }
    }

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "female")
        {
        }
    }

    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, "male")
        {
        }
    }

    interface ISoundProducable
    {
        void ProduceSound();
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Frog goshko = new Frog("Goshko", 10, "male");
                Frog peshko = new Frog("Peshko", 3, "male");
                Frog mariika = new Frog("Mariika", 7, "female");

                Dog ivancho = new Dog("Ivancho", 11, "male");
                Dog sashko = new Dog("Sashko", 1, "male");
                Dog magdalena = new Dog("Magdalena", 2, "female");

                Kitten tania = new Kitten("Tania", 3);
                Kitten penka = new Kitten("Penka", 4);
                Kitten goshka = new Kitten("Goshka", 10);

                Tomcat kristian = new Tomcat("Kristian", 1);
                Tomcat pesho = new Tomcat("Pesho", 10);
                Tomcat stanislav = new Tomcat("Stanislav", 5);

                IList<Animal> animals = new List<Animal>
                {
                    goshko, peshko, mariika, ivancho, sashko, magdalena,
                    tania, penka, goshka, kristian, pesho, stanislav
                };

                goshko.ProduceSound();
                sashko.ProduceSound();
                tania.ProduceSound();
                kristian.ProduceSound();

                double catsAverageAge = animals
                    .Where(animal => animal is Cat)
                    .Average(cat => cat.Age);

                double dogsAverageAge = animals
                    .Where(animal => animal is Dog)
                    .Average(dog => dog.Age);

                double frogsAverageAge = animals
                    .Where(animal => animal is Frog)
                    .Average(frog => frog.Age);

                Console.WriteLine("Frogs average age is: {0:F2}", frogsAverageAge);
                Console.WriteLine("Dogs average age is: {0:F2}", dogsAverageAge);
                Console.WriteLine("Cats average age is: {0:F2}", catsAverageAge);

            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    
    }
}
