using System;

class Circle
{

    //Static keyword is used to make class member static
    static float _PI;
    int _Radius;

    //Static constructor- it doesnot make copy while creating class object in another class
    static Circle()
    {
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
        Circle C1 = new Circle(4);

        float Area = C1.CalculateArea();

        Console.WriteLine("Area = {0}", Area);
    }

}