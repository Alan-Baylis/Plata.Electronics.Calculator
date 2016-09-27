using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata.Electronics.Calculator.Units
{
    public class Resistance : Unit
    {
        public static string Name
        {
            get { return "Ohm"; }
        }

        public static string Symbol
        {
            get { return "Ω"; }
        }

        public static Resistance make(float value)
        {
            Resistance resistance = new Resistance();
            resistance.Value = value;

            return resistance;
        }

        public override string ToString()
        {
            return Value + Symbol;
        }
    }
}
