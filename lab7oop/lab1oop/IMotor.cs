using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1oop
{
    public interface IMotor
    {
        string Name { get; set; }
        string Type { get; set; }
        int Power { get; set; }
        int Phases { get; set; }
        double Mass { get; set; }
        int Voltage { get; set; }
        int Efficiency { get; set; }

        string GetMotorName();
        void IncMass(int increment);
        void ScaleEfficiency(ref int factor);
    }
}
