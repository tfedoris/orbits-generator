using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orbits_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int a, b, c, n, k;
            bool all_real, odd, even, print_inverse;

            a = int.Parse(textBoxA.Text);
            b = int.Parse(textBoxB.Text);
            c = int.Parse(textBoxC.Text);
            n = int.Parse(textBoxN.Text);
            k = int.Parse(textBoxK.Text);

            all_real = radioAll.Checked;
            odd = radioOdd.Checked;
            even = radioEven.Checked;
            print_inverse = checkBoxInverses.Checked;

            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string pathString = System.IO.Path.Combine(currentDir, "Orbits");
            System.IO.Directory.CreateDirectory(pathString);
            string fileName = a + "x^2+" + b + "x+" + c + "(mod" + n + "^" + k + ").txt";
            pathString = System.IO.Path.Combine(pathString, fileName);

            Orbit_Generator gen = new Orbit_Generator(a, b, c, n, k, all_real, even, odd, pathString);
            if (print_inverse) gen.Print_Inverses();
            gen.Generate_Orbit();
            gen.Print_Orbits();
            gen.Print_Analytics();
            MessageBox.Show($"Results printed to:\n \"{pathString}\"");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
