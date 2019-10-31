using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba
    {
        public string DajOib()
        {
            return "0123456789";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TODO:070 Dodajte pozive svih mogućih metoda nad instancama objekata osoba, student i osobaStudent.
            Osoba osoba = new Osoba();
            osoba.DajOib();
            Student student = new Student();
            student.DajOib();
            student.PoložiIspit("csh");

            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            ((Student)osobaStudent).PoložiIspit("fizika") ;
            // TODO:071 Deklarirajte objekt tipa Student i pokušajte ga instancirati pozivom konstruktora tipa Osoba. Provjerite što prevoditelj javlja.
            //Student student2 = new Osoba();

            Console.ReadKey();
        }
    }
}
