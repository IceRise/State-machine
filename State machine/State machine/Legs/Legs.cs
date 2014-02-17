using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    abstract class Legs
    {
        protected double maxSpeed;
        protected double Weight;
        protected double CarryWeight;
        protected double EnergyRequirements;

        protected double currentSpeed;

        public void SpeedPlus(double value)
        {
            currentSpeed += value;
        }

        public void SpeedMinus(double value)
        {
            if (currentSpeed > value)
                currentSpeed -= value;
            else
                currentSpeed = 0;
        }
    }
}
