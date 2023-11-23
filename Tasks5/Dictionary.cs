using System;

class Meeting
{
    public static void Main()
    {
        Dictionary<uint, string> people = new Dictionary<uint, string>();
        Initialize(people);
        Console.WriteLine();
        FindPerson(people);
        
        
    }
    public static Dictionary<uint, string> Initialize(Dictionary<uint, string> people)
    {
        uint key;
        string name;
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Please, enter Id");
            key = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter name");
            name = Console.ReadLine();
            people.Add(key, name);
        }
        return people;
    }

    public static void FindPerson(Dictionary<uint, string> people)
    {
        Console.WriteLine("Enter ID: ");
        uint key = uint.Parse(Console.ReadLine());
        int id = 0;
        foreach (KeyValuePair<uint, string> person in people)
        {
            id++;
            if (key == person.Key)
            {
                Console.WriteLine(person.Value);
                id--;
            }
        }
        if (id == 7)
        {
            Console.WriteLine("not found");
        }
    }

    public void Print(Dictionary<uint, string> people)
    {
        foreach (KeyValuePair<uint, string> person in people)
        {
            Console.WriteLine("ID: {0}; Name: {1}", person.Key, person.Value);
        }
    }

}