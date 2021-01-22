using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee: Employee
{
    public int YearlyRate;
}

public class PartTimeEmployee: Employee
{

    //This method hides the base class PrintFullName method. We use new keyword to intensionally hide method of base class
     public new  void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Part Timer");
    }
}

public class A : PartTimeEmployee
{

}
class Program
{
    public static void Main()
    {
        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Bishal";
        PTE.LastName = "Dimdung";

        //If you want to use derived class method
        PTE.PrintFullName();

        //If you want to use base class method we type cast operator
        ((Employee)PTE).PrintFullName();
    }

}