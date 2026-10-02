using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Box : Bien
    {
        public int BoxId {  get; set; }

        public Box()
        {

        }
        public Box(string unNom, int uneValeur, string uneAdresse, int uneSurface):base(unNom, uneValeur, uneAdresse, uneSurface)
        {
        }

        public override string ToString()
        {
            return "=========== " + this.Nom + " ===========" +
                   "\nAdresse : " + this.Adresse +
                   "\nValeur : " + this.Valeur +
                   "\nSurface : " + this.Surface +
                   "\nBénéfice net : " + calculerRentabiliteNetMensuel() + " €";
        }
    }
}
