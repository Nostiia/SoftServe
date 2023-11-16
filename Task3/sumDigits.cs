class Sum
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int Summ = 0;

        for (int i = 10; number != 0; )
        {
            int digits = number % i;
            number = number / i;
            Summ += digits;
           
        }
        Console.WriteLine(Summ);
    }
}