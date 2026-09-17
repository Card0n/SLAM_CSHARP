using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Box : Bien
    {
        public Box(string unNom, int uneValeur, string uneAdresse, int uneSurface):base(unNom, uneValeur, uneAdresse, uneSurface)
        {
        }

        public override string ToString()
        {
            return "=========== " + this.getNom() + " ===========" +
                   "\nAdresse : " + this.getAdresse() +
                   "\nValeur : " + this.getValeur() +
                   "\nSurface : " + this.getSurface() +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €";
        }
    }
}
