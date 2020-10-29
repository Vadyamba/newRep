using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp_Abstraction_Hive
{
    class Bee
    {
        public const double honeyUnitsPerMg = 0.25;

        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * honeyUnitsPerMg;
        }
    }
}
