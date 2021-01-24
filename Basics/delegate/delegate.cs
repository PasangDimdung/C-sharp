using System;

/* Delegate is type safe function pointer. Signature of delegate must match signature of function. 
Here both have return type void and pass string as parameter */
public delegate void HelloFunctionDelegate(string Message);
class Program
{
    public static void Main()
    {
        //We create instance of delegate like class and pass in function name as parameter
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);

        del("Hello from Delegate");
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}