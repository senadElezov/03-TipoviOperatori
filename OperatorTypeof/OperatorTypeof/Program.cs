using System;
using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(System.DateTime);

            // TODO:120 Napisati petlju koja će za svaki član kojeg vrati metoda t.GetMembers ispisati ime tog člana.

            // TODO:121 Dodati u petlji i ispis tipa svakog člana.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }


            // TODO:122 Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.

            // TODO:123 Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).

            // TODO:124 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.ToString()} {mi.Name}");
                foreach (var parameter in mi.GetParameters())
                {
                    Console.WriteLine($"  {parameter.ParameterType.ToString()} {parameter.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
