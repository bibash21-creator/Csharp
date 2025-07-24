/* 1 .Student Management System - Part 1 (Constructors, Properties, Arrays)

○ Create a Student class with the following properties: StudentID (int), FirstName
(string), LastName (string), and EnrollmentDate (DateTime).
○ Implement two constructors:
■ A default constructor that initializes StudentID to 0, FirstName and
LastName to empty strings, and EnrollmentDate to the current date.
■ A parameterized constructor that takes StudentID, FirstName, LastName,
and EnrollmentDate as arguments and initializes the properties.
○ In your Main method, create two objects of the Student class calling default and
parameterized constructor.*/


using System;

public class Student
{
    //Properties
    public int StudentID { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    //Default constructor
    public Student()
    {
        StudentID = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
        EnrollmentDate = DateTime.Now;

    }

    //Parameterized constructor
    public Student(int studentid, string firstName, string lastName, DateTime enrollmentDate)
    {
        StudentId = studentid;
        FirstName = firstName;
        LastName = lastName;
        EnrollmentDate = enrollmentDate;

    }
}

public class Program
{
    public static vod Main()
    {
        //Creating student with default constructor
        Student student1 = new Student();

        Console.WriteLine($"Default Constructor:\nID: {student1.StudentID}, Name:{student1.FirstName} {student1.LastName}, EnrollmentDate: {student1.EnrollmentDate}");

        //Creating student with parameterized constructor
        Student student2 = new Student(1001, "Bibash", "Poudel", new DateTime(2025, 7, 23));
        Console.WriteLine($"Parameterized Constructor:\n ID:{student2.StudentID}, Name:{student2.FirstName} {student2.LastName}, EnrollmentDate: {student2.EnrollmentDate}");
    }
}

