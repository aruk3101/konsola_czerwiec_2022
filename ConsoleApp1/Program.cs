namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testy aplikacji konsolowej:");

            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.InstancjeKlasy}");

            Osoba osoba1 = new Osoba();

            Console.WriteLine("Podaj id osoby:");
            int id = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Podaj imię osoby:");
            string imie = Console.ReadLine() ?? "";
            Osoba osoba2 = new Osoba(id, imie);

            Osoba osoba3 = new Osoba(osoba2);

            osoba1.Wypisz("Jan");
            osoba2.Wypisz("Jan");
            osoba3.Wypisz("Jan");

            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.InstancjeKlasy}");
        }
    }
}
