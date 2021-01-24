using System;

class A
{
    public virtual void Print()
    {
        Console.WriteLine("Print");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("Class B Print Method");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("Class C Print Method");
    }
}

//Multiple class inheritance is not possible in C#
class D : A, B
{

}


class Program
{
    public static void Main()
    {
        D C = new D();

        /*When D calls a method, B and C have overriden the method differently then from which class does it inherit?
        This ambiguity is called Diamond Problem. */
        D.Print();
    }
}