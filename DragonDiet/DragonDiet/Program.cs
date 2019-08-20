using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] diet = new int[3, 7]
            { {9,8,4,3,9,1,3},
            { 5,8,3,3,6,1,2},
            { 5,5,5,3,6,1,1} };
            Text text = new Text();
            string cmd = "";
            string name1 = "";
            string name2 = "";
            string name3 = "";
            //string lCmd = "";
            name1 = text.Ask("What is the name of the first dragon");
            name2 = text.Ask("What is the name of the Second dragon");
            name3 = text.Ask("What is the name of the third dragon");
            Console.Write(name1 + "");
            Console.Write(name2 + "");
            Console.Write(name3 + "");
            Console.WriteLine("");
            int averageTotal = 0;
            for (int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 7; col++)
                {
                    averageTotal += diet[row, col];
                }
            }

            int dragon1 = 0;
            for (int col = 0; col < 7; col++)
            {
                dragon1 += diet[0, col];
            }
            dragon1 = dragon1 / 7;
            Console.WriteLine($"{name1} average is {dragon1}");

            int dragon2 = 0;
            for (int col = 0; col < 7; col++)
            {
                dragon2 += diet[1, col];
            }
            dragon2 = dragon2 / 7;
            Console.WriteLine($"{name2} average is {dragon2}");

            int dragon3 = 0;
            for (int col = 0; col < 7; col++)
            {
                dragon3 += diet[2, col];
            }
            dragon3 = dragon3 / 7;
            Console.WriteLine($"{name3} average is {dragon3}");
            int least = int.MaxValue;
            int leastIs = 6;
            for(int x = 0; x < 3; x++ )
            {
                for (int y = 0; y < 7; y++)
                {
                    if(least > diet[x,y])
                    {
                        least = diet[x, y];
                        leastIs = x;
                    }
                }
            }
            int most = int.MinValue;
            int mostIs = 6;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (most < diet[x, y])
                    {
                        most = diet[x, y];
                        mostIs = x;
                    }
                }
            }
            if(leastIs == 0)
            {
                Console.WriteLine($"{name1} has the least with {least}");
            }
            if (leastIs == 1)
            {
                Console.WriteLine($"{name2} has the least with {least}");
            }
            if (leastIs == 2)
            {
                Console.WriteLine($"{name3} has the least with {least}");
            }

            if (mostIs == 0)
            {
                Console.WriteLine($"{name1} has the most with {most}");
            }
            if (mostIs == 1)
            {
                Console.WriteLine($"{name2} has the most with {most}");
            }
            if (mostIs == 2)
            {
                Console.WriteLine($"{name3} has the most with {most}");
            }

            averageTotal = averageTotal / 21;
            Console.WriteLine($"The total average is {averageTotal}");
            Console.Read();
        }
    }
}
