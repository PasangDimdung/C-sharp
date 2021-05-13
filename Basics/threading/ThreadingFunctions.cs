using System;
using System.Threading;

namespace ThreadingFunctions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Main started");

            Thread T1 = new Thread(Thread1Function);
            T1.Start();

            Thread T2 = new Thread(Thread2Function);
            T2.Start();

            //forcing main thread to wait until thread 1 and 2 complete
            T1.Join();
            Console.WriteLine("Thread 1 completed");

            //here main thread is going to wait for 1000ms until thread 2 returns
            if (T2.Join(1000))
            {
                Console.WriteLine("Thread 2 completed");
            }
            else
            {
                Console.WriteLine("Thread 2 hasn't completed in 1 second");
            };

            for (int i = 1; i <= 10; i++)
            {
                if (T2.IsAlive)
                {
                    Console.WriteLine("Thread 2 is still doing its job...");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread 2 completed");
                    break;
                }
            }
            

            Console.WriteLine("Main completed");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread 1 started");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread 2 started");
            Thread.Sleep(5000);
        }
    }
}
