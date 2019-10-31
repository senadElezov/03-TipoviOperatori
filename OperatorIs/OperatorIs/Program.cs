using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Console.WriteLine(osoba is Osoba);
            Console.WriteLine(osoba is Osoba);

            Osoba janko = new Student();
            Console.WriteLine(janko is Osoba);
            Console.WriteLine(janko is Osoba);

            Osoba ivan = new Student();
            Console.WriteLine(ivan is Osoba);
            Console.WriteLine(ivan is Osoba);

            Console.ReadKey();
        }
    }
}
