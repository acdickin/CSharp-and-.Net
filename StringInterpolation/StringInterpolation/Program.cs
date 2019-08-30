using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1, y = 2 };
            // rewrites the string 4 times
            Console.WriteLine("x " + point.x + " y " + point.y);
            // hard to move it around
            Console.WriteLine("x {0} y {1}", point.x, point.y);
            // less memeory issues
            Console.WriteLine($"x {point.x} y {point.y}");

            var floats = new { x = 1.23432, y = 1.43352 };
            Console.WriteLine($"x {floats.x} y {floats.y, 10:N1}");
        }
    }
}
