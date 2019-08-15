using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP02.model;
using TP02.model.enums;

namespace TP02
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            lblTipoMovimento.Text = "";
            lblVelocidadeFinal.Text = "";
        }

        #region quando o usuário pressiona qualquer tecla
        private void txtVelocidadeInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBoxParaNumerosReais(txtVelocidadeInicial, e);
        }
        
        private void txtAceleracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBoxParaNumerosReais(txtAceleracao, e);
        }

        private void txtTempoDuracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBoxParaNumerosReais(txtTempoDuracao, e, false);
        }
        #endregion
        #region quando o texto muda
        private void txtVelocidadeInicial_TextChanged(object sender, EventArgs e)
        {
            calcular();
            validarTextBoxVisual(txtVelocidadeInicial, pnlVelocidadeInicial);
        }

        private void txtAceleracao_TextChanged(object sender, EventArgs e)
        {
            calcular();
            validarTextBoxVisual(txtAceleracao, pnlAceleracao);
        }

        private void txtTempoDuracao_TextChanged(object sender, EventArgs e)
        {
            calcular();
            validarTextBoxVisual(txtTempoDuracao, pnlTempoDuracao);
        }
        #endregion
        #region metodos
        private void calcular()
        {
            if (!txtAceleracao.Text.Equals("") && !txtTempoDuracao.Text.Equals("") && !txtVelocidadeInicial.Text.Equals(""))
            {
                Corpo corpo = new Corpo();
                try
                {
                    corpo.velocidadeInicial = double.Parse(txtVelocidadeInicial.Text);
                }
                catch (FormatException)
                {
                    return;
                }
                try
                {
                    corpo.aceleracao = double.Parse(txtAceleracao.Text);
                }
                catch (FormatException)
                {
                    return;
                }
                try
                {
                    lblVelocidadeFinal.Text = String.Format("{0:0000.00000}", corpo.velocidadeFinal(double.Parse(txtTempoDuracao.Text)));
                    switch (corpo.classificarTipoMovimento())
                    {
                        case TipoMovimento.movimentoAcelerado:
                            lblTipoMovimento.Text = "Movimento Acelerado";
                            break;
                        case TipoMovimento.movimentoRetardado:
                            lblTipoMovimento.Text = "Movimento Retardado";
                            break;
                        case TipoMovimento.movimentoUniforme:
                            lblTipoMovimento.Text = "Movimento Uniforme";
                            break;
                    }
                }
                catch (FormatException)
                {
                    return;
                }
            }
            else
            {

            }
        }
        private void validarTextBoxVisual(TextBox textBoxAlvo, Panel painelAlvo)
        {
            if (!textBoxAlvo.Text.IndexOf('-').Equals(0) && !textBoxAlvo.Text.IndexOf('-').Equals(-1))
            {
                painelAlvo.BackColor = Color.Red;
            }
            else
            {
                painelAlvo.BackColor = Color.LightGreen;
            }
            if (textBoxAlvo.Text.Equals("")) 
            {
                painelAlvo.BackColor = Color.Transparent;
            }
        }
        private void validarTextBoxParaNumerosReais(TextBox textBoxAlvo, KeyPressEventArgs e, bool podeNegativo = true)
        {

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (textBoxAlvo.Text.Contains(","))
                {
                    //bloqueia a digitação do próximo caracter inválido
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    if ((e.KeyChar == '-') && podeNegativo)
                    {
                        if (textBoxAlvo.Text.Length != 0)
                        {
                            //bloqueia a digitação do próximo caracter inválido
                            e.Handled = true;
                            if (textBoxAlvo.Text.ElementAt(0) != '-')
                            {
                                textBoxAlvo.Text = textBoxAlvo.Text.Replace("-", "");
                                textBoxAlvo.Text = "-" + textBoxAlvo.Text;
                            }
                                
                        }
                    }
                    else
                    {
                        //bloqueia a digitação do próximo caracter inválido
                        e.Handled = true;
                    }

                }

            }


        }
        #endregion
        #region botoes
        #region botaoSair
        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        #endregion

        private void pcbLimpar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente limpar as caixas de Texto?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == System.Windows.Forms.DialogResult.Yes)
            {
                pcbLimpar.Focus();
                pnlAceleracao.BackColor = Color.Transparent;
                pnlTempoDuracao.BackColor = Color.Transparent;
                pnlVelocidadeInicial.BackColor = Color.Transparent;
                txtAceleracao.Clear();
                txtTempoDuracao.Clear();
                txtVelocidadeInicial.Clear();
            }
        }

        #endregion
    }
}
