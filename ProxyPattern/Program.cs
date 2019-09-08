using ProxyPattern.Concrete;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Execute();

            Console.ReadKey();
        }
    }
}
