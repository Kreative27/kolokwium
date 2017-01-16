using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podroz_program
{
    interface IStacja
    {
        void DodajStacje(string nazwa, bool oplata);
        void Powrot();
        void UsunStacje();
        void ZapiszPodroz();
    }
    public class Stacja : ICloneable
    {
        private string nazwaStacji;
        private bool oplataKlimatyczna;

        public Stacja(string nazwa, bool oplata)
        {
            this.nazwaStacji = nazwa;
            this.oplataKlimatyczna = oplata;
        }

        public override string ToString()
        {
            if (oplataKlimatyczna)
            {
                return "Stacja: " + nazwaStacji + ", oplata klimatyczna: tak";
            }
            else
            {
                return "Stacja: " + nazwaStacji + ", oplata klimatyczna: nie";
            }

        }

        public bool JakaOplata()
        {
            return oplataKlimatyczna;
        }

        public Object Clone ()
        {
            return MemberwiseClone();
        }
   
    }
}