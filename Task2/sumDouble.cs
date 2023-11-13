class Task
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int sum, first, second;
        first = (int)(number * 10) % 10;
        second = (int)(number * 100) % 10;
        sum = first + second;
        Console.WriteLine(sum);
    }
}