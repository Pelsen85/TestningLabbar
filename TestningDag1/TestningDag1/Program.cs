using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestningDag1
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            double x = 1;

            Console.WriteLine("Enter a number: ");
            line = Console.ReadLine();

        
            try
            {
                x = Convert.ToDouble(line);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

            System.Console.WriteLine(" 1 / x = {0}" , x);
            Console.ReadKey(true);

        }
    }
}
