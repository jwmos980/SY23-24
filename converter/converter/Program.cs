using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num * 2);
            Console.ReadLine();

            /*
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
            }
            Console.ReadKey();
            */
        }
    }
}
