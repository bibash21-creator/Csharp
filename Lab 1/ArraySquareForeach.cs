using System;

class ArraySquaresForeach
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };

        Console.WriteLine("Squares of array elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine($"{num} squared is {num * num}");
        }
    }
}