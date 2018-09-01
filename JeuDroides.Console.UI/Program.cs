using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDroides.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string maChaine = "";
            string nomJedi = "Rey";

            maChaine = "Il était une fois dans une galaxie lointaine... très lointaine... ";
            //System.Console.WriteLine(maChaine);

            //System.Console.WriteLine("Un(e) jeune jedi");
            //System.Console.WriteLine(nomJedi);
            //System.Console.WriteLine("se prépare ...");


            //System.Console.Write("Un(e) jeune jedi ");
            //System.Console.Write(nomJedi);
            //System.Console.Write(" se prépare ...");


            string debut = "Un";
            string sexe = "";



            //int i = 0;
            //while(i < 10)
            //{
            //    System.Console.WriteLine(i + ". Ah que coucou");
            //    i = i + 1;
            //}

            //int[] monTableauEntiers = new int[10];
            string[] tableauEspeces = Enum.GetNames(typeof(TypeEspece));

            for (int i = 0; i < tableauEspeces.Length; i++)
            {
                string especeCourante = tableauEspeces[i];

                TypeEspece monType =  (TypeEspece) Enum.Parse(typeof(TypeEspece), especeCourante);

                int maValeurEspece = (int)monType;

                System.Console.Write(" id: " + maValeurEspece + "      " + especeCourante);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    System.Console.WriteLine("la valeur à l'index " + i + 
            //                             " du tableau est : " + monTableauEntiers[i]);
            //}
            string nomJoueur = "";
            System.Console.WriteLine("<bonjour, quel est le nom de ton personnage?");
            nomJoueur = System.Console.ReadLine();

            System.Console.WriteLine("Super!! ton personnage s'appelle : " + nomJoueur.ToUpper());

                

            string maValeur = "ah que cucu";
            string maValeur2 = maValeur.ToUpper();

            while ((sexe != "H") && (sexe != "F"))
            {
                
          
                System.Console.WriteLine("Quel est votre sexe ? (Valeurs attendues : H ou F)");
                sexe = System.Console.ReadLine();
                
            }

            System.Console.ForegroundColor = ConsoleColor.Green;
            if (sexe == "F")
            {
                debut = debut + "e";
                System.Console.WriteLine("Vous avez bien saisi F");
            }
            else
            {
                System.Console.WriteLine("Vous avez bien saisi H");
            }
            
            System.Console.ResetColor();


            maChaine = maChaine + debut + " jeune jedi : ";
            maChaine = maChaine + nomJedi;

            System.Console.WriteLine(maChaine);




            string uneNouvelleChaine = "va";

            //string uneSecondeNouvelleChaine = "ca " + uneNouvelleChaine + ", tu vas bien ?";

            string uneSecondeNouvelleChaine = $"ca {uneNouvelleChaine} , tu vas bien ?";


            //System.Console.ReadLine();
        }
    }
}
