using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    public class Animal
    {
        public int NbMembres = 18;
        public bool AUneBouche = true;

        private string Nom;

        //public Animal(string nom, TypeAnimal typeAnimal)
        //{
        //    Nom = nom;
        //    Type = typeAnimal;
        //}

        public void Manger(string maNourriture)
        {
            Console.WriteLine("Je mange :" +  maNourriture);
        }

        public virtual void Dormir()
        {
            Console.WriteLine("Je dors comme un animal, et je vous em...");
        }

        public void Dormir(string message)
        {

        }
    }
    
}
