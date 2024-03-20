namespace Gestion_Commercial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Commercial c1 = new Commercial("Stéphane","Rolland",1990);
            Console.WriteLine(c1);
            Commercial c2 = new Commercial("cheikh", "Rolland", 2005);
            Console.WriteLine(c2);
            c1.compare(c2);

            Categorie ca1 = new Categorie("1234", "papa");
            Console.WriteLine(ca1);
            Categorie ca2 = new Categorie("4321", "maman");
            Console.WriteLine(ca2);
        }
    }
}