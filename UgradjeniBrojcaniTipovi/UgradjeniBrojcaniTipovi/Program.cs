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
            Console.WriteLine(++veliki);

            int mali = int.MinValue;
            Console.WriteLine(--mali);

            //Console.WriteLine(mali / 0);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            double a = 3.0;
            Console.WriteLine(a / 0);

            a = 0.0;
            Console.WriteLine(a / 0);

            double b = 5.0;

            int c = (int)b;

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            double d = (double)decimal.MaxValue;

            double f1 = 1.23456789e23;
            double f2 = 1.23456788e23;

            Console.WriteLine(f1 - f2);

            Console.ReadKey();
        }
    }
}
