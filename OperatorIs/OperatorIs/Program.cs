﻿using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            // TODO:090 Dodajte provjere za objekt osoba je li tipa Osoba i tipa Student.
            Osoba osoba = new Osoba();


            // TODO:091 Dodajte provjere za objekt janko je li tipa Osoba i tipa Student.
            Osoba janko = new Student();


            Console.ReadKey();
        }
    }
}