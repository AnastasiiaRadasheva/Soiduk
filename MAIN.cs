using Sõidukite;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sõidukite
{
    class Program
    {
        static void Main()
        {
            List<ISõiduk> sõidukid = new List<ISõiduk>();

            Console.WriteLine("Sisesta sõiduki tüüp (Auto, Jalgratas, Buss, ElektrilineTõukeratas): ");
            string sõidukiTüüp = Console.ReadLine().ToLower();

            if (sõidukiTüüp == "auto")
            {
                Console.Write("Sisesta auto kütusekulu (liitrid/100km): ");
                double autoKütusekulu = double.Parse(Console.ReadLine());

                Console.Write("Sisesta auto läbitud kaugus (km): ");
                double autoVahemaa = double.Parse(Console.ReadLine());

                sõidukid.Add(new Auto(autoKütusekulu, autoVahemaa));
            }
            else if (sõidukiTüüp == "jalgratas")
            {
                Console.Write("Sisesta jalgratta läbitud kaugus (km): ");
                double jalgrattaVahemaa = double.Parse(Console.ReadLine());

                sõidukid.Add(new Jalgratas(jalgrattaVahemaa));
            }
            else if (sõidukiTüüp == "buss")
            {
                Console.Write("Sisesta bussi kütusekulu (liitrid/100km): ");
                double bussKütusekulu = double.Parse(Console.ReadLine());

                Console.Write("Sisesta bussi läbitud kaugus (km): ");
                double bussVahemaa = double.Parse(Console.ReadLine());

                Console.Write("Sisesta reisijate arv: ");
                int bussReisijad = int.Parse(Console.ReadLine());

                sõidukid.Add(new Buss(bussKütusekulu, bussVahemaa, bussReisijad));
            }
            else if (sõidukiTüüp == "elektrilinetõukeratas")
            {
                Console.Write("Sisesta elektrilise tõukeratta läbitud kaugus (km): ");
                double tõukeratasVahemaa = double.Parse(Console.ReadLine());

                sõidukid.Add(new ElektrilineTõukeratas(tõukeratasVahemaa));
            }
            else
            {
                Console.WriteLine("Vale sõiduki tüüp! Palun sisesta Auto, Jalgratas, Buss või ElektrilineTõukeratas.");
                return;
            }

            double kogukulu = 0;
            foreach (var sõiduk in sõidukid)
            {
                Console.WriteLine(sõiduk.ToString());
                kogukulu += sõiduk.ArvutaKulu();
            }

            Console.WriteLine($"Kõigi sõidukite kütusekulu kokku: {kogukulu} liitrit");
        }
    }
    public interface ISõiduk
    {

        double ArvutaKulu();

        double ArvutaVahemaa();
    }

}
