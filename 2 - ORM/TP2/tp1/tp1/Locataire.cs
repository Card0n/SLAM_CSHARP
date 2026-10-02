using System.Globalization;

namespace tp1
{
    public class Locataire
    {
        public int LocataireId {  get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }

        public Locataire()
        {

        }
        public Locataire(string unNom, string unPrenom, int unAge, string uneProfession)
        {
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Age = unAge;
            this.Profession = uneProfession;
        }

        public override string ToString()
        {
            return "=== Locataire\n " + 
                    this.Nom + " " + this.Prenom + " - " + this.Age + " ans - " + this.Profession;

        }
    }
}
