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
            int age = 19;

            if(age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if(age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you?");
            }

            Console.Read();
        }

    }
}
