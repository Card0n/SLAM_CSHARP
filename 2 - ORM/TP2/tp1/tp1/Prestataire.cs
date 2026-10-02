using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Prestataire
    {
        private string raisonSociale {  get; set; }
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private string Telephone { get; set; }
        private string Adresse { get; set; }

        public Prestataire(string uneRaisonSociale, string unNom, string unPrenom, string unTelephone, string uneAdresse)
        {
            this.raisonSociale = uneRaisonSociale;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Telephone = unTelephone;
            this.Adresse = uneAdresse;
        }


    }
}
