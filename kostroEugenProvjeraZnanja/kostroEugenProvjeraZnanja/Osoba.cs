using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenProvjeraZnanja
{
    class Osoba
    {
        string Ime;
        string prezime;
        int OIB;
        int Datum;

        public Osoba(string ime, string prezime, int oIB, int datum)
        {
            Ime = ime;
            this.prezime = prezime;
            OIB = oIB;
            Datum = datum;
        }

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int OIB1 { get => OIB; set => OIB = value; }
        public int Datum1 { get => Datum; set => Datum = value; }
    }
}
