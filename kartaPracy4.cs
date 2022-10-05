using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.ReadKey();*/

            //zadanie 1
            /*int a, b, razem;
            Console.WriteLine("Podaj liczbe a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");
            b = int.Parse(Console.ReadLine());
            razem = a * a + b * b;
            Console.WriteLine(razem);*/

            /*//zadanie 2
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if (x >= y && x >= z)
            {
                if (y >= z)
                {
                    Console.WriteLine($"{x} {y} {z}");
                }
                else
                {
                    Console.WriteLine($"{x} {z} {y}");
                }
            }
            else if (y >= x && y >= z)
            {
                if(x >= z)
                {
                    Console.WriteLine($"{y} {x} {z}");
                }
                else
                {
                    Console.WriteLine($"{y} {z} {x}");
                }
            }
            else if(z >= x && z >= y)
            {
                if (x >= y)
                {
                    Console.WriteLine($"{z} d{x} {y}");
                }
                else
                {
                    Console.WriteLine($"{z} {y} {x}");
                }
            }*/
            /*int n, wynik;
            wynik = 1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; )
            {
                wynik = wynik * i;
                Console.WriteLine(wynik);
                i++;
            }*/


            //zadanie 5


            /*for (int i = -7; i <= 17; i += 4)
            {
                Console.WriteLine(i);

            }
            int i = -7;
            while (i <= 17)
            {
                Console.WriteLine(i);
                i += 4;//wypisywanie na koniec
            }*/


            //zadanie 6

            /* for (int i = 2; i <= 486; i *= 3)
             {
                 Console.WriteLine(i);
             }
             int i = 2;
             while (i <= 486)
             {
                 Console.WriteLine(i);
                 i *= 3;
             }*/


            //zadanie 9
            /*int liczba, razem;
            razem = 0;
            liczba = int.Parse(Console.ReadLine());
            while (liczba > 0)
            {
                liczba /= 10;
                razem = razem + 1;
            }
            Console.WriteLine(razem);*/

            /*//zadanie 9 B
            int n = int.Parse(Console.ReadLine());
            int liczba = n;
            int x = 0, suma = 0;
            while (liczba > 0)
            {
                x = liczba % 10;
                suma += x;
                liczba = liczba / 10;
            }
            Console.WriteLine(suma);*/


            //zadanie 10

            /*int liczba;
            bool flaga = true;
            liczba = int.Parse(Console.ReadLine());
            for (int i = 2; i <= liczba; i++)
            {
                if (liczba % i == 0)
                {
                    Console.WriteLine("Liczba nie jest pierwsza");
                    flaga = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Liczba  jest");
                    flaga = true;
                    break;
                }
            }*/

        }
    }
}
