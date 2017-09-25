using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = float.Parse(Console.ReadLine());
            var height = float.Parse(Console.ReadLine());
            var area = weight * height;
            Console.WriteLine($"{area:F2}");
        }
    }
}
