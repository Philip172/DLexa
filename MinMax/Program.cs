﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // написать программу, которая найде min и max в массиве
            // int i = 0;
            int[] a = new[] { -1, 2, -3, 10, 7, 3, -5, 8, -10, -3, 2, -7 };
            var b = new List<int>(a);

            // int[] a = null;

            if (a != null && a.Length > 0)
            {
                // var min1 = a.Min();
                // var max2 = a.Max();

                // todo
                int min = a[0];
                int max = a[0];

                //for (int i = 0; i < a.Length; i++)
                //{
                //    if (min > a[i])
                //        min = a[i];

                //    if (max < a[i])
                //        max = a[i];
                //}

                
                while(b.Count > 0)
                {
                    if (min > b[0])
                        min = b[0];

                    if (max < b[0])
                        max = b[0];

                    b.RemoveAt(0);
                }

                //foreach(var item in a)
                //{
                //    if (min > item)
                //        min = item;

                //    if (max < item)
                //        max = item;
                //}

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
