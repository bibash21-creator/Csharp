using System;

public class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee: {Name}, ID: {ID}");
    }
}

public class Manager : Employee
{
    public string Department { get; set; }

    //Use of base keyword to call base class constructor
    public Manager(string name, int id, string department) : base(name, id)
    {
        Department = department;
    }

    //Override base class method
    public override void DisplayDetails()
    {
        Console.WriteLine($"Manger: {Name}, ID: {ID}, Department: {Department}");
    }

    //Methhod hiding using 'new' keyword
    public new void Displaydetails(bool verbose)
    {
        if (verbose)
            Console.WriteLine($"");
        else
            Console.WriteLine($"Manager: {Name}");

    }
}

public class Program
{
    public static void Main()
    {
        Manager mgr = new Manager("Bibash", 1001, "Finance");

        Console.WriteLine("Calling DisplayDetails using Manager reference:");
        mgr.DisplayDetails();   //Calls overidden method
        mgr.DisplayDetails(true);   //Calls hidden method

        Employee empRef = mgr;
        Console.WriteLine("\n Calling DisplayDetaisl using Employee reference:");

        //Calls overriden method
        empRef.DisplayDetails();
    }
}

