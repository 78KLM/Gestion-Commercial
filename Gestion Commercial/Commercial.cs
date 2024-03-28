using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial
{
    internal class Commercial
    {
        private string prenom;
        private string nom;
        private int anneNaissance;
        private Categorie categorie;
        private Service service;

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public int AnneNaissance { get => anneNaissance; set => anneNaissance = value; }
        internal Categorie Categorie { get => categorie; set => categorie = value; }
        internal Service Service { get => service; set => service = value; }

        public Commercial(string prenom, string nom, int anneNaissanc,Categorie categorie, Service service)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.anneNaissance= anneNaissanc;
            this.categorie = categorie;
            this.service = service;
            service.ajouterCom(this);
        }

        public Commercial()
        {
            
        }

        

        public int calculAge()
        {
           int age = DateTime.Now.Year - this.anneNaissance;

            return age;
        }

        public override string ToString()
        {
            string msg = ("\nNom:  " + this.nom + "\nPrénom: " + this.prenom + "\nAnnée de naissance " + this.anneNaissance + "\nCe commercial a donc " + calculAge() + " ans.\n" + this.categorie);
            return msg;
        }

        public void compare(Commercial com)
        {
            if (com.nom == this.nom ) 
            {
                Console.WriteLine("Le nom de familles des deux commerciaux sont simmilaire");
                return;
            }
            else
            {
                Console.WriteLine("Le nom de famille des deux commerciaux sont pas simmilaire");
                return;
            }
        }
    }
}
