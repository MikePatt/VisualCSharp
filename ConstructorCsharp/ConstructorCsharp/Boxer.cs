using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCsharp
{
    class Boxer
    {
        public string FirstName { get; set; }

        public Boxer()
        {

        }

        public Boxer(string name)
        {
            this.FirstName = name;
        }
    }
}
