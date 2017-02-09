using System;
using Nancy.Hosting.Self;

namespace FizzBuzzSelfHostWeb
{
    class Program
    {
        static void Main()
        {
            using (var host = new NancyHost(new Uri("http://localhost:1234")))
            {
                host.Start();
                Console.WriteLine("Running on http://localhost:1234");
                Console.ReadLine();
            }
        }
    }
}
