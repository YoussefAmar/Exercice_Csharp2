using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Seance5_exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerrier Roy = new Guerrier("Roy", 30); 

            Lancier Lancer = new Lancier("Lancer",20);

            Magicien Robin = new Magicien("Robin",10); 

            Moine Falcon = new Moine("Falcon", 20);

            Mob Ennemi = new Mob("Ogre",100);
            
            ArrayList Groupe = new ArrayList();
            Groupe.Add(Roy);
            Groupe.Add(Lancer);
            Groupe.Add(Robin);
            Groupe.Add(Falcon);

            Console.ReadLine();

            Ennemi.attaque(Roy);
            Lancer.heal();
            Robin.heal();

            Console.ReadLine();

            do
                {
            Falcon.attaque(Ennemi);
            Ennemi.attaque(Falcon);
                }
            while(Falcon.Point_de_vie1 > 0 && Ennemi.Point_de_vie1 > 0);

            Falcon.heal();

            Console.ReadLine();

            Lancer.SeProtege();
            Robin.SeDeplace();
            Falcon.SeDeplace();
            Falcon.SeDeplace();

            Console.ReadLine();

            Console.WriteLine(Roy.attaque(Robin));


            foreach (Personnage element in Groupe)
            {
                Console.WriteLine("Equipe : ");

                element.lecture();

                element.SePresente();

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

