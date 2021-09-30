
namespace ExercicioCaixaEletronico
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
            this.lblSaque = new System.Windows.Forms.Label();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnSaque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Location = new System.Drawing.Point(33, 60);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(81, 13);
            this.lblSaque.TabIndex = 0;
            this.lblSaque.Text = "Valor de saque:";
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(147, 60);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(100, 20);
            this.txtSaque.TabIndex = 1;
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(93, 173);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(120, 95);
            this.lstResultado.TabIndex = 2;
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(147, 123);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 3;
            this.btnSaque.Text = "SACAR";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 321);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.lblSaque);
            this.Name = "FrmPrincipal";
            this.Text = "Caixa Eletronico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnSaque;
    }
}

