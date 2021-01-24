using System;

interface ICustomer1
{
    void Print();
}

interface ICustomer2
{
    void Print();
}

public class Customer : ICustomer1, ICustomer2
{

    //If you want to make your method default. Implement it normally and other methods explicitly
    public void Print()
    {
        Console.WriteLine("Interface 1 Print method");
    }

    void ICustomer2.Print()
    {
        Console.WriteLine("Interface 2 Print method");
    }
}
class Program
{
    public static void Main()
    {
        Customer C = new Customer();

        //Accessing default interface method
        C.Print();
    }
}