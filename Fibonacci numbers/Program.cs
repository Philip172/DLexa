using System;

namespace Fibonacci_numbers
{
    class Program
    {
        //вычислить 15е число Фиббоначи
        static void Main(string[] args)
        {
            int a = 1, prea=1;

            Console.WriteLine("15е число Фиббоначи:");
            for(var i = 1; i<=15; i++)
            {
                a += prea;
                prea = a;
                //Console.WriteLine($"число {i}: {a}");
            }
            Console.Write(a);
            Console.ReadKey();
        }
    }
}
