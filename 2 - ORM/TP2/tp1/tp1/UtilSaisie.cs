using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public static class UtilSaisie
    {
        public static Pret saisirPret()
        {
            Console.WriteLine("Veuillez entrez l'apport de votre pret : ");
            double apport = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrez la montant de celui-ci :");
            double montant = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrez l'adresse du pret : ");
            double tauxInteret = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la duree : ");
            int duree = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la date de début de celui-ci: ");
            DateTime dateDebut = DateTime.Parse(Console.ReadLine());

            Pret nouvPret = new Pret(apport, montant, tauxInteret, duree, dateDebut);

            return nouvPret;
        }

    }
}
