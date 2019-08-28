using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP04.BLL;

namespace TP04
{
    public partial class frmPrincipal : Form
    {
        #region variáveis globais
        private int contadorGarrafa;
        private bool podeAnimarGarrafa;
        #endregion
        public frmPrincipal()
        {
            podeAnimarGarrafa = false;
            InitializeComponent();
        }
        #region Função para animar as fotos
        /*
         *  Função responsável por fazer a animação com base no tipo e nos sprites, e retornar o novo indíce
         */
        public int animarFoto(TipoAnimacao tipoAnimacao, int sprite, int numeroSpriteMax, string diretorio = "")
        {
            int indice = sprite % numeroSpriteMax + 1;
            if (tipoAnimacao == TipoAnimacao.garrafa)
            {
                switch (indice)
                {
                    case 1:
                        pbxPressao.Image = Properties.Resources.CH1;
                        break;
                    case 2:
                        pbxPressao.Image = Properties.Resources.CH2;
                        break;
                    case 3:
                        pbxPressao.Image = Properties.Resources.CH3;
                        break;
                    case 4:
                        pbxPressao.Image = Properties.Resources.CH4;
                        break;
                    case 5:
                        pbxPressao.Image = Properties.Resources.CH5;
                        break;
                    case 6:
                        pbxPressao.Image = Properties.Resources.CH6;
                        break;
                    case 7:
                        pbxPressao.Image = Properties.Resources.CH7;
                        break;
                    case 8:
                        pbxPressao.Image = Properties.Resources.CH8;
                        break;
                    case 9:
                        pbxPressao.Image = Properties.Resources.CH9;
                        break;
                }
            }
            
            return indice;
        }
        #endregion
        #region Calcular todos os 10 volumes
        /*
         * Função responsável por calcular todos os 10 volumes em um laço de repetição e devolver em forma de lista
         */
        public List<double> calcularVolumes(double pressao, double temperatura)
        {
            List<double> volumes = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                double volume = ((82 * Math.Pow(10, -3))/pressao)*((temperatura + i*2) + 273);
                volume = Math.Round(volume, 2);
                volumes.Add(volume);
            }
            podeAnimarGarrafa = true;
            return volumes;
        }
        #endregion
        #region botão calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var volumesCalculados = calcularVolumes(double.Parse(txtPressaoInicial.Text), double.Parse(txtTemperaturaInicial.Text));
                lbxResultados.DataSource = volumesCalculados;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite números", "Campo numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro desconhecido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Timer Update
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (podeAnimarGarrafa)
            {
                contadorGarrafa = animarFoto(TipoAnimacao.garrafa, contadorGarrafa, 9);
            }
        }
        #endregion
        #region Validar textBox para números reais
        /*
         * Função responsável por válidar conteudo das textoBox, bloqueando a digitação de qualquer coisa que não
         * represente um número real, podendo bloquear os números negativo
         */
        private void validarTextBoxParaNumerosReais(TextBox textBoxAlvo, KeyPressEventArgs e, bool podeNegativo = true)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = '.';
                //Verifica se já existe alguma vírgula na string
                if (textBoxAlvo.Text.Contains("."))
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
        #region Pressionar teclado no txtTemperaturaInicial
        private void txtTemperaturaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBoxParaNumerosReais(txtTemperaturaInicial, e);
        }
        #endregion
        #region Pressionar teclado no txtPressaoInicial
        private void txtPressaoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextBoxParaNumerosReais(txtPressaoInicial, e);
        }
        #endregion
    }
}
