using ConsoleApp1.DataModel;
using ConsoleApp1.Checks;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var vars = new Roots()
            {
                X1 = 2,
                X2 = 5
            };

            var functionCheck = new FunctionCheck();
            functionCheck.checking();

            Console.ReadKey();
        }
    }
}
