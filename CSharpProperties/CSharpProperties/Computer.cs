using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties
{
    class Computer
    {
        private string computerName;
        private int computerPower;

        public string ComputerName
        {
            get
            {
                return computerName;
            }
            set
            {
                computerName = value;
            }
        }

        public int ComputerPower
        {
            get
            {
                return computerPower;
            }
            set
            {
                computerPower = value;
            }
        }

       /* public void SetComputerName(string name)
        {
            this.computerName = name;
        }

        public string GetComputerName()
        {
            return this.computerName;
        }
        */
    }
}
