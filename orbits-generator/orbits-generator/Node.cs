using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    class Node
    {
        public int value;
        public bool is_whisker;
        public Node connected_node;

        public Node()
        {
            value = 0;
            connected_node = null;
            is_whisker = false;
        }
    }
}
