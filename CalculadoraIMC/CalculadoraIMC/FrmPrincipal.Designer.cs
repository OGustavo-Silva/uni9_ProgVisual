
namespace CalculadoraIMC
{
    partial class FrmPrincipal
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
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lbResultadoIMC = new System.Windows.Forms.Label();
            this.lbClassificacaoIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(30, 47);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(35, 13);
            this.lbPeso.TabIndex = 0;
            this.lbPeso.Text = "label1";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(30, 79);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(35, 13);
            this.lbAltura.TabIndex = 1;
            this.lbAltura.Text = "label2";
            this.lbAltura.Click += new System.EventHandler(this.label2_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCalcular.Location = new System.Drawing.Point(48, 126);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(72, 44);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(72, 79);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // lbResultadoIMC
            // 
            this.lbResultadoIMC.AutoSize = true;
            this.lbResultadoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoIMC.Location = new System.Drawing.Point(273, 50);
            this.lbResultadoIMC.Name = "lbResultadoIMC";
            this.lbResultadoIMC.Size = new System.Drawing.Size(41, 13);
            this.lbResultadoIMC.TabIndex = 5;
            this.lbResultadoIMC.Text = "label3";
            this.lbResultadoIMC.Visible = false;
            // 
            // lbClassificacaoIMC
            // 
            this.lbClassificacaoIMC.AutoSize = true;
            this.lbClassificacaoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacaoIMC.Location = new System.Drawing.Point(273, 79);
            this.lbClassificacaoIMC.Name = "lbClassificacaoIMC";
            this.lbClassificacaoIMC.Size = new System.Drawing.Size(41, 13);
            this.lbClassificacaoIMC.TabIndex = 6;
            this.lbClassificacaoIMC.Text = "label4";
            this.lbClassificacaoIMC.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 161);
            this.Controls.Add(this.lbClassificacaoIMC);
            this.Controls.Add(this.lbResultadoIMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora IMC";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lbResultadoIMC;
        private System.Windows.Forms.Label lbClassificacaoIMC;
    }
}

