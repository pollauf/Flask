using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flask
{
    public class Potenciometrica
    {
        public double Volume { get; set; }
        public double pH { get; set; }
        public Potenciometrica(double volume, double pH)
        {
            Volume = volume;
            this.pH = pH;
        }
    }
}
