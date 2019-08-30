using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> config = new Dictionary<String, String>();
            config.Add("resoultion", "1920x1080");
            config.Add("title", "Website");
            Console.WriteLine(config["title"]);
            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }
        }
    }
}
