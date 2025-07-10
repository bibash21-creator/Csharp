using System;
using System.Collections.Generic;

class StudentList
{
    static void Main()
    {
        List<string> students = new List<string>();
        students.Add("Alice");
        students.Add("Bob");
        students.Add("Charlie");

        Console.WriteLine("Student names:");
        foreach (string name in students)
        {
            Console.WriteLine(name);
        }
    }
}