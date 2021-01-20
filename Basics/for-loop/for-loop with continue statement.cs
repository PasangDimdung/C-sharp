using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            for(int i = 1; i <= 20; i++)
            {
                //If remainder becomes 1 then it skips rest of the part & continue from the beginning
                if(i % 2 == 1)
                    continue;

                Console.WriteLine(i);
            }

        }
    }
}
