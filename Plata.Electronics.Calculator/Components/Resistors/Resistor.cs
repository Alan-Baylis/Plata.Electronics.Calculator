using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata.Electronics.Calculator.Components.Resistors
{
    public class Resistor
    {
        public List<IBand> Bands { get; set; }
        
        public float Value
        {
            get { return getResistorValue(); }

            set { }
        }

        public Resistor()
        {
            Bands = new List<IBand>();
        }

        public float getResistorValue()
        {
            if (Bands.Count == 4)
                return calculateFourBands();

            if (Bands.Count == 5)
                return calculateFiveBands();

            return 0;
        }

        private float calculateFourBands()
        {
            return ((10 * Bands[0].Value) + Bands[1].Value) * Bands[2].Value;
        }

        private int calculateFiveBands()
        {
            // TODO: Implement the equation for resistor with five band
            return 0;
        }
    }
}
