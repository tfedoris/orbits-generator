using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    public class Orbit : IEquatable<Orbit>, IComparable<Orbit>
    {
        public List<int> elements;
        public int whisker_count;
        public int cycles;

        public Orbit()
        {
            elements = new List<int>();
            whisker_count = 0;
            cycles = 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Orbit objAsOrbit = obj as Orbit;
            if (objAsOrbit == null) return false;
            else return Equals(objAsOrbit);
        }

        public int CompareTo(Orbit compareOrbit)
        {
            if (compareOrbit == null)
                return 1;
            else
                return this.cycles.CompareTo(compareOrbit.cycles);
        }

        public override int GetHashCode()
        {
            return cycles;
        }

        public bool Equals(Orbit other)
        {
            if (other == null) return false;
            return (this.cycles.Equals(other.cycles));
        }
    }
}
