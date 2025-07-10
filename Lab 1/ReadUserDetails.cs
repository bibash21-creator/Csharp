using System;

class ReadUserDetails
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);

        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }
}