using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Enum;

namespace TP01.BLL
{
    class ConverterCircuitoResistencia
    {
        #region atributos
        private Resistor[] resistores;
        private TipoCircuitoResistor tipoAssociacao;
        #endregion
        public ConverterCircuitoResistencia(Resistor[] resistores, TipoCircuitoResistor tipoCircuito)
        {
            this.resistores = resistores;
            this.tipoAssociacao = tipoCircuito;
        }
        #region metodo        
        public Resistor[] converter()
        {
            double somaProdutosResistencias, somaResistencias;
            Resistor[] resistoresConvertidos = new Resistor[3];
            if (this.tipoAssociacao == TipoCircuitoResistor.estrela)
            {
                somaProdutosResistencias = resistores[0].resistencia * resistores[1].resistencia + resistores[1].resistencia * resistores[2].resistencia + resistores[2].resistencia * resistores[0].resistencia;
                for (int i = 0; i < 3; i++)
                    resistoresConvertidos[i] = new Resistor(somaProdutosResistencias / resistores[i].resistencia);
            }
            else if (this.tipoAssociacao == TipoCircuitoResistor.triangulo)
            {
                somaResistencias = resistores[0].resistencia +  resistores[1].resistencia +  +  resistores[2].resistencia;
                resistoresConvertidos[0] = new Resistor((resistores[0].resistencia + resistores[1].resistencia) / (somaResistencias));
                resistoresConvertidos[1] = new Resistor((resistores[1].resistencia + resistores[2].resistencia) / (somaResistencias));
                resistoresConvertidos[2] = new Resistor((resistores[0].resistencia + resistores[2].resistencia) / (somaResistencias));
            }
            return resistoresConvertidos;
        }
        #endregion
    }
}
