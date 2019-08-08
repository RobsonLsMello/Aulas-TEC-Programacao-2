using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01.BLL;
using TP01.Enum;
using TP01.Exceções;

namespace TP01
{
    public partial class FrmPrincipal : Form
    {
        #region variaveis globais
        private string mensagem;
        private string cabecalho;
        private MessageBoxButtons botoes;
        private MessageBoxDefaultButton botaoPadrao;
        private MessageBoxIcon icone;
        #endregion
        public FrmPrincipal()
        {
            InitializeComponent();
            btnConverter.Enabled = false;
        }
        #region Eventos
        #region botão converter
        private void btnConverter_Click(object sender, EventArgs e)
        {
            Resistor[] resistores = new Resistor[3];
            string mensagem = "Os resistores convertidos são:\n";
            try
            {
                resistores[0] = new Resistor(double.Parse(txtR1.Text));
                resistores[1] = new Resistor(double.Parse(txtR2.Text));
                resistores[2] = new Resistor(double.Parse(txtR3.Text));
                var resultados = new ConverterCircuitoResistencia(resistores, TipoCircuitoResistor.triangulo).converter();
                for(int i = 0; i < 3; i++){
                    mensagem += string.Format("R{0} = {1:0.00} Ω \n", (i + 4), resultados[i].resistencia);
                }
                this.mensagem = mensagem;
                this.cabecalho = "Resultado";
                this.botoes = MessageBoxButtons.OK;
                this.icone = MessageBoxIcon.Information;
                this.botaoPadrao = MessageBoxDefaultButton.Button1;
                var resultadoDialog = MessageBox.Show(this.mensagem, this.cabecalho, this.botoes, this.icone, this.botaoPadrao);
            }
            catch (FormatException)
            {
                this.mensagem = "Por favor, digite apenas números";
                this.cabecalho = "Erro de Formato";
                this.botoes = MessageBoxButtons.OK;
                this.icone = MessageBoxIcon.Error;
                this.botaoPadrao = MessageBoxDefaultButton.Button1;
                var resultadoDialog = MessageBox.Show(this.mensagem, this.cabecalho, this.botoes, this.icone, this.botaoPadrao);
            }
            catch (NegativoException)
            {
                this.mensagem = "Número não pode ser zero ou negativo";
                this.cabecalho = "Erro de Formato";
                this.botoes = MessageBoxButtons.OK;
                this.icone = MessageBoxIcon.Error;
                this.botaoPadrao = MessageBoxDefaultButton.Button1;
                var resultadoDialog = MessageBox.Show(this.mensagem, this.cabecalho, this.botoes, this.icone, this.botaoPadrao);
            }
            catch (Exception f)
            {
                this.mensagem = "Algum erro aconteceu: \n" + f;
                this.cabecalho = "Erro não esperado";
                this.botoes = MessageBoxButtons.OK;
                this.icone = MessageBoxIcon.Error;
                this.botaoPadrao = MessageBoxDefaultButton.Button1;
                var resultadoDialog = MessageBox.Show(this.mensagem, this.cabecalho, this.botoes, this.icone, this.botaoPadrao);
            }
        }
        #endregion
        #region botão limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.mensagem = "Deseja limpar as caixas de texto?";
            this.cabecalho = "Limpar caixas de Texto";
            this.botoes = MessageBoxButtons.YesNo;
            this.icone = MessageBoxIcon.Warning;
            this.botaoPadrao = MessageBoxDefaultButton.Button1;
            var resultadoDialog = MessageBox.Show(this.mensagem, this.cabecalho, this.botoes, this.icone, this.botaoPadrao);
            if (resultadoDialog == DialogResult.Yes)
            {
                txtR1.Clear();
                txtR2.Clear();
                txtR3.Clear();
            }
            
        }
        #endregion
        #region botão fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.mensagem = "Deseja realmente sair?";
            this.cabecalho = "Sair do programa";
            this.botoes = MessageBoxButtons.YesNo;
            this.icone = MessageBoxIcon.Hand;
            this.botaoPadrao = MessageBoxDefaultButton.Button2;
            var resultadoDialog = MessageBox.Show(this.mensagem, this.cabecalho, this.botoes, this.icone, this.botaoPadrao);
            if(resultadoDialog == DialogResult.Yes)
                this.Dispose();
        }
        #endregion
        #region timer update
        /*
         * Verifica se os campos estão preenchidos para deixar o botão converter disponível
         */
        private void TmrUpdate_Tick(object sender, EventArgs e)
        {
            if (txtR1.Text != "" && txtR2.Text != "" && txtR3.Text != "")
            {
                btnConverter.Enabled = true;
            }
            else
            {
                btnConverter.Enabled = false;
            }
        }
        #endregion
        #endregion
    }
}
