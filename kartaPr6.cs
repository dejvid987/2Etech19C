using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
// zad 4
/*int suma = 0;
for (int a = 10; a < 100; a++)
{
    int l1 = 0;
    int l2 = 0;
    l1 = a % 10;
    l2 = a % 100;
    l2 -= l1;
    l2 /= 10;
    if (l2 >= l1 * 2)
    {
        suma += 1;
    }

}
Console.WriteLine(suma);
*/
// zad 5
/*int l1 = 0;
int l2 = 0;
int l3 = 0;
int suma = 0;
int razem = 0;
for (int a = 100; a < 1000; a++)
{
    l1 = a % 10;
    l2 = (((a % 100)-l1)/10);
    l3 = (((a % 1000)-l2)/100);
    if (l3 > l1 + l2)
    {
        suma += 1;
        razem += a;
    }
}
Console.WriteLine(suma);
Console.WriteLine(razem);*/
// zad 6
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = n; i < 100; i++)
{
    if (i % 19 == 0)
    {
        suma += i;
    }
}
Console.WriteLine(suma);*/
// zad 7
/*int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 999; i > 99; i--)
{
    if (i % 37 == 0)
    {
        suma += i;
        n--;
        if (n <= 0)
        {
            break;
        }
    }
    
}
    Console.WriteLine(suma);*/
