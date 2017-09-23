using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    public class Whisker : IEquatable<Whisker>, IComparable<Whisker>
    {
        public bool connected_to_orbit = true;

        public int WhiskerValue { get; set; }

        public int ConnectedValue { get; set; }

        public override string ToString()
        {
            return WhiskerValue + " -> " + ConnectedValue;
        }

        public override bool Equals (object obj)
        {
            if (obj == null) return false;
            Whisker objAsWhisker = obj as Whisker;
            if (objAsWhisker == null) return false;
            else return Equals(objAsWhisker);
        }

        public int CompareTo (Whisker compareWhisker)
        {
            if (compareWhisker == null)
                return 1;
            else
                return this.ConnectedValue.CompareTo(compareWhisker.ConnectedValue);
        }

        public override int GetHashCode()
        {
            return ConnectedValue;
        }

        public bool Equals (Whisker other)
        {
            if (other == null) return false;
            return (this.ConnectedValue.Equals(other.ConnectedValue));
        }
    }
}
