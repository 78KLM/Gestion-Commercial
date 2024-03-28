namespace Gestion_Commercial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Categorie ca1 = new Categorie("1234", "papa");
            Categorie ca2 = new Categorie("4321", "maman");

            Service s1 = new Service("National");
            Service s2 = new Service("International");


            Commercial c1 = new Commercial("Stéphane", "Rolland", 1990, ca1,s1);
            Commercial c2 = new Commercial("cheikh", "Rolland", 2005, ca2,s1);
            Commercial c3 = new Commercial("Yazid", "Aourak", 2005, ca2,s1);

            Commercial c4 = new Commercial("tom", "boulec", 2005, ca1,s2);
            Commercial c5 = new Commercial("thomas", "boulec", 2005, ca2,s2);
            Commercial c6 = new Commercial("moussa", "Diarra", 2005, ca2,s2);
           


            Console.WriteLine("=====================================================================");

            
            Console.WriteLine("voici le "+s1);
            
            Console.WriteLine("voici le " + s2);


            c1.compare(c2);
            Console.WriteLine("\nLe commercial le plus vieux est: \n"+s1.ComLePlusVieux());
            Console.ReadLine();


        }
    }
}