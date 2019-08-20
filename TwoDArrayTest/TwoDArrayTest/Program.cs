using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoD = new int[3,3];
            int count = 1;
            for(int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    twoD[row, col] = count;
                    Console.Write($"{ twoD[row, col]} ");
                    count++;
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
