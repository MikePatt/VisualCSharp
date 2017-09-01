using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Boxer
    {
        public string Name { get; set; }

        private int punchSpeed;

        public int PunchSpeed
        {
            get
            {
                return punchSpeed;
            }

            private set
            {
                if(value > 0 && value < 500)
                {
                    punchSpeed = value;
                }
            }
        }

        public string PunchSpeedEval
        {
            get
            {
                string eval = string.Empty;
                if(PunchSpeed >= 450)
                {
                    eval = "Great Speed!";
                }
                else if(PunchSpeed >= 400)
                {
                    eval = "Good Speed!";
                }
                else if(PunchSpeed >= 300)
                {
                    eval = "Not Bad!";
                }
                else
                {
                    eval = "Bad!";
                }
                return eval;
            }
        }

        public Boxer(string name, int punSpdVal)
        {
            this.Name = name;
            this.PunchSpeed = punSpdVal;
        }
    }
}
