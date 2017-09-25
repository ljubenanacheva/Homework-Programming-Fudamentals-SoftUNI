using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            var helath = maximumHealth - currentHealth;
            var energy = maximumEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', helath));
            Console.WriteLine('|');

            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', energy));
            Console.WriteLine('|');






        }
    }
}
