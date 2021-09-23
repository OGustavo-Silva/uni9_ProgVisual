using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, n, res;

            a = int.Parse(txtInicio.Text);
            n = int.Parse(txtNumeros.Text);
            res = 0;

            for (int i =0; i<n; i++)
            {
                res += a++;
            }
            lblResultado.Text = res.ToString();
        }
    }
}
