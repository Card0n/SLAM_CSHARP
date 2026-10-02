using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Habitable : Bien
    {
        public int HabitableId {  get; set; }
        public int NbPieces { get; set; }
        public int NbChambre { get; set; }
        public bool Cave { get; set; }
        public bool Parking { get; set; }

        public Habitable()
        {

        }
        public Habitable(int unNbPieces, int unNbChambre, bool uneCave, bool unParking, string unNom, int uneValeur, string uneAdresse, int uneSurface) 
            :base(unNom, uneValeur, uneAdresse, uneSurface)
        {
            this.NbPieces = unNbPieces;
            this.NbChambre = unNbChambre;
            this.Cave = uneCave;
            this.Parking = unParking;
        }

        public override int estimationBien()
        {
            int valeurTotal = 0;
            if (this.Cave == true)
            {
                valeurTotal += 5000;
            }

            if (this.Parking == true)
            {
                valeurTotal += 8000;
            }
            valeurTotal += 2000 * this.NbPieces;
            return base.estimationBien() + valeurTotal;
        }

        
    }
}