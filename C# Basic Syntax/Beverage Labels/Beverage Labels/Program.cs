using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energycontentPer100ml = double.Parse(Console.ReadLine());
            var sugarcontentPer100ml = double.Parse(Console.ReadLine());
           
            var kkal = energycontentPer100ml * volume/100;
            var sugar = sugarcontentPer100ml * volume/100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kkal}kcal, {sugar}g sugars");
        }
    }
}
