using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Maison : Habitable
    {
        public int MaisonId {  get; set; }
        public Maison(int unNbPieces, int unNbChambre, bool uneCave, bool unParking, string unNom, int uneValeur, string uneAdresse, int uneSurface) 
            :base(unNbPieces, unNbChambre, uneCave, unParking, unNom, uneValeur, uneAdresse, uneSurface)
        {

        }

        public override string ToString()
        {
            string cave = "Non";
            if (this.Cave == true) {
                cave = "Oui";
            }

            string parking = "Non";
            if (this.Parking == true) {
                parking = "Oui";
            }

            return "=========== " + this.Nom + " ===========" +
                   "\nAdresse : " + this.Adresse +
                   "\nValeur : " + this.Valeur +
                   "\nSurface : " + this.Surface +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €" +
                   "\nNombre de pièces : " + this.NbPieces +
                   "\nNombre de chambres : " + this.NbChambre +
                   "\nNombre de caves : " + cave +
                   "\nNombre de parking : " + parking;
        }
    }
}
