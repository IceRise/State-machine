using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_machine
{
    abstract class LegTypes
    {
        public double MaxSpeed { get; set; }
        public double CurrentSpeed { get; set; }
        public double EnergyRequirements { get; set; }
        
    }
}
