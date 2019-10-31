using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine(a / b);

            double d = 3.14;

            Console.WriteLine(a + d);

            a = (int)(a + d);

            Console.ReadKey();
        }
    }
}
