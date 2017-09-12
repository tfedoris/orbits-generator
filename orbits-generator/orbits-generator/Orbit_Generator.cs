using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    class Orbit_Generator
    {
        private int a, b, c, n; //variables for (ax^2 + bx + c) % n
        private int start_pos;
        private int offset;
        private bool all_real, even, odd;
        private List<Orbit> orbits;
        private List<int> series;

        Orbit_Generator()
        {
            a = b = c = n = 0;
            start_pos = 0;
            offset = 0;
            all_real = even = odd = false;
            orbits = null;
            series = null;
        }

        public Orbit_Generator(int a, int b, int c, int n, int k, bool all_real, bool even, bool odd)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.n = (int)Math.Pow(n, k);
            this.all_real = all_real;
            this.even = even;
            this.odd = odd;
            orbits = new List<Orbit>();
            series = new List<int>();

            if (all_real)
            {
                start_pos = 0;
                offset = 1;
            }
            else if (odd)
            {
                start_pos = 1;
                offset = 2;
            }
            else if (even)
            {
                start_pos = 2;
                offset = 2;
            }

            Series_Init();
        }

        public void Generate_Orbit()
        {
            Orbit current_orbit = new Orbit();
            current_orbit.elements = new List<int>();
            current_orbit.cycles = 0;
            int next_element = int.MinValue;
            int current_element;

            current_orbit.elements.Add(start_pos);
            current_element = start_pos;

            while (series.Count > 0)
            {
                if (series.Exists(s => s.Equals(current_element))) series.Remove(current_element);

                next_element = (a * (int)Math.Pow(current_element, 2)) + (b * current_element) + c;
                next_element %= n;

                if (next_element != start_pos && next_element <= n)
                {
                    current_orbit.elements.Add(next_element);
                    current_orbit.cycles++;
                    current_element = next_element;
                }
                else if (next_element == start_pos)
                {
                    current_orbit.elements.Add(start_pos);
                    current_orbit.cycles++;
                    orbits.Add(current_orbit);

                    if (series.Count > 0)
                    {
                        start_pos = series[0];
                        current_element = start_pos;
                        Generate_Orbit();
                    }
                    return;
                }
            }
            return;
        }

        private void Series_Init()
        {
            int i = start_pos;
            while (i <= n)
            {
                series.Add(i);
                i += offset;
            }
        }

        public void Print_Orbits()
        {
            foreach (var orbit in orbits)
            {
                Console.WriteLine("Orbit:");
                int orbit_size = orbit.elements.Count;
                int element_place = 0;
                foreach(var element in orbit.elements)
                {
                    element_place++;
                    Console.Write(element);
                    if (element_place < orbit_size) Console.Write(" -> ");
                    else Console.Write("\n");
                    if (element_place % 10 == 0) Console.WriteLine();
                }
                Console.WriteLine($"Orbit Size: {orbit.cycles} cycles\n");
            }
        }

        public void Print_Inverses()
        {
            Console.WriteLine("Inverses:");
            for (int i = 1; i < series.Count; i++)
            {
                for (int j = 0; j < series.Count; j++)
                {
                    if ((series[i] * series[j]) % n == 1)
                    {
                        Console.WriteLine($"{series[i]} <-> {series[j]}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
