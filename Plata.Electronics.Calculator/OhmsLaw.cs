using Plata.Electronics.Calculator.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata.Electronics.Calculator
{
    public class OhmsLaw
    {
        public static Voltage calculate(Current current, Resistance resistance)
        {
            return Voltage.make(current.Value * resistance.Value);
        }

        public static Current calculate(Voltage voltage, Resistance resistance)
        {
            return Current.make(voltage.Value / resistance.Value);
        }

        public static Resistance calculate(Voltage voltage, Current current)
        {
            return Resistance.make(voltage.Value / current.Value);
        }
    }
}
