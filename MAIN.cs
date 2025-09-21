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
            string tyyp = Console.ReadLine().ToLower();

            if (tyyp == "auto")
            {
                Console.Write("Sisesta auto kütusekulu (liitrid/100km): ");
                double kulu = double.Parse(Console.ReadLine());

                Console.Write("Sisesta auto läbitud kaugus (km): ");
                double kaugus = double.Parse(Console.ReadLine());

                sõidukid.Add(new Auto(kulu, kaugus));
            }
            else if (tyyp == "jalgratas")
            {
                Console.Write("Sisesta jalgratta läbitud kaugus (km): ");
                double kaugus = double.Parse(Console.ReadLine());

                sõidukid.Add(new Jalgratas(kaugus));
            }
            else if (tyyp == "buss")
            {
                Console.Write("Sisesta bussi kütusekulu (liitrid/100km): ");
                double kulu = double.Parse(Console.ReadLine());

                Console.Write("Sisesta bussi läbitud kaugus (km): ");
                double kaugus = double.Parse(Console.ReadLine());

                Console.Write("Sisesta reisijate arv: ");
                int reisijad = int.Parse(Console.ReadLine());

                sõidukid.Add(new Buss(kulu, kaugus, reisijad));
            }
            else if (tyyp == "elektrilinetõukeratas")
            {
                Console.Write("Sisesta elektrilise tõukeratta läbitud kaugus (km): ");
                double kaugus = double.Parse(Console.ReadLine());

                sõidukid.Add(new ElektrilineTõukeratas(kaugus));
            }
            else
            {
                Console.WriteLine("Vale sõiduki tüüp! Palun sisesta Auto, Jalgratas, Buss või ElektrilineTõukeratas.");
                return;
            }

            double kogukulu = 0;
            foreach (var s in sõidukid)
            {
                Console.WriteLine(s.ToString());
                kogukulu += s.ArvutaKulu();
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
