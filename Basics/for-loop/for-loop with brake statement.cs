using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);

                if(i == 10)
                    break;
            }

        }
    }
}
