using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur
{
    class Program
    {
        static int somme (int t1, int t2)
        { 
         return t1 + t2;
        }
        
        static int produit(int t1, int t2)
        {
            return t1 * t2;
        }

        static void Main(string[] args)
        {
            int a = somme(5, 3);
            int b = somme(18, 8);
            Console.WriteLine("la somme est egale à " +a);
            
            Console.WriteLine("la somme est egale à " + b);
            int c = 3 * 8;
            Console.WriteLine("le produit est egale à " + c);
            int d = 18 * 27;
            Console.WriteLine("le produit est egale à " + d);
        }
    }
}
