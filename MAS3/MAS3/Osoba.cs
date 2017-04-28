using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    abstract class Osoba
    {
        public readonly string pesel;
        public string imie { get; private set; }
        public string nazwisko { get; private set; }
        public Osoba(string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }
    }
}
