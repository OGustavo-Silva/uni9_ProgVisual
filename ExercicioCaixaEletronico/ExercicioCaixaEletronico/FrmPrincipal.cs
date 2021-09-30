using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Desenvolva uma aplicação WinForms com C# que seja capaz de simular o saque em um CAIXA ELETRÔNICO, com notas de 2, 5, 10, 20, 50 e 100. 

Vocês devem colar na caixa abaixo apenas o algoritmo utilizado. Não é preciso colar o programa inteiro.

Lembre-se que os únicos valores impossíveis de serem sacados é 1 e 3. 

Neste caixa não há moedas. É preciso exibir a quantidade de cada nota a ser entregue ao cliente.


Exemplos: 
Valor do saque: 70
Resultado:
 - Uma nota de 50
 - Uma nota de 20
---------------------------------
Valor do saque: 101
 - Uma nota de 50
 - Duas notas de 20
 - Uma nota de 5
 - Três notas de 2
 */

namespace ExercicioCaixaEletronico
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            int valorSaque = int.Parse(txtSaque.Text);
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            int contadorNota = 0;
            lstResultado.Items.Clear();

            if(valorSaque == 1 || valorSaque == 3)
            {
                lstResultado.Items.Add("Não pode sacar " + valorSaque);
            }

            else
            {

                foreach (int nota in notas)
                {
                    contadorNota = 0;
                    while (valorSaque >= nota &&
                            (valorSaque - nota != 1) && (valorSaque - nota != 3)
                          )
                    {
                        valorSaque -= nota;
                        contadorNota++;
                    }
                    if (contadorNota != 0) {
                        lstResultado.Items.Add("Notas de " + nota + ": " + contadorNota);
                    }

                }
                
            }

        }
    }
}
