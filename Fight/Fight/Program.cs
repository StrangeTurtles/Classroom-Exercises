using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = "";
            string lCmd = "";
            Text text = new Text();
            int[] player = new int[5] { 100, 100, 100, 100, 100 };
            int count = 0;
            while (count < 5)
            {
                cmd = text.Ask("You have been incountered by a monster. Who gets hit (1-5)");
                lCmd = cmd.ToLower();
                //int[] player = new int[5] { 100, 100, 100, 100, 100 };
                if(lCmd == "1" || lCmd == "2" || lCmd == "3" || lCmd == "4" || lCmd == "5")
                {
                    int number = 0;
                    int.TryParse(lCmd, out number);
                    if(player[number] > 0)
                    {
                        player[number] -= 40;
                        Console.WriteLine($"Player {number} has taken 40 damage");
                        if(player[number] <= -1)
                        {
                            player[number] = 0;
                        }
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"Player {number} can't take any more damage");
                    }
                }
                Console.WriteLine($"Player 1 : {player[1]}");
                Console.WriteLine($"Player 2 : {player[2]}");
                Console.WriteLine($"Player 3 : {player[3]}");
                Console.WriteLine($"Player 4 : {player[4]}");
                Console.WriteLine($"Player 5 : {player[5]}");
            }
            Console.WriteLine("You Win!");
            Console.Read();
        }
    }
}
