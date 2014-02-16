using State_machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    internal sealed class Wheels : LegTypes, IMove
    {
        public void SpeedPlus()
        {
            throw new NotImplementedException();
        }

        public void SpeedMinus()
        {
            throw new NotImplementedException();
        }
    }
}
