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
            int temperature = 25;

            if(temperature < 10)
            {
                Console.WriteLine("Take a coat");         
            }

            if(temperature == 10)
            {
                Console.WriteLine("It's 10 degrees!");
            }

            if(temperature > 10)
            {
                Console.WriteLine("Cozy warm!");
            }

            Console.Read();
        }
    }
}
