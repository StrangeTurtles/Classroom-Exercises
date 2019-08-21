using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playerAlive = true;
            int invulnerabilityTimer = 10;
            invulnerabilityTimer -= 3;
            if(playerAlive == true)
            {
                Console.WriteLine("You are alive");
            }
            else
            {
                Console.WriteLine("You're dead, dave");
            }
            if(invulnerabilityTimer >= 0)
            {
                Console.WriteLine("You are invulnerable");
                if(playerAlive == true)
                {
                    invulnerabilityTimer--;
                }
            }
            else if(invulnerabilityTimer == 0)
            {
                Console.WriteLine("You are now vulnerable");
            }
            else if(invulnerabilityTimer < 0)
            {
                invulnerabilityTimer = 0;
            }
            Console.Read();
        }
    }
}
