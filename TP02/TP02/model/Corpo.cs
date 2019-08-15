using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.model.enums;

namespace TP02.model
{
    class Corpo
    {
        #region atributos
        public double velocidadeInicial { get; set; }
        public double aceleracao { get; set; }

        #endregion
        #region métodos construtores
        public Corpo(double velocidadeInicial, double aceleracao)
        {
            this.velocidadeInicial = velocidadeInicial;
            this.aceleracao = aceleracao;
        }
        public Corpo()
        {
            this.velocidadeInicial = 0;
            this.aceleracao = 0;
        }
        #endregion
        #region metodos
        #region classificar o tipo de movimento
        public TipoMovimento classificarTipoMovimento()
        {
            if (this.aceleracao == 0)
            {
                return TipoMovimento.movimentoUniforme;
            }
            else if(this.aceleracao > 0)
            {
                return TipoMovimento.movimentoAcelerado;
            }
            else
            {
                return TipoMovimento.movimentoRetardado;
            }
        }
        #endregion
        #region calcular velocidade Final
        public double calcularVelocidadeFinal(double tempoDuracaoMovimento)
        {
            return this.velocidadeInicial + (this.aceleracao * tempoDuracaoMovimento);
        }
        #endregion
        #endregion
    }
}
