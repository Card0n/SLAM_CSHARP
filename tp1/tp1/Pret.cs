using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace tp1
{
    public class Pret
    {
        private double apport;
        private double montant;
        private double tauxInteret;
        private int duree;
        private DateTime dateDebut;

        public Pret(double unApport, double unMontant, double unTauxInteret, int uneDuree, DateTime uneDateDebut)
        {
            this.apport = unApport;
            this.montant = unMontant;
            this.tauxInteret = unTauxInteret;
            this.duree = uneDuree;
            this.dateDebut = uneDateDebut;
        }

        public double calculerMensualite()
        {
            double montantTotal = this.montant * (1 + this.tauxInteret);

            double mensualite = montantTotal / this.duree;
            return mensualite;
        }

        public int obtenirNbMoisRestant()
        {
            int nbMoisRestant = (DateTime.Now.Year - this.dateDebut.Year) * 12 + (DateTime.Now.Month - this.dateDebut.Month);
            return nbMoisRestant;
        }

        public double calculerCapitalRestantARembourser()
        {
            double capitalRestant = this.obtenirNbMoisRestant() * this.calculerMensualite();
            return capitalRestant; ;
        }

        public double getApport()
        {
            return this.apport;
        }

        public void setApport(double unApport)
        {
            this.apport = unApport;
        }

        public double getMontant()
        {
            return this.montant;
        }

        public void setMontant(double unMontant)
        {
            this.montant = unMontant;
        }

        public double getTauxInteret()
        {
            return this.tauxInteret;
        }

        public void setTauxInteret(double unTauxInteret)
        {
            this.tauxInteret = unTauxInteret;
        }

        public int getDuree()
        {
            return this.duree;
        }

        public void setDuree(int uneDuree)
        {
            this.duree = uneDuree;
        }

        public DateTime getDateDebut()
        {
            return this.dateDebut;
        }

        public void setDateDebut(DateTime uneDateDebut)
        {
            this.dateDebut = uneDateDebut;
        }


    }
}
