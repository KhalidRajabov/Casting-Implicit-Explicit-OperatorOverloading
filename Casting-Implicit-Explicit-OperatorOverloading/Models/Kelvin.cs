using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Implicit_Explicit_OperatorOverloading.Models
{
    internal class Kelvin
    {
        public double Kelv { get; set; }
        public Kelvin(double ktemp)
        {
            Kelv = ktemp; 
        }
    }
    
}
