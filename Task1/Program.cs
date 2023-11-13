class Tasks
{
    public static void Main(string[] args)
    {
        int a, b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum: {0}{4}Sub: {1}{4}Multi: {2}{4}Div: {3}", a+b,a-b,a*b,a/b,Environment.NewLine);
    }
}
