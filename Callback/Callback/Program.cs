using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Callback
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();
        }
        static void Download()
        {
            Network.Download((msg) => Console.WriteLine($"Download {msg}"));
        }
    }
    class Network
    {
        static public void Download(Action<String> callback)
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                callback("completed");
                });
        }
    }
}
