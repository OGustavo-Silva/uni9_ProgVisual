﻿
namespace Calculadora_Simples
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lbValorA = new System.Windows.Forms.Label();
            this.lbValorB = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btSomar = new System.Windows.Forms.Button();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbValorA
            // 
            this.lbValorA.AutoSize = true;
            this.lbValorA.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbValorA.Location = new System.Drawing.Point(10, 29);
            this.lbValorA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorA.Name = "lbValorA";
            this.lbValorA.Size = new System.Drawing.Size(44, 13);
            this.lbValorA.TabIndex = 0;
            this.lbValorA.Text = "Valor A:";
            // 
            // lbValorB
            // 
            this.lbValorB.AutoSize = true;
            this.lbValorB.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbValorB.Location = new System.Drawing.Point(10, 53);
            this.lbValorB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorB.Name = "lbValorB";
            this.lbValorB.Size = new System.Drawing.Size(44, 13);
            this.lbValorB.TabIndex = 1;
            this.lbValorB.Text = "Valor B:";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(58, 27);
            this.txtValorA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(91, 20);
            this.txtValorA.TabIndex = 2;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(58, 50);
            this.txtValorB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(91, 20);
            this.txtValorB.TabIndex = 3;
            // 
            // btSomar
            // 
            this.btSomar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomar.Location = new System.Drawing.Point(19, 84);
            this.btSomar.Margin = new System.Windows.Forms.Padding(0);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(32, 31);
            this.btSomar.TabIndex = 4;
            this.btSomar.Text = "+";
            this.btSomar.UseVisualStyleBackColor = false;
            this.btSomar.Click += new System.EventHandler(this.trataOperacao_Click);
            // 
            // btSubtracao
            // 
            this.btSubtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtracao.Location = new System.Drawing.Point(56, 84);
            this.btSubtracao.Margin = new System.Windows.Forms.Padding(0);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(32, 31);
            this.btSubtracao.TabIndex = 5;
            this.btSubtracao.Text = "-";
            this.btSubtracao.UseVisualStyleBackColor = false;
            this.btSubtracao.Click += new System.EventHandler(this.trataOperacao_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicacao.Location = new System.Drawing.Point(20, 120);
            this.btMultiplicacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(31, 29);
            this.btMultiplicacao.TabIndex = 6;
            this.btMultiplicacao.Text = "x";
            this.btMultiplicacao.UseVisualStyleBackColor = false;
            this.btMultiplicacao.Click += new System.EventHandler(this.trataOperacao_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivisao.Location = new System.Drawing.Point(56, 120);
            this.btDivisao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(32, 29);
            this.btDivisao.TabIndex = 7;
            this.btDivisao.Text = "÷";
            this.btDivisao.UseVisualStyleBackColor = false;
            this.btDivisao.Click += new System.EventHandler(this.trataOperacao_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(8, 165);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(167, 39);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "--";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btLimpar.Location = new System.Drawing.Point(92, 84);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(56, 65);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 219);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.btSubtracao);
            this.Controls.Add(this.btSomar);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lbValorB);
            this.Controls.Add(this.lbValorA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "Calculadora Simples";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValorA;
        private System.Windows.Forms.Label lbValorB;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btLimpar;
    }
}

