using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata.Electronics.Calculator.Units
{
    public class Current : Unit
    {
        public static string Name
        {
            get { return "Ampere"; }
        }

        public static string Symbol
        {
            get { return "A"; }
        }

        public static Current make(float value)
        {
            Current current = new Current();
            current.Value = value;

            return current;
        }

        public override string ToString()
        {
            return Value + Symbol;
        }
    }
}
