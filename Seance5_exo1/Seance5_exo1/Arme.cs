using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance5_exo1
{
    class Arme
    {
        private string nom;

        private int degat_arme;

        public Arme(string nom)
        {
            this.Nom = nom;

            if(nom == "Lance")
                this.Degat_arme = 3;
            else if(nom == "Epee")
                this.Degat_arme = 4;
            else if(nom =="Arc")
                this.Degat_arme = 3;
            else if(nom =="Baton")
                this.Degat_arme = 0;
            else if(nom =="Poing")
                this.Degat_arme = 1;
            else
                this.Degat_arme = 3;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Degat_arme { get => degat_arme; set => degat_arme = value; }
    }
}
