namespace fibonacci
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<int, int> dictNombres = new Dictionary<int, int>();
            Console.WriteLine(fibonacci(6,dictNombres));
        }

        public static int fibonacci(int n, Dictionary<int, int> dictNombres)
        {


            if (dictNombres.ContainsKey(n))
            {
                return dictNombres[n];
            }

            else
            {
                if (n == 0)
                {
                    return 0;
                }

                else if (n == 1)
                {
                    return 1;
                }

                else
                {
                    int resultat = fibonacci(n - 1,dictNombres) + fibonacci(n - 2, dictNombres);
                    dictNombres.Add(n, resultat);
                    return resultat;
                }
            }

        }
    }
}
