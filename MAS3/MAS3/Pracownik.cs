using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    class Pracownik : Osoba
    {
        public double stawkaGodzinowa { get; private set; }
        public Pracownik(string imie, string nazwisko, string pesel,double stawka ) : base(imie, nazwisko, pesel)
        {
            stawkaGodzinowa = stawka;
        }
    }
}
