using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCsharp2
{
    class Animal
    {

        public string Name { get; set;}

        private int age; 

        private decimal power;
        private decimal speed;
        //
        //Constructors
        //
        public Animal() { }    
        public Animal(string nameVal, int ageVal, decimal powVal, decimal spdVal)
        {
            this.Name = nameVal;
            this.Age = ageVal;
            this.Power = powVal;
            this.Speed = spdVal;
        }
        //
        //Properties
        //
        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                    return;
            }
        }

        public decimal Power
        {
            get
            {
                return power;
            }
            private set
            {
                if (value > 0)
                {
                    this.power = value;
                    return;
                }
                else
                    return;
            }
        }

        public decimal Speed
        {
            get
            {
                return speed;
            }

            private set
            {
                if (value > 0)
                {
                    speed = value;
                    return;
                }
                else
                    return;
            }
        }

        //
        //Instance Methods
        //
        public void IncreaseAge(int ageVal)
        {
            if (ageVal > 0)
            {
                Age = Age + ageVal;
            }
            else
                return;
        }
        public void IncreasePower(decimal powVal)
        {
            if (powVal > 0)
            {
                Power = Power + powVal;
                return;
            }
            else
                return;
        }
        public void IncreaseSpeed(decimal spdVal)
        {
            if (spdVal > 0)
            {
                Speed = Speed + spdVal;
                return;
            }
            else
                return;
        }

    }
}
