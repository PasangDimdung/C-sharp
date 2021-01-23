using System;


interface ICustomer1
{
    void Print1();
}

//Customer 2 interface  inherits customer 1 interface
interface ICustomer2 : ICustomer1
{
    void Print2();
}

//Customer inherits only customer 2 interface but due to inheritance chain it must provide implementation to all interface members 
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
        Customer C1 = new Customer();
        C1.Print1();
        C1.Print2();
    }
}