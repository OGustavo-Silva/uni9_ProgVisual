using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class FrmPrincipal : Form
    {
        private int maximo = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void preparaLoop()
        {

            lstResultado.Items.Clear();
            maximo = int.Parse(txtMaximo.Text);
            if (maximo > 1000)
            {
                throw new Exception("O valor máximo é 1000!");
            }
        }


        private void btnFor_Click(object sender, EventArgs e)
        {
            try
            {
                preparaLoop();
                for (int i = 1; i <= maximo; i++)
                {
                    lstResultado.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Você precisa digitar um número válido\nErro: " + ex.Message);
            }


        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            try
            {
                preparaLoop();
                int i = 1;
                while (i <= maximo)
                {
                    lstResultado.Items.Add(i++);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Você precisa digitar um número válido\nErro: " + ex.Message);
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            try
            {
                preparaLoop();
                int i = 1;
                do
                {
                    lstResultado.Items.Add(i++);
                } while (i <= maximo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Você precisa digitar um número válido\nErro: " + ex.Message);
            }
        }
    }
}
