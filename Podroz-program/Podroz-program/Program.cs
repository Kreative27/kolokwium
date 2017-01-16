using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podroz_program
{
   class Program
   {
       static void Main(string[] args)
       {
           string wynik = "a";
           Podroz podroz1 = new Podroz();
           while(wynik != "X")
           {

               Console.Write("Co chcesz zrobic?\n A - ustaw rodzaj podrozy \n B - dodaj stacje \n C - usun stacje \n D - dodaj stacje powrotna \n E - zapisz do pliku \n");
               Console.WriteLine("Wcisnij X aby wyjsc");
                wynik = Console.ReadLine();
               if (wynik == "A")
               {
                   Console.WriteLine(" Wybierz rodzaj podrozy: A -zwykla, B - lastminute");
                   string typ = Console.ReadLine();
                   if (typ == "A")
                   {
                           podroz1 = new Podroz();;
                   }
                   else
                   {
                       podroz1 = new LastMinute();
                   }
               }
               if (wynik == "B")
               {
                   Console.WriteLine("Podaj nazwe stacji:");
                   string nazwa = Console.ReadLine();
                   Console.WriteLine("Oplata klimatyczna? T - tak, N - nie");
                   string oplata = Console.ReadLine();
                   bool oplataK;
                   if (oplata == "T")
                   {
                       oplataK = true;
                   }
                   else 
                   {
                       oplataK = false;
                   }

                   podroz1.DodajStacje(nazwa, oplataK);
               }
               if (wynik == "C")
               {
                   Console.WriteLine("Usuwam stacje...");
                   podroz1.UsunStacje();
               }
               if (wynik == "D")
               {
                   podroz1.Powrot();
               }
               if (wynik == "E")
               {
                   podroz1.ZapiszPodroz();
               }
               Console.Clear();

           }


       }
   }
}
