﻿class Task
{
    public static void Main()
    {
        int day, month;
        day = int.Parse(Console.ReadLine());
        month = int.Parse(Console.ReadLine());
        Console.WriteLine((day > 0 && day <= 30 && month > 0 && month <= 12) ? $"It could be day and month: {day}/{month}": "It couldn`t") ;
    }
}