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
            Orbit_Generator test = new Orbit_Generator(0, 7, 1, 16, 1, true, false, false);
            test.Generate_Orbit();
            test.Print_Orbits();
        }
    }
}
