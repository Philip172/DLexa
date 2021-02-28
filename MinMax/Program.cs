using System;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // написать программу, которая найде min и max в массиве
            // int i = 0;
            // int[] a = new[] { -1, 2, -3, 10, 7, 3, -5, 8, -10, -3, 2, -7 };
            int[] a = null;

            if (a != null && a.Length > 0)
            {
                // todo
                int min = a[0];
                int max = a[0];

                for (var i = 0; i < a.Length; i++)
                {
                    if (min > a[i])
                        min = a[i];

                    if (max < a[i])
                        max = a[i];
                }

                Console.WriteLine($"min={min}\nmax={max}");
                // найти и вывести в консоль
            }
            else
            {
                Console.WriteLine($"массив пустой");
            }

            Console.ReadKey();
        }
    }
}
