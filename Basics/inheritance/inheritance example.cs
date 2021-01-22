using System.Reflection.Emit;
using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent class construtor called");
    }

    //Overloading constructor
       public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    //We use base() to call the constructor we want
    public ChildClass(): base("Hello, I am controlling base class constructor")
    {
        Console.WriteLine("Child class constructor called");
    }
}

class Program
{
    public static void Main()
    {
        //Parent class are automatically instantiated before derived class. We don't have to explicitly create an object of base class
        ChildClass CC = new ChildClass();
    }


}