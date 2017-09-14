using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orbits_generator
{
    class Program
    {
        enum Series_Choices {All_Real = 1, Odd = 2, Even = 3};

        static void Main(string[] args)
        {
            int a, b, c, n, k;
            bool all_real, odd, even;

            all_real = odd = even = false;

            Console.WriteLine("For the equation: [ Ax^2 + Bx + C ] mod N^K");
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter K: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            bool valid_choice;
            string choice_string;
            int choice_int;

            do
            {
                valid_choice = true;

                Console.WriteLine("Please Choose Number Series for X:");
                Console.WriteLine("1 - All Real Numbers up to N^K");
                Console.WriteLine("2 - All Odd Numbers up to N^K");
                Console.WriteLine("3 - All Even Numbers up to N^K");
                Console.WriteLine();

                Console.Write("Your choice: ");
                choice_string = Console.ReadLine();
                choice_int = Int32.Parse(choice_string);

                if (choice_int < 1 || choice_int > 3)
                {
                    valid_choice = false;
                    Console.WriteLine("ERROR: Please choose a valid menu option (1 - 3).\n");
                }
            } while (!valid_choice);

            Series_Choices series_choice = (Series_Choices)choice_int;

            switch (series_choice)
            {
                case Series_Choices.All_Real:
                    Console.WriteLine("The series will use all real numbers.");
                    all_real = true;
                    break;
                case Series_Choices.Odd:
                    Console.WriteLine("The series will use all odd numbers.");
                    odd = true;
                    break;
                case Series_Choices.Even:
                    Console.WriteLine("The series will use all even numbers.");
                    even = true;
                    break;
            }

            Console.WriteLine();
            Orbit_Generator test = new Orbit_Generator(a, b, c, n, k, all_real, even, odd);
            test.Print_Inverses();
            test.Generate_Orbit();
            test.Print_Orbits();
            test.Print_Whiskers();
            Console.Write("Press any key to exit...");
            Console.Read();
        }
    }
}
