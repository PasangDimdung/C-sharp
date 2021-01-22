using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    //Virtual keyword allows this method to be overriden
    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    //Override keyword overides the base class method
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Full Timer");
    }
}

public class PartTimeEmployee : Employee
{
    //New keyword hides the base class method 
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Part Timer");
    }
}

class Program
{
    public static void Main()
    {
        
        Employee e1 = new FullTimeEmployee();
        //Invokes the overriden method in the child class and prints FN LN - Full Timer
        e1.PrintFullName();

        Employee e2 = new PartTimeEmployee();
        //Invokes the hidden method in the base class  and prints FN LN only
        e2.PrintFullName();

    }

}