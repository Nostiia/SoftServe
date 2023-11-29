using System.IO;
using System.Collections.Generic;
class FilesBehavior
{
    public static void Main()
    {
        Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
        using (StreamReader reader = new StreamReader("phones.txt", System.Text.Encoding.Default))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('-');
                if (parts.Length == 2)
                {
                    PhoneBook.Add(parts[0].Trim(), parts[1].Trim());
                }
            }
        }
        using (StreamWriter writer = new StreamWriter("onlyPhones.txt", true, System.Text.Encoding.Default))
        {
            foreach (string phones in PhoneBook.Values)
            {
                writer.WriteLine(phones);
            }
        }
        using (StreamReader forNames = new StreamReader("names.txt", System.Text.Encoding.Default))
        {
            string name;
            while ((name = forNames.ReadLine()) != null)
            {
                foreach (KeyValuePair<string, string> person in PhoneBook)
                {
                    string nameBook = person.Key;
                    if (nameBook == name)
                    {
                        Console.WriteLine("The phone number of John Doe is: {0}", person.Value);
                    }
                    else
                    {
                        Console.WriteLine("Name {0} was not found in phone book.", person.Key);
                    }
                }
            }
        }
        using (StreamWriter writer1 = new StreamWriter("newPhones.txt", true, System.Text.Encoding.Default))
        {
            foreach (KeyValuePair<string, string> phones in PhoneBook)
            {
                if (phones.Value.Length == 11)
                {
                    writer1.Write(phones.Key + " - " + "+38");

                    for (int i = 1; i < 11; i++)
                    {
                        writer1.Write(phones.Value[i]);
                    }
                    writer1.WriteLine();
                }
                else if (phones.Value.Length == 13)
                {
                    writer1.WriteLine(phones);
                }
            }
        }
    }
}