using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingradients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingradients = Console.ReadLine();
            int numberIngr = 0;
            while (ingradients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingradients}.");
                ingradients = Console.ReadLine();
                numberIngr += 1;


            }
            Console.WriteLine($"Preparing cake with {numberIngr} ingredients.");
        }
    }
}
