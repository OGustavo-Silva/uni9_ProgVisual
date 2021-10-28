
namespace Projeto_com_Duas_Forms
{
    partial class FrmPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPessoas = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPessoas
            // 
            this.txtPessoas.Location = new System.Drawing.Point(6, 6);
            this.txtPessoas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPessoas.Multiline = true;
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(404, 314);
            this.txtPessoas.TabIndex = 0;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(6, 321);
            this.btFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(402, 36);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FrmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 389);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.txtPessoas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPessoas";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.FrmPessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPessoas;
        private System.Windows.Forms.Button btFechar;
    }
}