using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podroz_program
{
    public class Podroz : IStacja
    {
        protected Queue<Stacja> stacje = new Queue<Stacja>();
        protected double koszt = 100;

        public Podroz()
        {

        }

        public virtual double KosztPoRabacie()
        {
            return this.koszt * 0.9;
        }

        public override string ToString()
        {
            string wynik = "Podróż:\n ";
            foreach (Stacja stacja in stacje)
            {
                wynik += stacja.ToString();
                wynik += "\n ";
            }
            wynik += "Koszt po rabacie: " + KosztPoRabacie().ToString() + " ";
            return wynik;
        }

        public void DodajStacje(string nazwa, bool oplata)
        {
            stacje.Enqueue(new Stacja(nazwa, oplata));
            if (oplata)
            {
                koszt += 15;
            }
        }

        public void UsunStacje()
        {
            stacje.Dequeue();
        }

        public void Powrot()
        {
            Stacja temp = (Stacja)stacje.Dequeue().Clone();
            stacje.Enqueue(temp);
        }

     public void ZapiszPodroz()
        {
            using (StreamWriter output = new StreamWriter(@"podroz.txt"))   
            {
                output.WriteLine(this.ToString());
            }
        }
    }
       
    public class LastMinute : Podroz
    {
        public override double KosztPoRabacie()
        {
            return this.koszt * 0.5;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Last Minute";
        }
    }
    }
