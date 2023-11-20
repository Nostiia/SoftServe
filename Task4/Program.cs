using Microsoft.VisualBasic;

namespace PersonTask
{
    class Program
    {
        static void Main()
        {
            Person[] people = new Person[6];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = Person.Input();
            }
            int[] age = new int[people.Length];
            for (int i = 0;i < people.Length; i++)
            {
                age[i] = Person.Age(people[i].BirthYear);
                Console.WriteLine($"{people[i].Name} is {age[i]} years old.");
            }
            Console.WriteLine("Information about all persons:");
            for(int i = 0; i < people.Length; i++)
            {
                if (age[i] < 16)
                {
                    people[i].ChangeName(people[i].Name);
                }
                Console.WriteLine(people[i].ToString());
            }
            Console.WriteLine("Persons with the same names:");
            for (int i = 0; i < people.Length ; i++)
            {
                for (int j = i+1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine(people[i].ToString());
                        Console.WriteLine(people[j].ToString());
                    }
                }
            }
        }
    }
}