using System;
using PATA=  ProjectA.TeamA;
using PATB = ProjectA.TeamB;

class Program
{
    public static void Main()
    {
        PATA.ClassA.Print();
        PATB.ClassA.Print();
    }
}

//Namespace organizes program and asist in avoiding name clashes
namespace ProjectA 
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method");
            }
        }
    }
}

namespace ProjectA 
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print method");
            }
        }
    }
}
