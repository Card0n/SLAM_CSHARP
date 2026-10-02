using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Appartement : Habitable
    {
        public int AppartementId { get; set; }
        public int Etage { get; set; }
        public bool Ascenseur { get; set; }
        public bool ChauffCommun { get; set; }
        public Appartement()
        {
            
        }
        public Appartement(int unEtage, bool unAscenseur, bool unChauffCommun, int unNbPieces, int unNbChambre, bool uneCave, bool unParking, string unNom, int uneValeur, string uneAdresse, int uneSurface) : base(unNbPieces, unNbChambre, uneCave, unParking, unNom, uneValeur, uneAdresse, uneSurface)
        {
            this.Etage = unEtage;
            this.Ascenseur = unAscenseur;
            this.ChauffCommun = unChauffCommun;
        }


        public override int estimationBien()
        {
            int valeurTotal = base.estimationBien();
            if (this.Ascenseur == true)
            {
                valeurTotal += 5000;
            }

            if (this.ChauffCommun == true)
            {
                valeurTotal += 6500;
            }
            
            if (this.Etage == 0)
            {
                valeurTotal -= 3000;
            }
            return valeurTotal;
        }

        public override string ToString()
        {
            string cave = "Non";
            if (this.Cave == true)
            {
                cave = "Oui";
            }

            string parking = "Non";
            if (this.Parking == true)
            {
                parking = "Oui";
            }

            string Ascenseur = "Non";
            if (this.Ascenseur == true)
            {
                parking = "Oui";
            }

            string chauffageCommun = "Non";
            if (this.ChauffCommun == true)
            {
                parking = "Oui";
            }

            return "=========== " + this.Nom + " ===========" +
                   "\nAdresse : " + this.Adresse +
                   "\nValeur : " + this.Valeur +
                   "\nSurface : " + this.Surface +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €" +
                   "\nNombre de pièces : " + this.NbPieces +
                   "\nNombre de chambres : " + this.NbChambre +
                   "\nCaves : " + cave +
                   "\nParking : " + parking +
                   "\nAscenseur : " + Ascenseur +
                   "\nChauffage Commun : " + chauffageCommun;
        }

        

    }
}
