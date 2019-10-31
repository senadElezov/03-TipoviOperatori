using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            //običniDuplić = null;

            Nullable<int> nulabilniInt = null;
            Console.WriteLine(nulabilniInt);

            nulabilniInt = 314;
            Console.WriteLine(nulabilniInt);

            Console.ReadKey();
        }
    }
}
