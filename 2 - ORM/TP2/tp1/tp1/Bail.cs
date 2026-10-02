using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Bail
    {
        private double Loyer;
        private DateTime DateDebut;
        private DateTime DateFin;

        public Bail()
        {

        }
        public Bail(double unLoyer, DateTime uneDateDebut, DateTime uneDateFin)
        {
            this.Loyer = unLoyer;
            this.DateDebut = uneDateDebut;
            this.DateFin = uneDateFin;
        }

        public double getLoyer()
        {
            return this.Loyer;
        }

        public void setLoyer(double unLoyer)
        {
            this.Loyer = unLoyer;
        }

        public DateTime getDateDebut()
        {
            return this.DateDebut;
        }

        public void setDateDebut(DateTime uneDateDebut)
        {
            this.DateDebut = uneDateDebut;
        }

        public DateTime getDateFin()
        {
            return this.DateFin;
        }

        public void setDateFin(DateTime uneDateFin)
        {
            this.DateFin = uneDateFin;
        }

        public override string ToString()
        {
            return "=== Bail" +
                   "\nLoyer : " + this.Loyer + " €" +
                   "\nDate début : " + this.DateDebut +
                   "\nDate début : " + this.DateFin;

        }
    }
}
