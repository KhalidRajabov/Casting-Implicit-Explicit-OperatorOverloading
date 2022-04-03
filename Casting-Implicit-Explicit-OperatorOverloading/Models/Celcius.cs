using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Implicit_Explicit_OperatorOverloading.Models
{
    internal class Celcius
    {
        public double Celci { get; set; }
        public Celcius(double ctemp)
        {
            Celci = ctemp;
        }
        public static implicit operator Kelvin(Celcius celci)
        {
            return new Kelvin(celci.Celci- 273.15);
        }
    }
}