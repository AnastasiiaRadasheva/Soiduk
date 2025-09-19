using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sõidukite
{


    public class Auto : ISõiduk
    {
        private double kütusekulu; 
        private double vahemaa; 

        public Auto(double kütusekulu, double vahemaa)
        {
            kütusekulu = kütusekulu;  
            vahemaa = vahemaa;       
        }

        public double ArvutaKulu()
        {
            return (kütusekulu * vahemaa) / 100;
        }

        public double ArvutaVahemaa()
        {
            return vahemaa;
        }

        public override string ToString()
        {
            return $"Auto: Kütusekulu - {ArvutaKulu()} liitrit, Kaugus - {ArvutaVahemaa()} km";
        }
    }

}
