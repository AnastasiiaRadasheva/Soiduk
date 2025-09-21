using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sõidukite
{

    public class Buss : ISõiduk
    {
        private double kütusekulu;
        private double vahemaa;
        private int reisijad;

        public Buss(double kulu, double kaugus, int reisijaArv)
        {
            kütusekulu = kulu;
            vahemaa = kaugus;
            reisijad = reisijaArv;
        }

        public double ArvutaKulu()
        {
            return (kütusekulu * vahemaa) / (100 * reisijad);
        }

        public double ArvutaVahemaa()
        {
            return vahemaa;
        }

        public override string ToString()
        {
            return $"Buss: Kütusekulu reisija kohta - {ArvutaKulu()} liitrit, Kaugus - {ArvutaVahemaa()} km";
        }
    }



}
