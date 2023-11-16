class Each
{
    public static void Main()
    {
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++, i++ )
        {
            Console.Write(str[i] + " ");
        }
    }
}