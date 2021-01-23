using System;


interface ICustomer
{
    //Access modifier is pubic by default in interfaces. Interface contains only declaration, no definition(implementation)
    void Print();
}
public class Customer : ICustomer
{
    public void Print()
    {
        Console.WriteLine("This is interface print method");
    }
}
class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();
    }
}