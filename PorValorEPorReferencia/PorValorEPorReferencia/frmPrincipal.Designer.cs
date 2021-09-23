
namespace PorValorEPorReferencia
{
    partial class frmPrincipal
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
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.lblValorA2 = new System.Windows.Forms.Label();
            this.lblValorB2 = new System.Windows.Forms.Label();
            this.txtVarA = new System.Windows.Forms.TextBox();
            this.txtVarB = new System.Windows.Forms.TextBox();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.btnPorValor = new System.Windows.Forms.Button();
            this.btnPorRef = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(40, 42);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(44, 13);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A:";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(40, 78);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(44, 13);
            this.lblValorB.TabIndex = 1;
            this.lblValorB.Text = "Valor B:";
            // 
            // lblValorA2
            // 
            this.lblValorA2.AutoSize = true;
            this.lblValorA2.Location = new System.Drawing.Point(40, 131);
            this.lblValorA2.Name = "lblValorA2";
            this.lblValorA2.Size = new System.Drawing.Size(44, 13);
            this.lblValorA2.TabIndex = 2;
            this.lblValorA2.Text = "Valor A:";
            // 
            // lblValorB2
            // 
            this.lblValorB2.AutoSize = true;
            this.lblValorB2.Location = new System.Drawing.Point(40, 170);
            this.lblValorB2.Name = "lblValorB2";
            this.lblValorB2.Size = new System.Drawing.Size(44, 13);
            this.lblValorB2.TabIndex = 3;
            this.lblValorB2.Text = "Valor B:";
            // 
            // txtVarA
            // 
            this.txtVarA.Location = new System.Drawing.Point(97, 39);
            this.txtVarA.Name = "txtVarA";
            this.txtVarA.Size = new System.Drawing.Size(100, 20);
            this.txtVarA.TabIndex = 4;
            // 
            // txtVarB
            // 
            this.txtVarB.Location = new System.Drawing.Point(97, 75);
            this.txtVarB.Name = "txtVarB";
            this.txtVarB.Size = new System.Drawing.Size(100, 20);
            this.txtVarB.TabIndex = 5;
            // 
            // txtResA
            // 
            this.txtResA.Location = new System.Drawing.Point(97, 128);
            this.txtResA.Name = "txtResA";
            this.txtResA.Size = new System.Drawing.Size(100, 20);
            this.txtResA.TabIndex = 6;
            // 
            // txtResB
            // 
            this.txtResB.Location = new System.Drawing.Point(97, 170);
            this.txtResB.Name = "txtResB";
            this.txtResB.Size = new System.Drawing.Size(100, 20);
            this.txtResB.TabIndex = 7;
            // 
            // btnPorValor
            // 
            this.btnPorValor.Location = new System.Drawing.Point(277, 42);
            this.btnPorValor.Name = "btnPorValor";
            this.btnPorValor.Size = new System.Drawing.Size(141, 38);
            this.btnPorValor.TabIndex = 8;
            this.btnPorValor.Text = "Passagem por Valor";
            this.btnPorValor.UseVisualStyleBackColor = true;
            this.btnPorValor.Click += new System.EventHandler(this.btnPorValor_Click);
            // 
            // btnPorRef
            // 
            this.btnPorRef.Location = new System.Drawing.Point(277, 131);
            this.btnPorRef.Name = "btnPorRef";
            this.btnPorRef.Size = new System.Drawing.Size(141, 38);
            this.btnPorRef.TabIndex = 9;
            this.btnPorRef.Text = "Passagem por Referencia";
            this.btnPorRef.UseVisualStyleBackColor = true;
            this.btnPorRef.Click += new System.EventHandler(this.btnPorRef_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(85, 213);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(392, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 248);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPorRef);
            this.Controls.Add(this.btnPorValor);
            this.Controls.Add(this.txtResB);
            this.Controls.Add(this.txtResA);
            this.Controls.Add(this.txtVarB);
            this.Controls.Add(this.txtVarA);
            this.Controls.Add(this.lblValorB2);
            this.Controls.Add(this.lblValorA2);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Name = "frmPrincipal";
            this.Text = "Por Valor e Por Referencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label lblValorA2;
        private System.Windows.Forms.Label lblValorB2;
        private System.Windows.Forms.TextBox txtVarA;
        private System.Windows.Forms.TextBox txtVarB;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.Button btnPorValor;
        private System.Windows.Forms.Button btnPorRef;
        private System.Windows.Forms.Button btnLimpar;
    }
}

