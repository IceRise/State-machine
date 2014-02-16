using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    internal sealed class HumanoidLegs : Legs
    {
        public HumanoidLegs()
        {
            Weight = 100;
            MaxSpeed = 10;
            EnergyRequirements = 5;
        }

        public override double Weight
        { get; protected set; }

        public override double MaxSpeed
        { get; protected set; }

        public override double EnergyRequirements
        { get; protected set; }

        public override double CarryWeight
        { get; protected set; }
    }
}
