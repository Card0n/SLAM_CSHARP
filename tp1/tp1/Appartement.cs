using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Appartement : Habitable
    {
        private int etage;
        private bool ascenseur;
        private bool chauffCommun;
        public Appartement(int unEtage, bool unAscenseur, bool unChauffCommun, int unNbPieces, int unNbChambre, bool uneCave, bool unParking, string unNom, int uneValeur, string uneAdresse, int uneSurface) : base(unNbPieces, unNbChambre, uneCave, unParking, unNom, uneValeur, uneAdresse, uneSurface)
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

        public bool getAscenseur()
        {
            return this.ascenseur;
        }

        public void setAscenseur(bool unAscenseur)
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

        public override string ToString()
        {
            string cave = "Non";
            if (this.getCave() == true)
            {
                cave = "Oui";
            }

            string parking = "Non";
            if (this.getParking() == true)
            {
                parking = "Oui";
            }

            string ascenseur = "Non";
            if (this.getAscenseur() == true)
            {
                parking = "Oui";
            }

            string chauffageCommun = "Non";
            if (this.getChauffCommun() == true)
            {
                parking = "Oui";
            }

            return "=========== " + this.getNom() + " ===========" +
                   "\nAdresse : " + this.getAdresse() +
                   "\nValeur : " + this.getValeur() +
                   "\nSurface : " + this.getSurface() +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €" +
                   "\nNombre de pièces : " + this.getNbPieces() +
                   "\nNombre de chambres : " + this.getNbChambre() +
                   "\nCaves : " + cave +
                   "\nParking : " + parking +
                   "\nAscenseur : " + ascenseur +
                   "\nChauffage Commun : " + chauffageCommun;
        }
    }
}
