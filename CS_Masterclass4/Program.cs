using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature: ");
            string input = Console.ReadLine();
            int temperature = int.Parse(input);

            if(temperature < 18)
            {
                Console.WriteLine("Take a coat");         
            }

            if(temperature == 18)
            {
                Console.WriteLine("Trousers and hoodie!");
            }

            if(temperature > 18)
            {
                Console.WriteLine("Shorts weather today!");
            }

            Console.Read();
        }
    }
}
