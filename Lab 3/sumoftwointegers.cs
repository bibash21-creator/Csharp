using System;

//Declare a delegate type
public delegate int SumDelegate(int a, int b);

public class Calculator
{
    //Method that matches the delegate signature
    public int Add(int x, int y)
    {
        return x + y;
    }
}

public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();

        //Create delegate instance pointing to Add method
        SumDelegate sum = new SumDelegate(calc.Add);

        //Use the delegate to call the method
        int result = sum(10, 20);

        Console.WriteLine("The sum is:", +result);
    }
}