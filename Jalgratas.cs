using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sõidukite
{
    public class Jalgratas : ISõiduk
    {
        private double vahemaa;

        public Jalgratas(double kaugus)
        {
            vahemaa = kaugus;
        }

        public double ArvutaKulu()
        {
            return 0;
        }

        public double ArvutaVahemaa()
        {
            return vahemaa;
        }

        public override string ToString()
        {
            return $"Jalgratas: Kütusekulu - {ArvutaKulu()} liitrit, Kaugus - {ArvutaVahemaa()} km";
        }
    }

}
