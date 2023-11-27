class WorkWithNumbers
{
    public static int ReadNumber(int start, int end)
    {
        try
        {
            string num = Console.ReadLine();
            int number = int.Parse(num);
            if (number > start && number < end)
            {
                return number;
            }
        }
        
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return 0;
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("End: ");
            int end = int.Parse(Console.ReadLine());
            int[] array = new int[10];
            Console.WriteLine($"Enter 1 number ");
            array[0] = ReadNumber(start, end);
            for (int i = 1; i < array.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Enter {i + 1} number ");
                    array[i] = ReadNumber(start, end);
                    if (array[i] < array[i - 1]) { throw new Exception("Wrong value"); }
                    Console.WriteLine(array[9]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }


            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please, enter an integer value");
        }
        
    }
}