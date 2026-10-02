using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace tp1
{
    public class Pret
    {
        public int PretId {  get; set; }
        public double Apport { get; set; }
        public double Montant { get; set; }
        public double TauxInteret { get; set; }
        public int Duree { get; set; }
        public DateTime DateDebut { get; set; }

        public Pret(double unApport, double unMontant, double unTauxInteret, int uneDuree, DateTime uneDateDebut)
        {
            this.Apport = unApport;
            this.Montant = unMontant;
            this.TauxInteret = unTauxInteret;
            this.Duree = uneDuree;
            this.DateDebut = uneDateDebut;
        }

        public double calculerMensualite()
        {
            double tauxMensuel = (this.TauxInteret/100)/12;
            return this.Montant * tauxMensuel;
        }

        public int obtenirNbMoisRestant()
        {
            DateTime dateFin = this.DateDebut.AddMonths(this.Duree);
            if (DateTime.Now >= dateFin)
            {
                return 0;
            }

            else
            {
                int nbMoisRestant = (dateFin.Year - DateTime.Now.Year) * 12 + (this.DateDebut.Month - DateTime.Now.Month);
                return nbMoisRestant;
            } 
        }

        public double calculerCapitalRestantARembourser()
        {
            double capitalRestant = this.obtenirNbMoisRestant() * this.calculerMensualite();
            return capitalRestant;
        }
        public override string ToString()
        {
            return "=== Prêt" +
                   "\nApport : " + this.Apport + " €" +
                   "\nMensualité : " + this.calculerMensualite() + " €" +
                   "\nDurée : " + this.Duree +
                   "\nDate début : " + this.DateDebut +
                   "\nCapital restant : " + calculerCapitalRestantARembourser() + " €";
        }




    }
}
