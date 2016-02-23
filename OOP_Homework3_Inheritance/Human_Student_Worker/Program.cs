using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_Worker
{
    abstract class Human
    {
        private string firstname;
        private string lastname;

        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    new ArgumentException("Invalid firstname");

                this.firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    new ArgumentException("Non-valid lastname");

                this.lastname = value;
            }
        }
    }

    class Student : Human
    {
        private string facultynumber;

        public Student(string firstname, string lastname, string facultynumber):base(firstname, lastname)
        {
            this.FacultyNumber = facultynumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultynumber;
            }
            set
            {
                if (value.Length < 5 && value.Length > 10)
                    new ArgumentException("Invalid faculty number!");

                this.facultynumber = value;
            }
        }
    }

    class Worker : Human
    {
        private int weeksalary;
        private int workhoursperday;

        public Worker(string firstname, string lastname, int weeksalary, int workhoursperday):base(firstname, lastname)
        {
            this.WeekSalary = weeksalary;
            this.WorkHoursPerDay = workhoursperday;
        }

        public int WeekSalary
        {
            get
            {
                return this.weeksalary;
            }
            set
            {
                this.weeksalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workhoursperday;
            }
            set
            {
                this.workhoursperday = value;
            }
        }

        public int MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Student> listStudent = new List<Student>()
            {
                new Student("Ivo", "Prokopiev", "11111"),
                new Student("Asq", "Stefanova", "31245"),
                new Student("Iskra", "Urumova", "44444"),
                new Student("Zlati", "Zlatev", "67895"),
                new Student("Encho", "Chakyrov", "34256"),
                new Student("Stoil", "Stoilov", "93452"),
                new Student("Katq", "Petrova", "71234"),
                new Student("Minka", "Furiqta", "69856"),
                new Student("Pesho", "Kaskata", "78743"),
                new Student("Sami", "Vinkela", "77889")
            };
            listStudent = new List<Student>(listStudent.OrderBy(s => s.FacultyNumber));

            foreach (var student in listStudent)
            {
                Console.WriteLine(student + " Faculty number:" + student.FacultyNumber);
            }
            Console.WriteLine();

            List<Worker> listWorker = new List<Worker>()
            {
                new Worker("Sasho", "Yovkov", 200, 8),
                new Worker("Bash", "Maistora", 1000, 8),
                new Worker("Jelqzko", "Sopata", 600, 8),
                new Worker("Masha", "Grigorova", 1200, 8),
                new Worker("Kyncho", "Minchev", 300, 8),
                new Worker("Pepi", "Dunkov", 160, 8),
                new Worker("Bate", "Goiko", 720, 8),
                new Worker("Marselo", "Mastroiani", 4000, 8),
                new Worker("Jim", "Black", 50, 8),
                new Worker("Sheila", "Max", 670, 8),
            };

            listWorker = new List<Worker>(listWorker.OrderBy(w => w.MoneyPerHour()));
            foreach (var worker in listWorker)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker);
            }
            Console.WriteLine();


            List<Human> allHumans = new List<Human>();

            listStudent.ForEach(student => allHumans.Add(student));
            listWorker.ForEach(worker => allHumans.Add((worker)));

            allHumans = new List<Human>(allHumans.OrderBy(a => a.FirstName));
            foreach (var human in allHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName + " - " + human.GetType().Name);
            }
        }
    }
}
