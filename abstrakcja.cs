using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*class Osoba
    {
        public string imie { get; set; }
        public int wiek { get; set; }
        private Osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }
    }*/
    /*abstract class Osoba
    {
        *//*abstract public void Przywitaj();  // abstr zapisuuemy tak*//*
        public abstract void przywitaj();
        void pozegnaj()
        {
            Console.WriteLine("Pożegnaj");
        }
    }
    class Nauczyciel : Osoba
    {
        public override void Przywitaj()//override = metoda jest nadpisywana z klasy wyzszej
        {
            Console.WriteLine("hi");
        }
    }
    class Uczen : Osoba
    {

    }*/
    /*abstract class Samochod
    {
        public abstract string Model { get; set; }
    }
    class BMW : Samochod
    {
        private string _model;
        public override string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
    }
    class Audi : Samochod{
        private string _model;
        public override string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }





    }*/
    /*interface IOdprawa
    {
        void odprawSie();

    }
    abstract class Osoba
    {
        public string Imie { get; set; }
        public abstract void odprawSie2();
    }
    class Pracownik : Osoba
    {

    }
    class Kierownik : Osoba, IOdprawa // klasa rozszerzona o interfejs
    {
        public void odprawSie()
        {
            Console.WriteLine("Kierownik odprawia sie");
        }
    }*/




    abstract class Auto
    {
        public abstract string Model { get; set; }
        public virtual void jedz()
        {
            Console.WriteLine("Jade");
        }
    }
    class Skoda: Auto
    {
        public override string Model { get; set; }
        public override void jedz() { Console.WriteLine("jade"); }
    }
    class Audi:Auto
    {
        public override string Model { get; set; }
        public override void jedz() { Console.WriteLine("jade"); }
    }
    class BMW:Auto
    {
        public override string Model { get; set; }
        public override void jedz() { Console.WriteLine("jade"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kierownik k =   new Kierownik();
            k.imie = "Bogan";
            Osoba o = new Osoba(12,"Kazik");*/


            /*Audi audi = new Audi();
            audi.Model = "test";
            Console.WriteLine(audi.Model);*/
        }
    }
}
