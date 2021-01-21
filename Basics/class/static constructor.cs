using System;

class Circle
{

    //Static keyword is used to make class member static. It is made public because Class Program can access it 
    public static float _PI;
    int _Radius;

    //Static constructor are called before instance construtor and even before any static fields
    static Circle()
    {
        Console.WriteLine("Static constructor called..");
        Circle._PI = 3.141F;
    }
    public Circle(int Radius)
    {
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        return Circle._PI * this._Radius * this._Radius;
    }

}
class Program
{
    public static void Main()
    {
        Console.WriteLine(Circle._PI);
    }

}