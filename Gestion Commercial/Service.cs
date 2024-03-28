using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial
{
    internal class Service
    {
        private string nom;
        private Commercial[] tabcom;
        private int effectif;

        public string Nom { get => nom; set => nom = value; }
        internal Commercial[] Tabcom { get => tabcom; set => tabcom = value; }
        public int Effectif { get => effectif; set => effectif = value; }

        public Service(string nom)
        {
            this.nom = nom;
            this.Effectif = 0;   
            tabcom = new Commercial[10];
        }

        public Service()
        {
            
        }

        public void ajouterCom(Commercial c)
        {
 
                tabcom[this.effectif] = c;
                this.effectif++;

            
        }        public Commercial ComLePlusVieux()
        {
            Commercial vieux = null;
            foreach (Commercial com in tabcom)
            {
                if (com != null && (vieux == null || com.calculAge() > vieux.calculAge()))
                {
                    vieux = com;
                }
            }

            return vieux;
        }






        public override string ToString()
        {
            string info = "Service " + this.nom + "\n Commerciaux \n";
            foreach (Commercial element in tabcom)
            {
                if (element != null)
                {
                    info += element.ToString() + "\n";
                }
                
            }
            





            return info;
        }
    }
}
