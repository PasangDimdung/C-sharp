using System;

interface IA
{
    void AMethod();
}
class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}

interface IB
{
    void BMethod();
}
class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}

/*Class AB inherits both interfaces and creates object so class AB can use the their methods. 
When we invoke interface methods in class AB's method, we don't have to provide implementation 
because its already implemented by Class A and B. */
class AB : IA, IB
{
    A a = new A();
    B b = new B();
    public void AMethod()
    {
        a.AMethod();
    }
    public void BMethod()
    {
        b.BMethod();
    }
}

class Program
{
    public static void Main()
    {
        //We achieved multiple class inheritance using interfaces
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}