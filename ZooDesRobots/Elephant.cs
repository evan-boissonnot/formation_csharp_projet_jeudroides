using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    public class Elephant : Animal
    {
        public decimal LongueurDeLaTrompe = 200.5M;

        public override void Dormir()
        {
            Console.WriteLine("Je dors dans la savane, et je suis gigantesque");
            
        }
    }
}
