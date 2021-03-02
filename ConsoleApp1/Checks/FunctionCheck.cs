using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Checks
{
    class FunctionCheck
    {
        // по задаче 10.18
        public void checking()
        {
            // y = x^3 + 3x;
            var polinom = new int[] 
            { 
                0, 
                1, // x
                0, // x^2
                0, // x^3
                2  // x^4
            };

            double f(double x)
            {
                double sum = 0;
                double xN = 1;
                foreach (var value in polinom)
                {
                    sum += value * xN;
                    xN = xN * x;
                }

                return sum;
            }

            int all = 0;
            int all2 = 0;
            foreach (var v in polinom)
            {
                if (v >= 0)
                {
                    all++;
                }
                if(v<=0)
                {
                    all2++;
                }
            }

            var isUp = true;
            var isDown = true;
            foreach(var v in polinom)
            {
                if (v < 0)
                {
                    isUp = false;
                }
                if (v > 0)
                {
                    isDown = false;
                }
            }

            // если есть четные степени, то это верно только для x>=0
            if (isUp || isDown)
            {
                Console.WriteLine("Функция монотонна");
                
                int x1 = 2, x2 = 5;
                int x;

                var x1_res = f(x1);

                var x2_res = f(x2);

                //if (a == -b || a == b)
                {



                    if (x1_res < x2_res) Console.WriteLine("f возрастает");
                    else  Console.WriteLine("f убывает");
                }
                //else { Console.WriteLine("функция не монотонна"); }
            }
            else 
            {
                Console.WriteLine("Функция не монотонна");
                Console.WriteLine("Функция не возрастает и не убывает");
            }
        }

    }
}
