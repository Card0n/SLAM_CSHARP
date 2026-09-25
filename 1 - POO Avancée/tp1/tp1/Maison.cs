using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Maison : Habitable
    {
        public Maison(int unNbPieces, int unNbChambre, bool uneCave, bool unParking, string unNom, int uneValeur, string uneAdresse, int uneSurface) 
            :base(unNbPieces, unNbChambre, uneCave, unParking, unNom, uneValeur, uneAdresse, uneSurface)
        {

        }

        public override string ToString()
        {
            string cave = "Non";
            if (this.getCave() == true) {
                cave = "Oui";
            }

            string parking = "Non";
            if (this.getParking() == true) {
                parking = "Oui";
            }

            return "=========== " + this.getNom() + " ===========" +
                   "\nAdresse : " + this.getAdresse() +
                   "\nValeur : " + this.getValeur() +
                   "\nSurface : " + this.getSurface() +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €" +
                   "\nNombre de pièces : " + this.getNbPieces() +
                   "\nNombre de chambres : " + this.getNbChambre() +
                   "\nNombre de caves : " + cave +
                   "\nNombre de parking : " + parking;
        }
    }
}
