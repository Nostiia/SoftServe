class WorkWithNumbers
{
    public static int ReadNumber(int start, int end, int number)
    {
        if (number > start && number < end)
        {
            return number;
        }
        return 0;
    }
    public static void Main()
    {
        int start = 1;
        int end = 100;
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                string num = Console.ReadLine();
                int number = int.Parse(num);
                array[i] = ReadNumber(start, end, number);
                if (!Int32.TryParse(num, out _))
                {
                    throw new Exception("Please, enter an integer value");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        
        for (int i = 1; i < array.Length; i++)
        {
            try
            {
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
}