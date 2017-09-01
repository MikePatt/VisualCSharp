using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Computer().GetCompName());

            Computer myComp = new Computer();
            myComp.ComputerName = "Asus Transformer Flip";
            myComp.ComputerPower = 100;
            Console.WriteLine($"My computer is a {myComp.ComputerName} and has {myComp.ComputerPower} power");
        }
    }
}
