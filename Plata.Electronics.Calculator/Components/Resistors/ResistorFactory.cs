using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plata.Electronics.Calculator.Components.Resistors
{
    public class ResistorFactory
    {
        public static Resistor fourBands()
        {
            Band firstBand = new Band();
            Band secondBand = new Band();
            MultiplierBand thirdBand = new MultiplierBand();
            ToleranceBand fourthBand = new ToleranceBand();

            return fourBands(firstBand, secondBand, thirdBand, fourthBand);
        }

        public static Resistor fourBands(Band firstBand, Band secondBand, MultiplierBand thirdBand, ToleranceBand fourthBand)
        {
            Resistor resistor = new Resistor();
            resistor.Bands.Add(firstBand);
            resistor.Bands.Add(secondBand);
            resistor.Bands.Add(thirdBand);
            resistor.Bands.Add(fourthBand);

            return resistor;
        }
    }
}
