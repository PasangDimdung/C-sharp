using System;

class Program
{
    public static void Main()
    {
        Program.Add( 2.24F, 5 );
    }

    //Method overloading
    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

     public static void Add(float FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

}