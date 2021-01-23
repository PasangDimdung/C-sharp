using System;


interface ICustomer1
{
    void Print1();
}

interface ICustomer2 : ICustomer1
{
    void Print2();
}

public class Customer : ICustomer2
{
    public void Print1()
    {
        Console.WriteLine("Print 1 method");
    }

    public void Print2()
    {
        Console.WriteLine("Print 2 method");
    }
}
class Program
{
    public static void Main()
    {
        /* We cannot create instance of an interface because interface only have declarations which makes no sense
        to create an object of an interface. 
        But an interface reference variable can point to a derived class object. */
        ICustomer1 C1 = new Customer();
        C1.Print1();
    }
}