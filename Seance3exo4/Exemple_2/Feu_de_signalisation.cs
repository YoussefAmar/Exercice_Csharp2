using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple2
{

    class ExceptionString : Exception
    {
        public ExceptionString(string message) : base(message)
        {
        }

    }
    class Feu_de_signalisation
    {
        //Champ = variable au niveau de la classe
        //Attribut = état d'un objet à un moment donné

        public int couleur = 0;
        public int position;
        public int hauteur;

        //Constructeur
        //Sans argument

        public Feu_de_signalisation()
        {
            couleur = 1;
            position = 45;
            hauteur = 7;

            Console.WriteLine("Passage dans constructeur par défaut");
        }
        // Surcharge du constructeur (même nom pour les 2)
        public Feu_de_signalisation(int couleur)
        {

            this.couleur = couleur;
            this.position = 45;
            this.hauteur = 7;

            Console.WriteLine("Passage dans constructeur à un argument");

        }

        //Surchage du constructeur ( 3 arguments)
        //à utiliser dans le programme principal

        //Constructeur

        public Feu_de_signalisation(int couleur, int position, int hauteur)
        {
            this.couleur = couleur;
            this.position = position;
            this.hauteur = hauteur;

            Console.WriteLine("Passage dans constructeur à 3 arguments");

        }

        //Méthodes 
        //Change

        public void change()
        {
            int choice;

            try
            {
                Console.WriteLine("Voulez vous choisir ou pas? 1/Oui : 2/Non");
                choice = Int32.Parse(Console.ReadLine());

                if (choice <= 0 || choice > 2) throw new ExceptionString("1 ou 2");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Nombre hors limite");
                Console.WriteLine("Par défaut : 1");
                choice = 1;
            }
            catch(FormatException b)
            {
                Console.WriteLine(b.ToString());
                Console.WriteLine("Pas de lettre");
                choice = 2;
                
            }

            if (choice == 2)

                couleur = couleur + 1;
            else if (choice == 1)
                couleur = choisir();

            if (couleur == 4) couleur = 1;

            if (couleur == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

            if (couleur == 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

            if (couleur == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public void clignote()
        {
            Console.WriteLine("Clignotant 1");

            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("O");
            }
        }

        public void clignote(int a)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Clignotant 2");

            for (int i = 0; i < a; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O");
            }
        }
        public int choisir()
        {
            int choix;

            Console.Write("Numero du feu : ");

            choix = Int32.Parse(Console.ReadLine());

            return (choix);

        }
        //couleur de fon de la console = backgroundColor
        //couleur d'affichage = ForegroundColor
        //Positionner le curseur à un endroit déterminé = SetCursorPosition(num_colonne, num_ligne);

    }
}
