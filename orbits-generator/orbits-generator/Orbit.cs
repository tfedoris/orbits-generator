using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    public class Orbit : IEquatable<Orbit>, IComparable<Orbit>
    {
        private List<Node> elements;
        public int whisker_count;
        public int cycles;

        internal List<Node> Elements { get => elements; set => elements = value; }

        public Orbit()
        {
            Elements = new List<Node>();
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
