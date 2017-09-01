using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro2
{
    class Writer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("How are you today?");
            string Test = Console.ReadLine();
            Console.WriteLine($"{Test} as well!");

            Console.Write("Enter a Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter another Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            
        }
    }
}
