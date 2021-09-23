using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class FrmPrincipal : Form
    {
        private Imc imc;
        public FrmPrincipal()
        {
            InitializeComponent();
            imc = new Imc();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            float peso, altura;
            float.TryParse(txtPeso.Text, out peso);
            float.TryParse(txtAltura.Text, out altura);

            imc.altura = altura;
            imc.peso = peso;    

            lbResultadoIMC.Text = "IMC:" + imc.calculaIMC().ToString();
            lbClassificacaoIMC.Text = "Classificação: " + imc.classificacao;
          

            lbResultadoIMC.Visible = true;
            lbClassificacaoIMC.Visible = true;
            lbClassificacaoIMC.ForeColor = imc.corClassificacao;
        }
    }
}
