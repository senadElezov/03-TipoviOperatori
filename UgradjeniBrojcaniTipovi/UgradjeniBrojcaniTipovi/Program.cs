using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int veliki = int.MaxValue;
            veliki++;
            Console.WriteLine(veliki);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            double a = 3.2;
            Console.WriteLine(a / 0);
            Console.WriteLine(0.0 / 0.0);
            double db = 5.0;
            int c =(int) db;
            double d = (double)decimal.MaxValue;
            Console.WriteLine(d);
            Console.WriteLine(decimal.MinValue);
            Console.ReadKey();
            float f1 = 1.23456789F;
        }
    }
}
