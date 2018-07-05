using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass4
{
    class Program
    {

        // Global variables used in multiple methods
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        //Method to Register user with username and password
        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("--------------------------------------------");
        }

        //Method to login by checking if username and password are matching info registered
        public static void Login()
        {
            Console.WriteLine("LOGIN PAGE: Please enter your username");
            string user = Console.ReadLine();
            if(user == username)
            {
                Console.WriteLine("Please enter your password");
                string pass = Console.ReadLine();
                if(pass == password)
                {
                    Console.WriteLine("Congratulations, you are now logged in!");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart program");
            }
            
        }
    }
}
