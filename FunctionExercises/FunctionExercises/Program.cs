using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Game TheGame = new Game();
            TheGame.score = 100;
            Console.WriteLine(TheGame.Start());
            Console.Read();
        }
    }
    class Game
    {
        public int score = 0;
        public int Start(int scoreGame = 0)
        {
            //scoreGame = score;
            Console.WriteLine($"Your Score Is : {score}");
            string input = Console.ReadLine();
            int number = 0;
            Int32.TryParse(input, out number);
            AddToScore(number);
            Console.WriteLine($"Your Score Is : {score}");
            scoreGame = score;
            return scoreGame;
        }
        public int AddToScore(int add)
        {
            score += add;
            return score;
        }
    }
}
