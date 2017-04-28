using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    class Mebel
    {
        public string Nazwa { get; private set; }
        public int cenaBazowa { get; private set; }
        List<Komponent> CzesciSkladowe { get; }

        public Mebel(string Nazwa, int cenaBazowa)
        {
            this.Nazwa = Nazwa;
            this.cenaBazowa = cenaBazowa;
        }
        public void dodajKomponent(Komponent k)
        {
            CzesciSkladowe.Add(k);
        }
        public void usunKomponent(Komponent k)
        {
            CzesciSkladowe.Remove(k);
        }

    }
}
