using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n, k;
            bool all_real, odd, even;
            all_real = odd = even = false;

            Console.WriteLine("For the equation: [ Ax^2 + Bx + C ] mod N^K");
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter K: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Orbit_Generator test = new Orbit_Generator(a, b, c, n, k, true, false, false);
            test.Print_Inverses();
            test.Generate_Orbit();
            test.Print_Orbits();
        }
    }
}
