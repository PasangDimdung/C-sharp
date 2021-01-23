using System;


interface ICustomer
{
    void Print();
}

interface I2
{
    void I2Method();
}

//A class can inherit multiple interfaces
public class Customer : ICustomer, I2
{
    public void Print()
    {
        Console.WriteLine("This is interface print method");
    }

    public void I2Method()
    {
        Console.WriteLine("This is I2 method");
    }
}
class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();
        C1.I2Method();
    }
}