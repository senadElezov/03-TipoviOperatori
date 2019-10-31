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

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            //double d = null;
            Nullable<int> nulabilniInt = null;
            Console.WriteLine(nulabilniInt);
            nulabilniInt = 22;
            Console.WriteLine(nulabilniInt);

            Console.ReadKey();
        }
    }
}
