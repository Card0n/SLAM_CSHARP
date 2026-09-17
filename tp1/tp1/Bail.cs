using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Bail
    {
        private double loyer;
        private DateTime dateDebut;
        private DateTime dateFin;

        public Bail(double unLoyer, DateTime uneDateDebut, DateTime uneDateFin)
        {
            this.loyer = unLoyer;
            this.dateDebut = uneDateDebut;
            this.dateFin = uneDateFin;
        }

        public double getLoyer()
        {
            return this.loyer;
        }

        public void setLoyer(double unLoyer)
        {
            this.loyer = unLoyer;
        }

        public DateTime getDateDebut()
        {
            return this.dateDebut;
        }

        public void setDateDebut(DateTime uneDateDebut)
        {
            this.dateDebut = uneDateDebut;
        }

        public DateTime getDateFin()
        {
            return this.dateFin;
        }

        public void setDateFin(DateTime uneDateFin)
        {
            this.dateFin = uneDateFin;
        }

        public override string ToString()
        {
            return "=== Bail" +
                   "\nLoyer : " + this.loyer + " €" +
                   "\nDate début : " + this.dateDebut +
                   "\nDate début : " + this.dateFin;

        }
    }
}
