using System;

class NumberSquares
{
    static void Main()
    {
        Console.WriteLine("Number\tSquare");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}\t{i * i}");
        }
    }
}