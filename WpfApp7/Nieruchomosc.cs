using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ZadanieLista
{
    class Nieruchomosc
    {
        public int Id { get; set; }
        public string Osiedle { get; set; }
        public string Adres { get; set; }
        public bool ZGarazem { get; set; }
        public Rodzaj Rodzaj { get; set; }
        public bool Dostepnosc { get; set; }
        public string Opis { get; set; }

        public Nieruchomosc(int id, string osiedle, string adres, bool zGarazem, Rodzaj rodzaj, bool dostepnosc, string opis)
        {
            Id = id;
            Osiedle = osiedle;
            Adres = adres;
            ZGarazem = zGarazem;
            Rodzaj = rodzaj;
            Dostepnosc = dostepnosc;
            Opis = opis;
        }
    }
    public enum Rodzaj
    {
        M2,
        M3,
        M4
    }

}