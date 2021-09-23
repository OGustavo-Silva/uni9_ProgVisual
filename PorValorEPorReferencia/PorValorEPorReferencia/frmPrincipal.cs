using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorValorEPorReferencia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPorValor_Click(object sender, EventArgs e)
        {
            double varA, varB;
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            /*Passagem por valor chama o procedimento passando os 
             parametros por VALOR, ou seja é passada uma cópia das variaveis*/
            porValor(varA, varB);

            /*Aqui espera-se que os valores estejam mantidos 
             pois as alteracoes foram apenas nas copias
            e nao nas variaveis originais*/
            txtVarA.Text = varA.ToString();
            txtVarB.Text = varB.ToString();
        }

        void porValor(double varA, double varB)
        {
            varA = varA * 3;
            varB = varB * 2;
        }

        /*A passagem por referencia faz a alteracao
         da variavel diretamente na memoria, pois obtem-se
        seu endereço quando acessada por referencia*/
        private void btnPorRef_Click(object sender, EventArgs e)
        {
            double varA, varB;
            varA = Convert.ToDouble(txtResA.Text);
            varB = Convert.ToDouble(txtResB.Text);

            porReferencia(ref varA, ref varB);
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        void porReferencia(ref double varA, ref double varB)
        {
            varA = varA * 3;
            varB = varB * 2;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVarA.Clear();
            txtVarB.Clear();
            txtResA.Clear();
            txtResB.Clear();
            txtVarA.Focus();
        }
    }
}
