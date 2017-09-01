using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugginginCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Boxer Ali = new Boxer();
            Console.WriteLine(Ali.GetPunchPower());

            Console.WriteLine("Enter a number for Punch Power: ");
            int punch = int.Parse(Console.ReadLine());

            Ali.SetPunchPower(punch);
            Console.WriteLine(Ali.GetPunchPower());
        }
    }
}
