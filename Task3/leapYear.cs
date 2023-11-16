class Year
{
    public static void Main()
    {
        Console.WriteLine("Give a year`s number");
        int number = int.Parse(Console.ReadLine());
        if ((number % 4 == 0 && number % 100 != 0) || number % 400 == 0)
        {
            Console.WriteLine("It was/is/will/ a leap year");
        }
        else
        {
            Console.WriteLine("It was/is/will not a leap year");
        }
    }
}