using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    class Program
    {
        //static Animal InitialiserAnimal(bool aUneBouche, int nbMembres, 
        //                                string nom, TypeAnimal type)
        //{
        //    Animal monPremierAnimal = new Animal();

        //    monPremierAnimal.AUneBouche = aUneBouche;
        //    monPremierAnimal.NbMembres = nbMembres;
          
        //    return monPremierAnimal;
        //}

        static void Main(string[] args)
        {
            Animal monPremierAnimal =  new Animal();
            Elephant elephant = new Elephant();
            Humain humain = new Humain();

            monPremierAnimal.Dormir();
            elephant.Dormir();
            humain.Dormir();



            Humain[] h = new Humain[10];

            h[0] = new Humain();
            h[1] = new Humain();

            for (int i = 0; i < h.Length; i++)
            {
                if(h[i] != null)
                {
                    h[i].Dormir();
                }

                h[i]?.Dormir();
            }

            foreach (var hum in h)
            {
                if(hum != null)
                    hum.Dormir();

                hum?.Dormir();
            }


            int[] essai = new int[10];
            Console.WriteLine("ee :" + essai[3]);

            List<int> essai2list = new List<int>();
            essai2list.Add(3);
            essai2list.Add(5012);
            essai2list.Add(-7);
            essai2list.Add(57);
            essai2list.Add(42);

            essai2list.Remove(5012);


            int somme = essai2list.Sum();
            Console.WriteLine(somme);

            Console.WriteLine(essai2list.Max());
            Console.WriteLine(essai2list.Min());
            Console.WriteLine(essai2list.Average());


            List<Animal> list = new List<Animal>();

            list.Add(new Humain());
            list.Add(new Elephant());
            list.Add(new Humain());
            list.Add(new Elephant());
            list.Add(new Humain());
            list.Add(new Elephant());

            list.Add(humain);

            foreach (var animal in list)
            {
                animal.Dormir();
            }

            //lanimalCree = InitialiserAnimal(true, 4, "Dumbo", TypeAnimal.Elephant);

            //Console.WriteLine("Le premier animal " + lanimalCree.Nom + " a une bouche ? " +
            //                  lanimalCree.AUneBouche + ", et il a aussi " +
            //                  lanimalCree.NbMembres + " membres");


            //Animal animalCree2 = InitialiserAnimal(true, 2, "Gertrude", TypeAnimal.Humain);

            //animalCree2.Manger("du pain");

            //Console.WriteLine("Le second animal " + animalCree2.Nom + " a une bouche ? " +
            //                  animalCree2.AUneBouche + ", et il a aussi " +
            //                  animalCree2.NbMembres + " membres");


            Console.ReadLine();
        }

        
    }
}
