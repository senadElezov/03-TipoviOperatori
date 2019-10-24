using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

           
            int a = int.MaxValue;
            Console.WriteLine(++a);
         
            int b = int.MinValue;
            Console.WriteLine(--b);
        
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
           
            double c = 2.3;
            Console.WriteLine(c / 0);
            c = -2.3;
            Console.WriteLine(c / 0);
          
            double d = 0;
            Console.WriteLine(d / 0);
         
            double e = 5;
            Console.WriteLine(e);
            
            int f = 5; ;
            //int g= (double.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            double l = (double.MaxValue);
            Console.WriteLine(l);

            Console.ReadKey();
        }
    }
}
