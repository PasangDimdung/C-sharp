using System;

//Employee class is base class which contains common fields
public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

//FullTimeEmployee is derived class which inheritates Employee class
public class FullTimeEmployee: Employee
{
    public int YearlyRate;
}

public class PartTimeEmployee: Employee
{
    public int HourlyRate;
}
class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Pasang";
        FTE.LastName = "Dimdung";
        FTE.YearlyRate = 40000000;
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Bishal";
        PTE.LastName = "Dimdung";
        PTE.HourlyRate = 20000;
        PTE.PrintFullName();
    }
    

}