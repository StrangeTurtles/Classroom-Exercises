using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = 0;
            string input;
            int output;
            input = Console.ReadLine();
            Int32.TryParse(input, out output);
            for(int count = output; count > 0; count--)
            {
                int[] data = new int[output];
                data[numberCount] = count;
                Console.WriteLine($"The data is {data[numberCount]}");
                numberCount++;
            }
            Console.Read();
        }
    }
}
