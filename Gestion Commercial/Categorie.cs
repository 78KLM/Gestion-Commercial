using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Commercial
{
    internal class Categorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Categorie(string codeCategorie, string libCategorie)
        {
            this.codeCategorie = codeCategorie;
            this.libCategorie = libCategorie;
        }

        public Categorie()
        {
            
        }
        public override string ToString()
        {
            string msg = ("\nLe code de la catégorie est:  " + this.codeCategorie + "\nLe libellé de la catégorie est: " + this.libCategorie);
            return msg;
        }
    }
}
