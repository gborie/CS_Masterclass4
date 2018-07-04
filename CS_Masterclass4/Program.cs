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

            int temperature;
            int output;

            if (int.TryParse(input, out output))
            {
                temperature = output;
            }
            else
            {
                temperature = 0;
                Console.WriteLine("Value entered not a number. 0 set as temperature");
            }


            if (temperature < 18)
            {
                Console.WriteLine("Take a coat");         
            }

            else if(temperature == 18)
            {
                Console.WriteLine("Trousers and hoodie!");
            }

            else if(temperature > 18 && temperature < 30)
            {
                Console.WriteLine("Shorts weather today!");
            }

            else 
            {
                Console.WriteLine("Naked day!");
            }



            Console.Read();
        }
    }
}
