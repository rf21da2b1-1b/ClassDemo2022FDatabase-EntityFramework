using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLibEF.model
{
    public partial class Car
    {
        public Car(string regNr, string colour, bool el, string ejer)
        {
            RegNr = regNr;
            Colour = colour;
            El = el;
            Ejer = ejer;
        }

        public override string ToString()
        {
            return $"{nameof(RegNr)}: {RegNr}, {nameof(Colour)}: {Colour}, {nameof(El)}: {El}, {nameof(Ejer)}: {Ejer}";
        }
    }
}
