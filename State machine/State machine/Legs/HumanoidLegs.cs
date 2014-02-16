using State_machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    internal sealed class HumanoidLegs : LegTypes, IMove
    {
        public void SpeedPlus()
        {
            throw new NotImplementedException();
        }

        public void SpeedMinus()
        {
            
        }
    }
}
