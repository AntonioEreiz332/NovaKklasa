using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseObjekti
{
    class Klasa
    {
        string ime;
        int godRod;

        public string Ime { get => ime; set => ime = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public override string ToString()
        {
            string Ispis = "String: " + this.ime + " \rInt: " + this.godRod;
            return Ispis;
        }
        public Klasa(string ime, int godRod)
        {
            this.ime = ime;
            this.godRod = godRod;
        }
    }
}
