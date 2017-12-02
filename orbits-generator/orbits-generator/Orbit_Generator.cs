using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    class Orbit_Generator
    {
        private int a, b, c, n; //variables for (ax^2 + bx + c) % n
        private Node start_node, current_node, next_node;
        private int offset;
        private bool all_real, even, odd;
        private Orbit current_orbit;
        private List<Orbit> orbits;
        private List<Whisker> whiskers;
        private List<int> series;
        private string pathString;

        Orbit_Generator()
        {
            a = b = c = n = 0;
            start_node = new Node();
            current_node = null;
            next_node = null;
            start_node.value = 0;
            offset = 0;
            all_real = even = odd = false;
            orbits = null;
            series = null;
            pathString = "";
        }

        public Orbit_Generator(int a, int b, int c, int n, int k, bool all_real, bool even, bool odd, string pathString)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.n = (int)Math.Pow(n, k);
            this.all_real = all_real;
            this.even = even;
            this.odd = odd;
            this.pathString = pathString;
            orbits = new List<Orbit>();
            whiskers = new List<Whisker>();
            series = new List<int>();

            if (!File.Exists(pathString))
            {
                using (StreamWriter sw = File.CreateText(pathString))
                {
                    sw.WriteLine($"For {a}x^2 + {b}x + {c} (mod {n}^{k}):\n");
                }
            }

            if (all_real)
            {
                start_node = new Node();
                start_node.value = 0;
                offset = 1;
            }
            else if (odd)
            {
                start_node = new Node();
                start_node.value = 1;
                offset = 2;
            }
            else if (even)
            {
                start_node = new Node();
                start_node.value = 2;
                offset = 2;
            }

            Series_Init();
        }

        public void Generate_Orbit()
        {
            current_orbit = new Orbit();

            start_node = new Node();
            start_node.value = series[0];
            current_node = start_node;
            current_orbit.Elements.Add(current_node);

            do
            {
                next_node = new Node
                {
                    value = ((a * (int)Math.Pow(current_node.value, 2)) + (b * current_node.value) + c) % n,
                };

                if (next_node.value == start_node.value)
                {
                    Close_Orbit();
                }
                else
                {
                    if (current_orbit.Elements.Exists(e => e.value.Equals(next_node.value)))
                    {
                        var start_el_index = current_orbit.Elements.FindIndex(e => e.value.Equals(start_node.value));
                        var next_el_index = current_orbit.Elements.FindIndex(e => e.value.Equals(next_node.value));
                        current_orbit.Elements.RemoveRange(start_el_index, next_el_index - start_el_index);
                        Close_Orbit();
                    }
                    else
                    {
                        bool in_orbit = false;
                        foreach (Orbit orbit in orbits)
                        {
                            if (orbit.Elements.Exists(e => e.value.Equals(next_node.value)))
                            {
                                in_orbit = true;
                                orbit.whisker_count++;
                                break;
                            }
                        }

                        if (in_orbit)
                        {
                            Create_Whisker(true);
                        }
                        else
                        {
                            bool in_whiskers = false;

                            foreach (Whisker whisker in whiskers)
                            {
                                if (whisker.WhiskerValue == next_node.value)
                                {
                                    in_whiskers = true;
                                    break;
                                }
                            }

                            if (in_whiskers)
                            {
                                Create_Whisker(false);
                            }

                            else
                            {
                                current_orbit.Elements.Add(next_node);
                                current_node.connected_node = next_node;
                                current_node = next_node;
                            }
                        }
                    }
                }
            } while (series.Count > 0);

            return;
        }

        private void Series_Init()
        {
            int i = start_node.value;
            while (i < n)
            {
                series.Add(i);
                i += offset;
            }
        }

        public void Print_Orbits()
        {
            foreach (var orbit in orbits)
            {
                orbit.cycles = orbit.Elements.Count - 1;
            }

            orbits.Sort();

            foreach (var orbit in orbits)
            {
                using (StreamWriter sw = File.AppendText(pathString))
                {
                    sw.WriteLine("\nOrbit:");
                    int orbit_size = orbit.Elements.Count;
                    int element_place = 0;
                    foreach (var element in orbit.Elements)
                    {
                        element_place++;
                        sw.Write(element.value);
                        if (element_place < orbit_size) sw.Write(" -> ");
                        else sw.Write("\n");
                        if (element_place % 10 == 0) sw.WriteLine();
                    }
                    if (orbit.cycles > 1)
                        sw.WriteLine($"Orbit Size: {orbit.cycles} cycles");
                    else
                        sw.WriteLine($"Orbit Size: {orbit.cycles} fixed point");

                    sw.WriteLine($"Whiskers: {orbit.whisker_count}\n");
                    sw.WriteLine("----------------------------------------");
                }
            }

            if (whiskers.Count > 0) Print_Whiskers();
        }

        public void Print_Inverses()
        {
            using (StreamWriter sw = File.AppendText(pathString))
            {
                sw.WriteLine("----------------------------------------\n");
                sw.WriteLine("Inverses:");
                for (int i = 1; i < series.Count; i++)
                {
                    for (int j = 0; j < series.Count; j++)
                    {
                        if ((series[i] * series[j]) % n == 1)
                        {
                            sw.WriteLine($"{series[i]} <-> {series[j]}");
                        }
                    }
                }
                sw.WriteLine("\n----------------------------------------");
            }
        }

        private void Print_Whiskers()
        {
            using (StreamWriter sw = File.AppendText(pathString))
            {
                sw.WriteLine($"Total Whiskers : {whiskers.Count}");
                whiskers.Sort();
                var whisker_change_indicator = -1;
                foreach (Whisker whisker in whiskers)
                {
                    if (whisker.ConnectedValue > whisker_change_indicator)
                    {
                        whisker_change_indicator = whisker.ConnectedValue;
                        sw.WriteLine("----------------------------------------");
                    }
                    sw.Write(whisker.ToString());
                    if (!whisker.connected_to_orbit) sw.WriteLine("*");
                    else sw.WriteLine();
                }
            }
        }
        
        private void Remove_From_Series(Orbit orbit)
        {
            foreach (Node element in orbit.Elements)
            {
                if (series.Exists(s => s.Equals(element.value))) series.Remove(element.value);
            }
        }

        public void Print_Analytics()
        {
            using (StreamWriter sw = File.AppendText(pathString))
            {
                sw.WriteLine("\n----------------------------------------");
                sw.WriteLine("Orbit Analytics");
                sw.WriteLine("----------------------------------------");

                int current_orbit_size = orbits[0].cycles;
                int count = 0;

                foreach (var orbit in orbits)
                {
                    if (orbit.cycles != current_orbit_size)
                    {
                        if (current_orbit_size == 1)
                            sw.WriteLine($"Fixed Points: {count}");
                        else
                            sw.WriteLine($"{current_orbit_size}-Cycle Orbits: {count}");
                        current_orbit_size = orbit.cycles;
                        count = 1;
                    }
                    else count++;
                }
                sw.WriteLine($"{current_orbit_size}-Cycle Orbits: {count}");
                sw.WriteLine("----------------------------------------\n");
            }
        }

        private void Close_Orbit()
        {
            current_orbit.Elements.Add(next_node);
            orbits.Add(current_orbit);
            Remove_From_Series(current_orbit);
            current_node.connected_node = next_node;
            if (series.Count > 0) Generate_Orbit();
        }

        private void Create_Whisker(bool orbit_connection)
        {
            if (series.Exists(s => s.Equals(current_node.value))) series.Remove(current_node.value);
            Whisker new_whisker = new Whisker
            {
                WhiskerValue = current_node.value,
                ConnectedValue = next_node.value,
                connected_to_orbit = orbit_connection
            };
            whiskers.Add(new_whisker);
            current_node.is_whisker = true;
            current_node.connected_node = next_node;
            if (series.Count > 0) Generate_Orbit();
        }
    }
}
