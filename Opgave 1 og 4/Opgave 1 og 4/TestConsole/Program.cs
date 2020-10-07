using System;
using FanLibrary;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FanOutput Fantest = new FanOutput("Ti",15,40);
            FanOutput Fantest2 = new FanOutput("Ti", 15, 40);


            Console.WriteLine(Fantest.Id);
            Console.WriteLine(Fantest2.Id);

            Console.ReadKey();

            
        }
    }
}
