using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    internal sealed class Tracks : Legs
    {
        public Tracks()
        {
            Weight = 500;
            MaxSpeed = 70;
            EnergyRequirements = 8;
        }
        public override double Weight
        { get; protected set; }

        public override double MaxSpeed
        { get; protected set; }

        public override double EnergyRequirements
        { get; protected set; }
    }
}
