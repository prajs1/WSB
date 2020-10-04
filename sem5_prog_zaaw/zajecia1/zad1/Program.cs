using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace zad1
{
    class Program
    {
        static readonly string read = System.Console.ReadLine();

        static void Main(string[] args)
        {
            int choice = default(int);
            List<Osoba> rejestr = new List<Osoba>();

            System.Console.Write("Menu:\n1 - Przegladaj\n2 - Dodaj\n3 - Zakoncz program\nWybor: ");
            while (true)
            {
                GetInt(ref choice);

                if ( choice == 1 || choice == 2 || choice == 3)
                    break;
                else
                    System.Console.Write("Nie ma takiej opcji, sprobuj jeszce raz: ");
            }

            switch (choice)
            {
                case 1:
                break;
                case 2:
                    DodajOsobe(rejestr);
                break;
                case 3:
                    System.Console.Clear();
                    System.Console.Write("Do zobaczenia");
                    Thread.Sleep(2000);
                break;
            }
        }

        static void GetInt(ref int x)
        {
            while (!int.TryParse(read,out x))
                System.Console.Write("To nie jest liczba, sprobuj ponownie: "); 
        }

        static void DodajOsobe(List<Osoba> o)
        {
            string name, surname, gender, postalcode, city, street, houseno;
            int age = default(int), apartmentno = default(int);

            System.Console.WriteLine("Podaj dane osoby: ");
            System.Console.Write("Imie: ");
            name = read;
            System.Console.Write("Nazwisko: ");
            surname = read;
            System.Console.Write("Wiek: ");
            GetInt(ref age);
            System.Console.Write("Plec: ");
            gender = read;
            System.Console.Write("Kod pocztowy: ");
            postalcode = read;
            System.Console.Write("Miasto: ");
            city = read;
            System.Console.Write("Ulica: ");
            street = read;
            System.Console.Write("Numer domu: ");
            houseno = read;
            System.Console.Write("Numer mieszkania: ");
            GetInt(ref apartmentno);

            o.Add(new Osoba(name, surname, gender, age, postalcode, city, street, houseno, apartmentno));
        }
    }
}
