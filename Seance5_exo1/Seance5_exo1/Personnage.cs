using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance5_exo1
{
    public abstract class Personnage
    {
        private int Point_de_vie;
        private int pvMax;
        private Arme Arme_perso;
        private string arme;
        private string nom;
        private string nom_arme;
        private int degat;
        private static int NbPerso = 0;
        private static int g, b, d, h;

        public int Point_de_vie1 { get => Point_de_vie; set => Point_de_vie = value; }
        public int PvMax { get => pvMax; set => pvMax = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Nom_arme { get => nom_arme; set => nom_arme = value; }
        public int Degat { get => degat; set => degat = value; }
        public static int NbPerso1 { get => NbPerso; set => NbPerso = value; }
        public string Arme { get => arme; set => arme = value; }
        internal Arme Arme_perso1 { get => Arme_perso; set => Arme_perso = value; }
        public static int G { get => g; set => g = value; }
        public static int B { get => b; set => b = value; }
        public static int D { get => d; set => d = value; }
        public static int H { get => h; set => h = value; }

        public Personnage(string nom, int Point_de_vie)
        {
             NbPerso1++;

            Console.Write("Arme de "+nom +" : ");

            nom_arme = Console.ReadLine();

            Arme Arme_perso = new Arme(nom_arme);

            this.Point_de_vie1 = Point_de_vie;
            this.PvMax = Point_de_vie;
            this.Nom = nom;
            this.Arme = Arme_perso.Nom;
            this.Degat = Arme_perso.Degat_arme;
        }

         abstract public void heal();
        /*
            Console.WriteLine();

            if (Point_de_vie1 == 1)
            {
                Console.WriteLine(Nom + " mangez une pomme et gagne 1 HP");

                Point_de_vie1++;

                Point_de_vie1 = (int)Math.Pow(Point_de_vie1, Point_de_vie1);
                Point_de_vie1 = (int)Math.Pow(Point_de_vie1, 2);
            }
            else
            {
                Console.WriteLine(Nom + " mange une pomme et gagne 1 HP");

                Point_de_vie1++;
            }

            if(Point_de_vie1 > PvMax)
            {
                PvMax = Point_de_vie1;
            }

            Console.WriteLine("Il reste " + Point_de_vie1.ToString() + " / " + PvMax.ToString() + " HP à " + Nom);

            Console.WriteLine();
            */


        abstract public void lecture();
        /*

            Console.WriteLine();

            Console.WriteLine("Personnage " + NbPerso1.ToString() + " : ");

            Console.WriteLine("Point de vie : " + Point_de_vie1.ToString() +" / "+PvMax.ToString()+" HP");
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Votre arme : " + Arme);

            Console.WriteLine("dégâts : {0}", Degat);

            Console.WriteLine();
            */


        abstract public string attaque(Personnage victime);
        /*
            Console.WriteLine(Nom + " attaque " + victime.Nom);

            victime.Point_de_vie1 = victime.Point_de_vie1 - Degat;

            Console.WriteLine(victime.Nom + " possède encore " + victime.Point_de_vie1 +" / "+victime.PvMax.ToString()+ " HP");

            return ("Bien joué");
        */


        abstract public void SeDeplace();
        /*
            int choix = 0;

            Console.WriteLine();

            Console.WriteLine("Où " + Nom + " voudrait aller : ");
            Console.WriteLine("1. A gauche");
            Console.WriteLine("2. A droite");
            Console.WriteLine("3. En haut");
            Console.WriteLine("4. En bas");

            do
            {

                choix = Int32.Parse(Console.ReadLine());

                switch (choix)
                {

                    case 1: g++; Console.WriteLine(Nom + " avance à gauche de " + g.ToString() + " pas"); Console.WriteLine(); break;

                    case 2: d++; Console.WriteLine(Nom + " avance à droite de " + d.ToString() + " pas"); Console.WriteLine(); break;

                    case 3: h++; Console.WriteLine(Nom + " avance tout droit de " + h.ToString() + " pas"); Console.WriteLine(); break;

                    case 4: b++; Console.WriteLine(Nom + " recule de " + b.ToString() + " pas"); Console.WriteLine(); break;

                    default: choix = 0; Console.WriteLine("Veuillez entrez 1,2,3 ou 4"); Console.WriteLine(); break;

                }

                Console.WriteLine();

            } while (choix == 0);
        */

         public virtual void SePresente()
        {
            
        }

         public virtual void SeProtege()
        {
          
        }
    
    }
}
