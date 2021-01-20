using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            //Create instance of class Program
            Program p = new Program();

            p.EvenNumbers();
        }

        //Instance method
        public void EvenNumbers() 
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);

                Start = Start + 2;
            }
        }
    }
}
