using Graphic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var data = new GraphicData()
            {
                X1 = -5,
                X2 = 5,
                PointCount = 200,

                Fn = Fn,
            };

            var mainForm = new Main(data);

            Application.Run(mainForm);
        }

        public static double Func1(double x)
        {
            return x * x + 2 * x - 3;
        }

        public static double Func2(double x)
        {
            return Math.Sin(x);
        }

        public static double Func3(double x)
        {
            // x1<x2
            // 3x1<3x2
            // -3x1>-3x2 !!!
            // x1^3<x2^3

            // x1<x2
            // x1^4<x2^4 , x>=0

            return 0 * (x * x * x * x) + 1 * (x * x * x) + 0 * (x * x) - 3 * (x) + 0 * (1);
        }

        public static double Fn(double x)
        {
            int[] polinom = new int[] { 0, -3, 0, -1, 0 };

            double sum = 0;
            double xN = 1;
            foreach (var value in polinom)
            {
                sum += value * xN;
                xN = xN * x;
            }

            return sum;
        }
    }
}
