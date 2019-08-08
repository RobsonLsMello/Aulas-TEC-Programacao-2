using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01.BLL
{
    class Resistor
    {
        #region atributo
        public double resistencia { get; set; }
        #endregion
        public Resistor(double resistencia)
        {
            this.resistencia = resistencia;
        }
    }
}
