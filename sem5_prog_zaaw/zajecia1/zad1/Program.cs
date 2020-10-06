using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = default(int);
            List<Osoba> rejestr = new List<Osoba>();

            /**********************************Pierwsze wartości rejestru*************************************/
            /*************************************************************************************************/
            rejestr.Add(new Osoba("Jacek", "Placek", 'M', 32, "42-123", "Poznan", "Malinowa", "13", 0));
            rejestr.Add(new Osoba("Maria", "Taka", 'K', 25, "543-12", "Warszawa", "Truskawkowa", "1A", 12));
            rejestr.Add(new Osoba("Jan", "Plan", 'M', 37, "42-123", "Poznan", "kokosowa", "10C", 2));
            rejestr.Add(new Osoba("Jarek", "Plarek", 'M', 32, "42-123", "Poznan", "Jablkowa", "1", 0));

            Menu( ref choice);

            switch (choice)
            {
                case 1:
                    Search(ref rejestr);
                break;
                case 2:
                    DodajOsobe(rejestr);
                break;
                case 3:
                    System.Console.Clear();
                    System.Console.Write("Do zobaczenia");
                    Thread.Sleep(1500);
                break;
            }
        }

        static void Menu(ref int choice)
        {
            System.Console.Write("Menu:\n1 - Przegladaj\n2 - Dodaj\n3 - Zakoncz program\nWybor: ");
            while (true)
            {
                GetInt(ref choice);

                if ( choice == 1 || choice == 2 || choice == 3)
                    break;
                else
                    System.Console.Write("Nie ma takiej opcji, sprobuj jeszce raz: ");
            }
        }

        static void Search(ref List<Osoba> o)
        {
            string s = default(string);
                    System.Console.Write("Podaj fraze, ktora chcesz wyszukac: ");
                    ReadString(ref s);

                    for (int i = 0; i < o.Count; i++)
                    {
                        if(o[i].Name.Contains(s))
                            System.Console.WriteLine((i + 1) + " - " + o[i].Name + " " + o[i].Surname + " " + o[i].Age + " " + o[i].Age);
                    }
        }

        static void GetInt(ref int x)
        {
            while (!int.TryParse(System.Console.ReadLine(),out x))
                System.Console.Write("To nie jest liczba, sprobuj ponownie: "); 
        }

        static void DodajOsobe(List<Osoba> o)
        {
            string name = default(string), surname = default(string), postalcode = default(string), city = default(string), street = default(string), houseno = default(string);
            char gender;
            int age = default(int), apartmentno = default(int);

            System.Console.WriteLine("Podaj dane osoby: ");
            System.Console.Write("Imie: ");
            ReadString(ref name);
            System.Console.Write("Nazwisko: ");
            ReadString(ref surname);
            System.Console.Write("Wiek: ");
            GetInt(ref age);
            System.Console.Write("Plec: ");
            while (!char.TryParse(System.Console.ReadLine(), out gender))
                System.Console.Write("To nie jest char sprobuj ponownie: ");

            System.Console.Write("Kod pocztowy: ");
            ReadString(ref postalcode);
            System.Console.Write("Miasto: ");
            ReadString(ref city);
            System.Console.Write("Ulica: ");
            ReadString(ref street);
            System.Console.Write("Numer domu: ");
            ReadString(ref houseno);
            System.Console.Write("Numer mieszkania: ");
            GetInt(ref apartmentno);

            o.Add(new Osoba(name, surname, gender, age, postalcode, city, street, houseno, apartmentno));
        }

        static void ReadString(ref string x)
        {
            x = System.Console.ReadLine();
        }
    }
}
