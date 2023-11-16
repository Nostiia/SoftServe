using System.Diagnostics.CodeAnalysis;

class Positive
{
    public static void Main()
    {
        int[] numbers = { 3, 56, 3, 2, 4, 7, 4, -1, 76, -4, 3, 2 };
        int length = 0;
        float sum = 0;
        for (int i = 0; i < numbers.Length && numbers[i] > 0; i++)
        {
            length++;
        }
        int[] positive = new int[length];
        for (int i = 0; i < length; i++)
        {
            positive[i] = numbers[i] ;
            sum += positive[i];
        }
        sum = sum / length ;
        Console.WriteLine(sum);
    }
}