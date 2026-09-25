using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Habitable : Bien
    {
        private int nbPieces;
        private int nbChambre;
        private bool cave;
        private bool parking;

        public Habitable(int unNbPieces, int unNbChambre, bool uneCave, bool unParking, string unNom, int uneValeur, string uneAdresse, int uneSurface) 
            :base(unNom, uneValeur, uneAdresse, uneSurface)
        {
            this.nbPieces = unNbPieces;
            this.nbChambre = unNbChambre;
            this.cave = uneCave;
            this.parking = unParking;
        }

        public override int estimationBien()
        {
            int valeurTotal = 0;
            if (this.cave == true)
            {
                valeurTotal += 5000;
            }

            if (this.parking == true)
            {
                valeurTotal += 8000;
            }
            valeurTotal += 2000 * this.nbPieces;
            return base.estimationBien();
        }

        public int getNbPieces()
        {
            return this.nbPieces;
        }

        public void setNbPieces(int unNbPieces)
        {
            this.nbPieces = unNbPieces;
        }

        public int getNbChambre()
        {
            return this.nbChambre;
        }

        public void setNbChambre(int unNbChambre)
        {
            this.nbChambre = unNbChambre;
        }

        public bool getCave()
        {
            return this.cave;
        }

        public void setCave(bool uneCave)
        {
            this.cave = uneCave;
        }

        public bool getParking()
        {
            return this.parking;
        }

        public void setParking(bool unParking)
        {
            this.parking = unParking;
        }
    }
}