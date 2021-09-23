
namespace Loops
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
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.lbMaximo = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(23, 29);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(120, 251);
            this.lstResultado.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(217, 167);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(120, 30);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "Laço For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(217, 207);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(120, 30);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "Laço While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(217, 246);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(120, 30);
            this.btnDoWhile.TabIndex = 3;
            this.btnDoWhile.Text = "Laço Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // lbMaximo
            // 
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Location = new System.Drawing.Point(230, 29);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(98, 13);
            this.lbMaximo.TabIndex = 4;
            this.lbMaximo.Text = "Maximo de valores:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(217, 59);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(120, 20);
            this.txtMaximo.TabIndex = 5;
            this.txtMaximo.Text = "10";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 338);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.lbMaximo);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lstResultado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Label lbMaximo;
        private System.Windows.Forms.TextBox txtMaximo;
    }
}

