using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(new ThreadStart(Work));
                myThread.Start();
                Task.Run(() =>
                {
                    // Created at diffrent times and reuses Threads
                    Console.WriteLine("starting task in thread: " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    Console.WriteLine("Task complete");
                });
            }
            Console.ReadLine();
        }
        static void Work()
        {
            // All start at the same time
            Console.WriteLine("starting in thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Work complete");

        } 
    }
}
