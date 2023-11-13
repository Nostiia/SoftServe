class Task
{
    public static void Main(string[] args)
    {
        int a, b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        bool reza = a >= 0;
        bool rezb = b >= 0;
        if(reza && rezb)
        {
            Console.WriteLine("Both are positive");
            return;
        }
        Console.WriteLine("You put negative number");
    }
}