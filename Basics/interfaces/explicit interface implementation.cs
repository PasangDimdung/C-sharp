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
    //We are explicitly implementing the interface members because both interfaces have same method names

    //Access modifiers are not allowed in explicit implementation.
    void ICustomer1.Print()
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
       //When we explicitly implement interface members, it cannot be accessed through class reference variable
        Customer C = new Customer();

        //We access only interface members through Iterface reference variable
        ((ICustomer1)C).Print();
        ((ICustomer2)C).Print();
    }
}