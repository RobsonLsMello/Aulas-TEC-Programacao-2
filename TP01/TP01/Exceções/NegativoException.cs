using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01.Exceções
{
    class NegativoException:Exception
    {
        public NegativoException()
        {
            
        }
        string toString()
        {
            return "Número negativo não permitido";
        }
    }
}
