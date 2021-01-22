using System;

class Student
{
    private int _id;
    private string _Name;
    private int _passMarks = 32;

    //Use C# properties to encapsulate and protect fields
    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Id cannot be negative");
            }

            this._id = value;
        }

        get
        {
            return this._id;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be empty or null");
            }
            this._Name = value;
        }

        get
        {
            return this._Name;
        }
    }

    public int PassMarks
    {
        get
        {
            return this._passMarks;
        }
    }


}
class Program
{
    public static void Main()
    {
        Student S = new Student();

        S.Id = 101;
        S.Name = "Pasang";

        Console.WriteLine("Student id is {0}", S.Id);
        Console.WriteLine("Student name is {0}", S.Name);
        Console.WriteLine("Pass marks  is {0}", S.PassMarks);

    }
}