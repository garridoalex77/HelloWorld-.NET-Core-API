using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new HelloWorld.HelloService();
            var name = service.GetWorldName("World2 !");
            Console.WriteLine(name);
        }
    }
}
