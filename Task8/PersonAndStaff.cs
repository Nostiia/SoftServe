using System.Xml.Linq;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    private string name;
    public Person(string name)
    { this.name = name; }
    public string Name { get { return name; } }
    public virtual void Print()
    {
        Console.WriteLine("Name: {0}", this.name);
    }
    public int CompareTo(Person other)
    {
        return name.CompareTo(other.name);
    }
}
public class Staff: Person
{
    private int salary;
    public Staff(string name, int salary): base(name)
    {
        this.salary = salary;
    }
    public int Salary { get { return salary; } }
    public override void Print()
    {
        Console.WriteLine("Person {0} has salary ${1}", Name, this.salary);
    }
}
public class Teacher: Staff
{
    private string subject;
    public Teacher(string name, int salary, string subject): base(name, salary)
    {
        this.subject = subject;
    }
    public override void Print()
    {
        Console.WriteLine("Teacher {0} has salary ${1} and knows exactly {2}", Name, Salary, this.subject);
    }
}
public class Developer: Staff
{
    private int level;
    public Developer(string name, int salary, int level): base(name, salary)
    {
        this.level = level;
    }
    public override void Print()
    {
        Console.WriteLine("Developer {0} has salary ${1} and his/her level {2}", Name, Salary, this.level);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Oleg");
        Staff staff1 = new Staff("Igor", 200);
        Teacher teacher1 = new Teacher("Ira", 300, "Math");
        Developer developer1 = new Developer("Dima", 500, 5);
        List<Person> people = new List<Person>
        { 
            person1,
            staff1,
            teacher1,
            developer1
        };

        foreach (Person person in people)
        {
            person.Print();
        }
        string searchName = Console.ReadLine();
        foreach (Person person in people)
        {
            if (person.Name == searchName)
            {
                person.Print();
            }
        }
        people.Sort();
        foreach (Person person in people)
        {
            person.Print();
        }
        Console.WriteLine();
        List<Staff> Employees = new List<Staff>();
        foreach (var staff in people)
        {
            if (staff is Staff employee )
            {
                Employees.Add(employee);
            }    
        }
        Employees.Sort((w1, w2) => w2.Salary.CompareTo(w1.Salary));
        foreach (Staff person in Employees)
        {
            person.Print();
        }
    }
}