using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    public class Orbit
    {
        public List<int> elements;
        public int whisker_count;

        public Orbit()
        {
            elements = new List<int>();
            whisker_count = 0;
        }
    }
}
