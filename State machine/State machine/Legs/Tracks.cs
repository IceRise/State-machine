using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State_machine.Interfaces;

namespace State_machine
{
    internal sealed class Tracks : LegTypes, IMove
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
