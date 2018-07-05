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
            //condition ? first_expression : second_expression;
            //condition has to be either true or false
            //The conditional operator is right - associative
            //The expression a ? b : c ? d : e
            //is evaluated as a ? b : (c ? d : e),
            //not as is evaluated as (a ? b : c) ? d : e)
            //The conditional operator cannot be overloaded.

            //Long version 
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "Solid";
            else
                stateOfMatter = "Liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            //Short version
            temperature += 30;
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);


            //Challenge - add the gas state of matter to the options
            temperature += 85;
            stateOfMatter = temperature > 100  ?  "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            Console.ReadKey();
        }


    }
}
