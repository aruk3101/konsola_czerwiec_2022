using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Osoba
    {
        public static int InstancjeKlasy = 0;
        private int id;
        private string imie;

        public Osoba()
        {
            id = 0;
            imie = "";
            InstancjeKlasy++;
        }

        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            InstancjeKlasy++;
        }

        public Osoba(Osoba osoba)
        {
            id = osoba.id;
            imie = osoba.imie;
            InstancjeKlasy++;
        }

        public void Wypisz(string argument)
        {
            Console.WriteLine(string.IsNullOrEmpty(imie) == true ? "Brak danych" : $"Cześć {argument}, mam na imię {imie}");
        }
    }
}
