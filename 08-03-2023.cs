using System;
class Komputer
{
    string marka;
    string model;
    public virtual void wyswietl()
    {
        Console.WriteLine($"Marka {marka} Model: {model}");
    }
}
class Stacjonarny : Komputer
{
    
    string rodzajObudowy { get; set; }
    public override void wyswietl()
    {
        base.wyswietl();
        Console.WriteLine($"Rodzaj obudowy: {rodzajObudowy}");
    }
}
class Laptop : Komputer
{
    int dlugPrzekatnej { get; set; }
    private string kolor;
    public string getKolor()
    {
        return kolor;
    }
    public void setKolor(string kolor) { this.kolor = kolor; }
}
class Osoba
{
    private Klient klient;
    private Opiekun opiekun;
    private Serwisant serwisant;
    string imie;
    public string Imie { get => imie; set => imie = value; }
}
class Klient : Osoba{}
class Opiekun : Osoba{}
class Serwisant : Osoba{}
class Zlecenie : Opiekun
{
    Komputer komputer;
    Klient klient;
    Opiekun opiekun;
    public Zlecenie(Komputer komputer, Klient klient, Opiekun opiekun)
    {
        this.komputer = komputer;
        this.klient = klient;
        this.opiekun = opiekun;
    }
    // tu gety i sety ale panu sie nie chialo pisac
}
class Naprawa
{
    public Zlecenie zlecenie { get; }
    public Serwisant serwisant { get; set; }
    public Naprawa(Zlecenie zlecenie)
    {
        this.zlecenie = zlecenie;
    }
}

public class Program
{
    public static void Main()
    {
        //łatwy sposób
        Laptop lap = new Laptop();
      /*  lap.Marka = Console.ReadLine();
        lap.Model = Console.ReadLine();
        lap.Przekatna = double.Parse(Console.ReadLine());*/
        lap.setKolor(Console.ReadLine());
        // trudne ipomyslowe
        Console.WriteLine("Co do naprawy 1- komp - 2 lap");
        int wybor = int.Parse(Console.ReadLine());
        switch (wybor)
        {
            case 1:
                // tworzymy obiekt
                Stacjonarny stac = new Stacjonarny();
                /*stac.Marka = Console.ReadLine();
                stac.Marka = Console.ReadLine();
                stac.wyswietl = Console.ReadLine();*/
                break;
            case 2:
              /*  Laptop lap = new Laptop();
                *//*lap.Marka = Console.ReadLine();
                lap.Model = Console.ReadLine();
                lap.Przekatna = double.Parse(Console.ReadLine());*//*
                lap.setKolor(Console.ReadLine());*/
                break;
        }
    }
}
