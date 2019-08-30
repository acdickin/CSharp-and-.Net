using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();

        }
        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("Http://rouxacademy.com");
            Console.WriteLine("Download Complete " + data);
        }
    }
}

