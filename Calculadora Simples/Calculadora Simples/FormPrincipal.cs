using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void trataOperacao_Click(object sender, EventArgs e)
        {
            try
            {
                String vA, vB;

                vA = txtValorA.Text;
                vB = txtValorB.Text;

                Matematica mat = new Matematica(vA, vB);
                switch (((Button)sender).Name)
                {
                    case "btSomar":
                        lbResultado.Text = mat.soma().ToString();
                        break;
                    case "btSubtracao":
                        lbResultado.Text = mat.subtracao().ToString();
                        break;
                    case "btMultiplicacao":
                        lbResultado.Text = mat.multiplicacao().ToString();
                        break;
                    case "btDivisao":
                        lbResultado.Text = mat.divisao().ToString();
                        break;
                }
            }
            catch(Exception ex)
            {
                lbResultado.Text = ex.Message;
            }
        }


        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtValorA.Clear();
            txtValorB.Clear();
            lbResultado.Text = "---";
        }

    }
}
