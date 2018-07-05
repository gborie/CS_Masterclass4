using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass4
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "GB";

        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(350, "Jeff");
            CheckHighScore(400, "GB");
            Console.Read();
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscorePlayer = playerName;
                highscore = score;
                Console.WriteLine("New Hiscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }


        }


    }
}
