using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03
{
    public partial class FrmPrincipal : Form
    {
        private Panel[] panels;
        public FrmPrincipal()
        {
            panels = new Panel[5];
            panels[0] = pnlTetraedro;
            panels[1] = pnlCubo;
            panels[2] = pnlOctaedro;
            panels[3] = pnlDodecaedro;
            panels[4] = pnlIcosaedro;
            InitializeComponent();
            this.selecionarPcbAtual();
        }

        public void selecionarPcbAtual()
        {
            
            foreach (var panel in panels)
            {

                panel.BackgroundImage = Properties.Resources.arredondadopreenchido;
            }
        }
    }
}
