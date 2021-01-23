using System;

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
}
class Program
{
    public static void Main()
    {
        /* Int is struct which means it is of value type. When you copy a struct into another struct, 
        a new copy of that struct is created and modification on one struct will not affect values contained 
        by other struct. */
        int i = 10;
        int j = 20;
        j = j + 1;

        Console.WriteLine("i = {0} && j = {1}", i, j);


        Customer C1 = new Customer();

        C1.ID = 101;
        C1.Name = "Pasang";

        /* Class is of reference type. So when you copy a class into another class class, you get copy of reference
        variable. Both reference var point to same object on the heap. So, operations on one variable will affect
        the value contained by the other reference variable. */
        Customer C2 = C1;
        C2.Name = "Mark";

        Console.WriteLine("C1 Name = {0} and C2 Name = {1}", C1.Name, C2.Name);

    }
}