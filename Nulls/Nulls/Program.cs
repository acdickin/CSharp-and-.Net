using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulls
{
    class Program
    {
        static void Main(string[] args)
        {
            //int? s = null; // 1  "hello";
            //var s2 = s ?? 2;
            //Console.WriteLine(s2);
            Person person = null; //new Person() { Name = "tim" }; // what if this was null
            //if(person != null)
            //{
            //    Console.WriteLine(person.name)
            //}
            Console.WriteLine(person?.Name ?? "not set");
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
