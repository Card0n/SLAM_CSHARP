using System.Globalization;

namespace tp1
{
    public class Locataire
    {
        private string nom;
        private string prenom;
        private int age;
        private string profession;

        public Locataire(string unNom, string unPrenom, int unAge, string uneProfession)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.age = unAge;
            this.profession = uneProfession;
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

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int unAge)
        {
            this.age = unAge;
        }

        public string getProfession()
        {
            return this.profession;
        }

        public void setProfession(string uneProfession)
        {
            this.profession = uneProfession;
        }

        public override string ToString()
        {
            return "=== Locataire\n " + 
                    this.nom + " " + this.prenom + " - " + this.age + " ans - " + this.profession;

        }
    }
}
