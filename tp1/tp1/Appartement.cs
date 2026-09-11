using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Appartement : Habitable
    {
        private int etage;
        private int ascenseur;
        private bool chauffCommun;
        public Appartement(int unEtage, int unAscenseur, bool unChauffCommun, int unNbPieces, int unNbChambre, bool uneCave, bool unParking, string unNom, int uneValeur, string uneAdresse, int uneSurface) : base(unNbPieces, unNbChambre, uneCave, unParking, unNom, uneValeur, uneAdresse, uneSurface)
        {
            this.etage = unEtage;
            this.ascenseur = unAscenseur;
            this.chauffCommun = unChauffCommun;
        }

        public int getEtage()
        {
            return this.etage;
        }

        public void setEtage(int unEtage)
        {
            this.etage = unEtage;
        }

        public int getAscenseur()
        {
            return this.ascenseur;
        }

        public void setAscenseur(int unAscenseur)
        {
            this.ascenseur = unAscenseur;
        }

        public bool getChauffCommun()
        {
            return this.chauffCommun;
        }

        public void setChauffCommun(bool unChauffCommun)
        {
            this.chauffCommun = unChauffCommun;
        }
    }
}
