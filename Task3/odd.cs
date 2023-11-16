class odd
{
    public static void Main()
    {
        Console.WriteLine("Enter any number:");
        int number = int.Parse(Console.ReadLine());
        bool rez = true;
        for (int i = 10; number != 0 && rez == true; )
        {
            int digits = number % i;
            number = number / i;
            rez = (digits % 2 != 0) ? true : false;
            
        }
        Console.WriteLine(rez ? "Only odd" : "Not only");
    }
}