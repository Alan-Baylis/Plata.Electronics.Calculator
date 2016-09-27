using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata.Electronics.Calculator.Units
{
    public class Voltage : Unit
    {
        public static string Name
        {
            get { return "Voltage"; }
        }

        public static string Symbol
        {
            get { return "v"; }
        }
        
        public static Voltage make(float value)
        {
            Voltage voltage = new Voltage();
            voltage.Value = value;

            return voltage;
        }

        public override string ToString()
        {
            return Value + Symbol;
        }
    }
}
