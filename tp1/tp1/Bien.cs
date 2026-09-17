using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Bien
    {
        private string nom;
        private int valeur;
        private string adresse;
        private int surface;
        private List<Bail> baux;
        private List<Intervention> interventions;

        public Bien(string unNom, int uneValeur, string uneAdresse, int uneSurface)
        {
            this.nom = unNom;
            this.valeur = uneValeur;
            this.adresse = uneAdresse;
            this.surface = uneSurface;
            this.baux = new List<Bail>();
            this.interventions = new List<Intervention>();
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string unNom)
        {
            this.nom = unNom;
        }

        public int getValeur()
        {
            return this.valeur;
        }

        public void setValeur(int uneValeur)
        {
            this.valeur = uneValeur;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public void setAdresse(string uneAdresse)
        {
            this.adresse = uneAdresse;
        }

        public int getSurface()
        {
            return this.surface;
        }

        public void setSurface(int uneSurface)
        {
            this.surface = uneSurface;
        }

        public double calculerRentabiliteNetMensuel()
        {
            double rentabiliteMensuel = 0;

            foreach(Bail bail in this.baux)
            {
                if(bail.getDateFin() >= DateTime.Today)
                {
                    rentabiliteMensuel += bail.getLoyer();
                }
            }

            foreach (Intervention intervention in this.interventions)
            {
                if (intervention.getDate().Month == DateTime.Today.Month)
                {
                    rentabiliteMensuel += intervention.getMontantTTC();
                }
            }

            return rentabiliteMensuel;
        }
    }
}
