using System;

namespace AbstractClasses
{
    //abstract classes can only be used as base class
    public abstract class Print
    {
        //abstract classes may contain abstract members. cannot have implementation
        public abstract void  PrintFullName();

        //abstract classes may contain non-abstract members
        public void PrintRollNo()
        {
            Console.WriteLine("RollNo");
        }
    }
    class Program : Print
    {
        static void Main()
        {
            Program P = new Program();
            P.PrintFullName();
            P.PrintRollNo();
        }

        public override void PrintFullName()
        {
            Console.WriteLine("FullName");
        }
    }
}
