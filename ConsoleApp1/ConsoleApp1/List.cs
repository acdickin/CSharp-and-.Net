using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<String>;
            customers.Add("Kim");
            customers.Add("Jim");
            customers.Add("Lim");
            Console.WriteLine(customers.Count);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer)

            }
            Console.WriteLine(customers[1]);

        }
    }
}
