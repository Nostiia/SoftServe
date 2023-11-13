class Task  
{
    public enum Goodness {morning, afternoon, evening, night};
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine((h >= 6 && h < 12) ? $"Good {Goodness.morning}" : 
                          (h >= 12 && h < 16) ? $"Good {Goodness.afternoon}" :
                          (h >= 16 && h < 20) ? $"Good {Goodness.evening}" :
                          ((h >= 20 && h < 24) || (h >= 1 && h < 6)) ? $"Good {Goodness.night}" : "You lied.");
    }
}