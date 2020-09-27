using System;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int choice = default(int);

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
                break;
                case 3:
                break;
            }
        }

        static void GetInt(ref int x)
        {
            while (!int.TryParse(System.Console.ReadLine(),out x))
                System.Console.Write("To nie jest liczba, sprobuj ponownie: "); 
        }
    }
}
