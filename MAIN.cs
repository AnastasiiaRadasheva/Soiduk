using Sõidukite;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sõidukite;
using System;
using System.Collections.Generic;

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
                double kulu = 0;
                double kaugus = 0;

                Console.Write("Sisesta auto kütusekulu (liitrid/100km): ");
                while (!double.TryParse(Console.ReadLine(), out kulu) || kulu <= 0)
                {
                    Console.WriteLine("Palun sisesta kehtiv kütusekulu (positiivne arv).");
                }

                Console.Write("Sisesta auto läbitud kaugus (km): ");
                while (!double.TryParse(Console.ReadLine(), out kaugus) || kaugus <= 0)
                {
                    Console.WriteLine("Palun sisesta kehtiv kaugus (positiivne arv).");
                }

                sõidukid.Add(new Auto(kulu, kaugus));
            }
            else if (tyyp == "jalgratas")
            {
                double kaugus = 0;

                Console.Write("Sisesta jalgratta läbitud kaugus (km): ");
                while (!double.TryParse(Console.ReadLine(), out kaugus) || kaugus <= 0)
                {
                    Console.WriteLine("Palun sisesta kehtiv kaugus (positiivne arv).");
                }

                sõidukid.Add(new Jalgratas(kaugus));
            }
            else if (tyyp == "buss")
            {
                double kulu = 0;
                double kaugus = 0;
                int reisijad = 0;

                Console.Write("Sisesta bussi kütusekulu (liitrid/100km): ");
                while (!double.TryParse(Console.ReadLine(), out kulu) || kulu <= 0)
                {
                    Console.WriteLine("Palun sisesta kehtiv kütusekulu (positiivne arv).");
                }

                Console.Write("Sisesta bussi läbitud kaugus (km): ");
                while (!double.TryParse(Console.ReadLine(), out kaugus) || kaugus <= 0)
                {
                    Console.WriteLine("Palun sisesta kehtiv kaugus (positiivne arv).");
                }


                Console.Write("Sisesta reisijate arv: ");
                while (!int.TryParse(Console.ReadLine(), out reisijad) || reisijad < 0)
                {
                    Console.WriteLine("Palun sisesta kehtiv reisijate arv (positiivne arv).");
                }

                sõidukid.Add(new Buss(kulu, kaugus, reisijad));
            }
            else if (tyyp == "elektrilinetõukeratas")
            {
                double kaugus = 0;

 
                Console.Write("Sisesta elektrilise tõukeratta läbitud kaugus (km): ");
                while (!double.TryParse(Console.ReadLine(), out kaugus) || kaugus <= 0)
                {
                    Console.WriteLine("Palun sisesta kehtiv kaugus (positiivne arv).");
                }

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

    // Interfaces and classes for each vehicle type would remain the same as in your original code
    public interface ISõiduk
    {
        double ArvutaKulu();
        double ArvutaVahemaa();
    }

    // Add the rest of your class definitions for Auto, Jalgratas, Buss, ElektrilineTõukeratas
}
