using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    class MyResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing our resource");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
        using (var resource = new MyResource())
            {
                Console.WriteLine("Using my resouce");
            }
            Console.ReadLine();
        }
    }
}
