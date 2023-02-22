using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student1
    {
        public int numer;
        public string imie;
    }
    class Student2
    {
        private int numer;
        private string imie;
        public int GetNumer()
        {
            return numer;
        }
        public void setNumer(int numer)
        {
            this.numer = numer;
        }
        public string GetImie()
        {
            return imie;
        }
        public void setImie(string imie)
        {
            this.imie = imie;
        }
    }
    class Student3
    {
        int numer;
        string imie;
        public int Numer {
            get
            {
                return this.numer;
            }
            set
            {
                this.numer = value;
            } 
        }
        public string Imie { get => imie ; set => imie = value; }
    }
    class Student4
    {
        int numer;
        public int Numer { get;  set; }
        public string Imie { get; set; }
    }
    class Animal
    {
        string name;
        bool udomowiony;
        public string Name { get; set; }
        public bool Udomowiony { get; set; }
        public virtual void Introduce() {
            Console.WriteLine("Hau hau");
        }
        
    }
    class Pies :Animal { 
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("Hau od psa");
        }
    }
    class Wilk : Animal
    {

    }
    class Firma
    {
        public string nip;
        public string NIP
        {
            get
            {
                return nip;
            }
        }
        public Firma(string nip)
        {
            this.nip = nip;
        }
    }
    class Polska : Firma
    {
        public override string NIP
        {
            get
            {
                return "PL" + base.NIP;
            }
        }
        public Polska(string nip, int nr): base(nip)
        {
            this.nip = nip + "ads";
        }
    }
    internal class MojProgram
       {
          static void Main(string[] args)
          {
            /*Student1 s1 = new Student1();
            s1.numer = 4;
            s1.imie = "BOGDAN";

            Student2 s2 = new Student2();
            s2.setNumer(5);
            s2.setImie("Jerzy");
            Console.WriteLine(s2.GetNumer()+" "+s2.GetImie());

            Student4 s4 = new Student4();
            s4.Numer = 5;
            s4.Imie = "Włodek";
*/

            Pies p = new Pies();
            p.Name = "Burek";
            p.Introduce();

            }
        }
    }
