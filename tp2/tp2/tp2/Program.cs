namespace tp2
{
    public class Program
    {
        
        static void Main()
        {
            List<int> nombres = new List<int>() { 22, 85, 17, 59, 30};
            ajouterAleatoire(nombres);
            foreach (int nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            foreach (int nombre in ajouterAleatoire(nombres))
            {
                Console.WriteLine(nombre);
            }
        }

        public static List<int> ajouterAleatoire(List<int> listeNombres)
        {
            List<int> listeNombresClone = listeNombres.ToList();
            Random random = new Random();
            listeNombresClone.Add(random.Next(101));

            return listeNombresClone;
        }
    }
}
