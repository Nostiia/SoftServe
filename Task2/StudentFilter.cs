struct Student
{
    public string lastName;
    public int groupNumber;
}
class Groups
{
    public static void Main()
    {
        Student[] group = new Student[5];
        for (int i = 0; i < group.Length; i++)
        {
            Student a;
            a.lastName=Console.ReadLine();
            a.groupNumber = int.Parse(Console.ReadLine());
            group[i] = a;           
        }
        for (int i = 0;i < group.Length; i++)
        {
            Console.Write(group[i].lastName + "  ");
            Console.WriteLine(group[i].groupNumber);
        }
        Console.WriteLine("Give a group number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Give a first letter: ");
        char letter = char.Parse(Console.ReadLine());
        for (int i = 0; i < group.Length; i++)
        {
            if (group[i].groupNumber == number && group[i].lastName[0] == letter)
            {
                Console.WriteLine(group[i].lastName );
            }
        }
    }
   
}