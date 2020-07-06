using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance5_exo1
{
    class Magicien : Personnage
    {
       private int Mana;
       private int ManaMax = 10;

        public Magicien(string nom, int Point_de_vie) : base(nom, Point_de_vie)
        {
            this.Nom = nom;
            this.Point_de_vie1 = Point_de_vie;
            this.PvMax = Point_de_vie;

            if(this.Arme == "Baton")
                {
                  ManaMax = 20;
                }

            this.Mana = ManaMax;
        }

        public int BouleDeFeu()
        {
            int d = 0, m = 0;

            Console.WriteLine("Combien de mana voulez-vous utilisez? ");

            m = Int32.Parse(Console.ReadLine());

            Mana = Mana - m;

            d = Degat + m;

            Console.WriteLine(Nom + " lance une boule de feu qui fait " + m.ToString() + " dégâts");

            return (d);
        }

        public override void heal()
        {
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

            if (Point_de_vie1 > PvMax)
            {
                PvMax = Point_de_vie1;
            }

            Console.WriteLine("Il reste " + Point_de_vie1.ToString() + " / " + PvMax.ToString() + " HP à " + Nom);

            Console.WriteLine();
        }

        public override void lecture()
        {
            Console.WriteLine();

            Console.WriteLine("Personnage " + NbPerso1.ToString() + " : ");

            Console.WriteLine("Point de vie : " + Point_de_vie1.ToString() + " / " + PvMax.ToString() + " HP");
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Votre arme : " + Arme);

            Console.WriteLine("dégâts : {0}", Degat);

            Console.WriteLine();
        }

        public override string attaque(Personnage victime)
        {
            Console.WriteLine(Nom + " attaque " + victime.Nom);

            victime.Point_de_vie1 = victime.Point_de_vie1 - Degat;

            Console.WriteLine(victime.Nom + " possède encore " + victime.Point_de_vie1 + " / " + victime.PvMax.ToString() + " HP");

            return ("Bien joué");
        }

        public override void SeDeplace()
        {
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

                    case 1: G++; Console.WriteLine(Nom + " avance à gauche de " + G.ToString() + " pas"); Console.WriteLine(); break;

                    case 2: D++; Console.WriteLine(Nom + " avance à droite de " + D.ToString() + " pas"); Console.WriteLine(); break;

                    case 3: H++; Console.WriteLine(Nom + " avance tout droit de " + H.ToString() + " pas"); Console.WriteLine(); break;

                    case 4: B++; Console.WriteLine(Nom + " recule de " + B.ToString() + " pas"); Console.WriteLine(); break;

                    default: choix = 0; Console.WriteLine("Veuillez entrez 1,2,3 ou 4"); Console.WriteLine(); break;

                }

                Console.WriteLine();

            } while (choix == 0);
        }

        public override void SePresente()
        {

            Console.WriteLine();
            Console.WriteLine(Nom + " se présente à tout le monde");

        }

        public override void SeProtege()
        {
            Console.WriteLine();

            Console.WriteLine(Nom + " se protège avec son/sa " + Arme);
        }
    }
}
