using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 30;
            int num2 = 20;
            /*
            if (num1 > num2)
            {
                Console.WriteLine("Number 1 is Greater than Number 2");
            }
            else
            {
                Console.WriteLine("Number 1 is Equal to or Less Than Number 2");
            }
            */
            Console.WriteLine(num1 > num2 ? "Number 1 is Greater than Number 2" : "Number 1 is Equal to or Less Than Number 2");
        }
    }
}
