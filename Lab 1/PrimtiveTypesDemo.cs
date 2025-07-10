using System;

class PrimitiveTypesDemo
{
    static void Main()
    {
        int myInt = 42;
        double myDouble = 3.14;
        char myChar = 'A';
        bool myBool = true;
        string myString = "Netcentric";

        // Using string concatenation
        Console.WriteLine("Int: " + myInt + ", Double: " + myDouble + ", Char: " + myChar + ", Bool: " + myBool + ", String: " + myString);

        // Using string interpolation
        Console.WriteLine($"Int: {myInt}, Double: {myDouble}, Char: {myChar}, Bool: {myBool}, String: {myString}");
    }
}