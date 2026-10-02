using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Bien
    {
        public int BienId {  get; set; }
        public string Nom { get; set; }
        public int Valeur { get; set; }
        public string Adresse { get; set; }
        public int Surface { get; set; }
        public List<Bail> Baux { get; set; }
        public List<Intervention> Interventions { get; set; }

        public Bien()
        {

        }

        public Bien(string unNom, int uneValeur, string uneAdresse, int uneSurface)
        {
            this.Nom = unNom;
            this.Valeur = uneValeur;
            this.Adresse = uneAdresse;
            this.Surface = uneSurface;
            this.Baux = new List<Bail>();
            this.Interventions = new List<Intervention>();
        }

        public virtual int estimationBien()
        {
            int valeurTotal = 1400 * this.Surface;

            return valeurTotal;
        }

        public double calculerRentabiliteNetMensuel()
        {
            double rentabiliteMensuel = 0;

            foreach (Bail bail in this.Baux)
            {
                if (bail.getDateFin() >= DateTime.Today)
                {
                    rentabiliteMensuel += bail.getLoyer();
                }
            }

            foreach (Intervention intervention in this.Interventions)
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
