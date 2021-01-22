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


    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Part Timer");
    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Temporary");
    }
}
class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee();
        employees[1] = new FullTimeEmployee();
        employees[2] = new PartTimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach (Employee e in employees)
        {
            //Invokes derived class methods using base class reference variable during runtime --Polymorphism
            e.PrintFullName();
        }

    }

}