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

        private void btSoma_Click(object sender, EventArgs e)
        {
            String va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;

            try
            {
                vaD = Double.Parse(va);
                vbD = Double.Parse(vb);
                lbResultado.Text = (vaD + vbD).ToString();

            } catch (Exception ex)
            {
                lbResultado.Text = "Erro";
            }
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            String va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;

            try
            {
                vaD = Double.Parse(va);
                vbD = Double.Parse(vb);
                lbResultado.Text = (vaD - vbD).ToString();

            }
            catch (Exception ex)
            {
                lbResultado.Text = "Erro";
            }
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            String va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;

            try
            {
                vaD = Double.Parse(va);
                vbD = Double.Parse(vb);
                lbResultado.Text = (vaD * vbD).ToString();

            }
            catch (Exception ex)
            {
                lbResultado.Text = "Erro";
            }
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            String va, vb;
            double vaD, vbD;
            va = txtValorA.Text;
            vb = txtValorB.Text;

            try
            {
                vaD = Double.Parse(va);
                vbD = Double.Parse(vb);
                if(vbD == 0)
                {
                    lbResultado.Text = "Não existe";
                } else
                {
                    lbResultado.Text = (vaD / vbD).ToString();
                }

            }
            catch (Exception ex)
            {
                lbResultado.Text = "Erro";
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
