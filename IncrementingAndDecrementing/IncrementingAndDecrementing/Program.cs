using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAndDecrementing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            do
            {
                number++;
            }
            while(number < 10);
            Console.Write($"{number}");
        }
    }
}
