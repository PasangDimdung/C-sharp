using System;

class Customer
{
    //Fields
    string _firstName;
    string _lastName;

    //Constructor- has same name as class and has no return type
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full name is {0}", this._firstName + " " + this._lastName);
    }

}
class Program
{
    public static void Main()
    {
        Customer C1 = new Customer("Pasang", "Dimdung");

        C1.PrintFullName();
    }
 
}