using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Radnik : Osoba { }

    class Program
    {
        static void Main()
        {
            // TODO:100 Pokrenuti program i provjeriti što će se ispisati te koja će iznimka biti bačena.
            Osoba janko = new Student();
            Student jankoStudent = janko as Student;
            if (jankoStudent != null)
                Console.WriteLine(jankoStudent);
            else
                Console.WriteLine("null");

            Radnik jankoSljaker = janko as Radnik;
            if (jankoSljaker != null)
                Console.WriteLine(jankoSljaker);
            else
                Console.WriteLine("null");

            try
            {
                jankoSljaker = (Radnik)janko;
            }
            catch (Exception e)
            {
                Console.WriteLine("Bačena iznimka!");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }


        static void Pretvorba1()
        {
            Osoba janko = new Student();

            if (janko is Student)
            {
                Student studentJanko = (Student)janko;
                // iskoristi studenta unutar bloka
            }
        }

        // ovo je efikasniji način pisanja kada želimo napraviti "sigurnu" pretvorbu:
        // (pogledati i usporediti generirani IL kod za obje metode)
        static void Pretvorba2()
        {
            Osoba janko = new Student();

            Student studentJanko = janko as Student;
            if (studentJanko != null)
            {
            }
        }
    }
}
