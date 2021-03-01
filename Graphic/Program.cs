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

                Fn = Func2
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
    }
}
