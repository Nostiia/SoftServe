using System.Collections.Generic;

class WorkWithExceptions
{
    static  void Div (int a, int b)
    {
        int c = 0;
        try
        {
            c = a / b;
            Console.WriteLine(c);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Catched");
        }
    }
    public static void Main()
    {
        try
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int a = Int32.Parse(first);
            int b = Int32.Parse(second);
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }
            Div(a, b);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please, enter an integer value");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}