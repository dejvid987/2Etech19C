using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 2
            /*
            for (int i = 105; i < 1000; i+=15)
            {
                if (i%15==0)
                {
                    Console.WriteLine(i);
                }
            
            }
            */

            // Zad 3
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            // Zad 4
            /*
            int wynik = 0;
            for (int i = 10; i < 100; i++)
            {
                wynik = wynik + i;
                Console.WriteLine(wynik);
            }
            */

            // Zad 5

            /*
            Console.WriteLine("Podaj liczbe w którą gramy (n):");
            int n = int.Parse(Console.ReadLine());
            int suma = n * (n + 1) / 2;
            int liczba
            Console.WriteLine($"Ok. Podaj {n-1} liczb a ja zgadnę tą której nie podałeś");
            for (int i = 0; i < n - 1; i++)
            {
                liczba = int.Parse(Console.ReadLine());
                suma = suma - liczba;
            }
            Console.WriteLine($"Wybrałeś sobie {suma});
            */

            // Zad 6
            /*
            Console.WriteLine("Ile chcesz liczb Fibonacciego? ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;*/

        }
    }
}
