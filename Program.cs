using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooop_5
{
    class Program
    {
        class Person
        {
            private string name;
            private string surname;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }

            public void Display()
            {
                Console.WriteLine(Name + " | " + Surname);
            }

            public Person(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }
        }
        class Employee : Person
        {
            private string company;

            public Employee(string name, string surname, string comp)
                : base(name, surname)
            {
                company = comp;
            }

            public string Company
            {
                get { return company; }
                set { company = value; }
            }
            public void DisplayE()
            {
                Console.WriteLine(Name + " | " + Surname + " | " + Company);
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("Сергей", "Вольхин");
            Employee emp = new Employee("Людмила", "Добролюбова", "ИСиП-330");

            p.Display();
            emp.DisplayE();
            Console.ReadKey();
        }
    }
}
