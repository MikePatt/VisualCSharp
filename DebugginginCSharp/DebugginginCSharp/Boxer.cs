using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugginginCSharp
{
    class Boxer
    {
        private int punchPower;

        public void SetPunchPower(int power)
        {
            this.punchPower = power;
        }

        public int GetPunchPower()
        {
            return this.punchPower;
        }
    }
}
