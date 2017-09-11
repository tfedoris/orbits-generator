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
            Orbit_Generator test = new Orbit_Generator(1, 3, 1, 2, 7, false, false, true);
            test.Generate_Orbit();
            test.Print_Orbits();
        }
    }
}
