using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    class Person
    {
        private string name;
        private int birthYear;
        public string Name
        {
            get { return name; }
        }
        public int BirthYear
        {
            get { return birthYear; }
        }
        public Person()
        {
            name = "Unknown";
            int currentYear = DateTime.Now.Year;
            birthYear = currentYear;
        }
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public static int Age(int birthYear)
        {
            int currentDate = DateTime.Now.Year;
            int age = currentDate - birthYear;
            return age;
        }
        public static Person Input()
        {
            Console.Write($"Enter your name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter your year of birth: ");
            int birthYear = int.Parse(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }
        public void ChangeName(string name)
        {
            name = "Very Young";
            this.name = name;
        }
        public override string ToString()
        {
            return "Name: " + name + ", Year of Birth: " + birthYear;
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person a, Person b)
        {
            return a.name.Equals(b.name);
        }
        public static bool operator !=(Person a, Person b)
        {
            return !(a.Equals(b));
        }
    }
}
