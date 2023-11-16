class Whats
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int rez = 0;
        for (int i = a; i <= b; i++)
        {
            if ( i % 3 == 0)
            {
                rez++;
            }
        }
        Console.WriteLine(rez);
    }
}