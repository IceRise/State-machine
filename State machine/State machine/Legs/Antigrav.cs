using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    internal sealed class Antigrav : Legs
    {

        public override double Weight
        { get; protected set; }

        public override double MaxSpeed
        { get; protected set; }

        public override double EnergyRequirements
        { get; protected set; }
    }
}
