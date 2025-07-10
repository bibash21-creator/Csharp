using System;

class MenuSwitchCase
{
    static void Main()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Greet");
        Console.WriteLine("2. Farewell");
        Console.WriteLine("3. Exit");
        Console.Write("Enter your choice (1-3): ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("Hello! Hope you have a great day.");
                break;
            case "2":
                Console.WriteLine("Goodbye! Take care.");
                break;
            case "3":
                Console.WriteLine("Exiting the program.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}