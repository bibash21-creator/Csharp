using System;

class EvenOddChecker
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }
}