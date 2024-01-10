using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of liter");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);

            Console.WriteLine("press 1 for fluid ounces\npress 2 for gills\npress 3 for pints\npress 4 for quarts\npress 5 for gallons\npress 6 for tablespoon\npress 7 for teaspoon\npress 8 for cup");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);


            switch (num)
            {
                case 1:
                    Console.WriteLine(liters * 33.814 + " fl oz");
                    break;
                case 2:
                    Console.WriteLine(liters * 8.45351 + " gi");
                    break;
                case 3:
                    Console.WriteLine(liters * 2.11337 + " pt");
                    break;
                case 4:
                    Console.WriteLine(liters * 1.05668 + " qt");
                    break;
                case 5:
                    Console.WriteLine(liters * 0.26417 + " gal");
                    break;
                case 6:
                    Console.WriteLine(liters * 67.628 + " tbsp");
                    break;
                case 7:
                    Console.WriteLine(liters * 1202.884 + " tsp");
                    break;
                case 8:
                    Console.WriteLine(liters * 4.22675 + " cups");
                    break;
                default:
                    Console.WriteLine("invalid units");
                    break;
            }
            Console.ReadLine();




            /*
            Console.WriteLine("enter the number of meters");
            int meters = 0;
            int.TryParse(Console.ReadLine(), out meters);

            Console.WriteLine("press 1 for feet\npress 2 for yards");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);

            
            if (num == 1)
            {
                Console.WriteLine(meters * 3.28084 + " feet");
            }
            if (num == 2)
            {
                Console.WriteLine(meters * 1.09361 + " yards");
            }
            Console.ReadLine();
            

            switch (num)
            {
                case 1: 
                    Console.WriteLine(meters * 3.28084 + " feet"); 
                    break;
                case 2:
                    Console.WriteLine(meters * 1.09361 + " yards");
                    break;
                default:
                    Console.WriteLine("invalid units");
                    break;
            }
            Console.ReadLine();
            */
        }
    }
}
