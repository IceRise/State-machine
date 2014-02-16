using State_machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    internal sealed class Antigrav : LegTypes, IMove
    {
        public void SpeedPlus(double value)
        {
            CurrentSpeed += value;
        }

        public void SpeedMinus(double value)
        {
            if (CurrentSpeed > value)
                CurrentSpeed -= value;
            else
                CurrentSpeed = 0;
        }
    }
}
