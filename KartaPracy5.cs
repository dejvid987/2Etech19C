using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int dzielniki = 0;
            for (int i = 10; i < 100; i++)
            {
                dzielniki = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        dzielniki += 1;
                        break;
                    }
                    if (dzielniki == 0)
                    {
                        Console.WriteLine(i);
                        suma += i;
                    }
                }
                Console.WriteLine(suma);
            }
        }
    }
}
