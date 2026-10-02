using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Box garage = new Box("Garage Oullins", 1200, "128 avenue de gaulle, 07100 Annonay", 12);

            Pret pretGarage = new Pret(2000, 3200, 0.1, 50, new DateTime(2019, 9, 1));
            Pret pretAppart = new Pret(30000, 145000, 0.1, 240, new DateTime(2012, 4, 22));

            Maison manoir = new Maison(10, 6, true, true, "Manoir Mathat", 5500000, "hameau des guidons, 07690 Vilevocance", 220);

            Bail bailManoir = new Bail(4500, new DateTime(2019, 10, 25), new DateTime(2022, 2, 20));
            Bail bailAppart = new Bail(1200, new DateTime(2020, 10, 25), new DateTime(2022, 2, 20));
            

            Appartement appart = new Appartement(9, true, true, 4, 3, true, true, "L'appart", 2700, "53 boulevard des canards, 69007 Lyon", 78);

            Locataire julianPinot = new Locataire("Pinot", "Julian", 25, "UX Designer");
            Locataire thomasBroutier = new Locataire("Broutier", "Thomas", 25, "Entrepreneur");

            Console.WriteLine(garage);
            Console.WriteLine(pretGarage);

            Console.WriteLine(manoir);
            Console.WriteLine(bailManoir);
            Console.WriteLine(julianPinot);

            Console.WriteLine(appart);
            Console.WriteLine(pretAppart);
            Console.WriteLine(bailAppart);
            Console.WriteLine(thomasBroutier);
            Console.WriteLine(julianPinot);
        }
    }
}

