$using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Prestataire
    {
        private string raisonSociale;
        private string nom;
        private string prenom;
        private string telephone;
        private string adresse;

        public Prestataire(string uneRaisonSociale, string unNom, string unPrenom, string unTelephone, string uneAdresse)
        {
            this.raisonSociale = uneRaisonSociale;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.telephone = unTelephone;
            this.adresse = uneAdresse;
        }

        public string getRaisonSociale()
        {
            return this.raisonSociale;
        }

        public void setRaisonSociale(string uneRaisonSociale)
        {
            this.raisonSociale = uneRaisonSociale;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setNom(string unNom)
        {
            this.nom = unNom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public void setPrenom(string unPrenom)
        {
            this.prenom = unPrenom;
        }

        public string getTelephone()
        {
            return this.telephone;
        }

        public void setTelephone(string unTelephone)
        {
            this.telephone = unTelephone;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public void setAdresse(string uneAdresse)
        {
            this.adresse = uneAdresse;
        }
    }
}
