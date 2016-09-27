using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata.Electronics.Calculator.Components.Resistors
{
    public class Band : IBand
    {
        public ResistorColor Color { get; set; }

        public float Value
        {
            get { return (int)Color; }
        }
    }
}
