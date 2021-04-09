namespace Atividade_Avaliativa_POO
{
    partial class Form1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblconta = new System.Windows.Forms.Label();
            this.lblpagamento = new System.Windows.Forms.Label();
            this.txtatraso = new System.Windows.Forms.TextBox();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(200, 223);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(89, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblconta
            // 
            this.lblconta.AutoSize = true;
            this.lblconta.Location = new System.Drawing.Point(186, 124);
            this.lblconta.Name = "lblconta";
            this.lblconta.Size = new System.Drawing.Size(115, 13);
            this.lblconta.TabIndex = 1;
            this.lblconta.Text = "Insira o valor da conta.";
            this.lblconta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpagamento
            // 
            this.lblpagamento.AutoSize = true;
            this.lblpagamento.Location = new System.Drawing.Point(146, 169);
            this.lblpagamento.Name = "lblpagamento";
            this.lblpagamento.Size = new System.Drawing.Size(189, 13);
            this.lblpagamento.TabIndex = 2;
            this.lblpagamento.Text = "Insira os dias de atraso no pagamento.";
            this.lblpagamento.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtatraso
            // 
            this.txtatraso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtatraso.Location = new System.Drawing.Point(200, 185);
            this.txtatraso.Name = "txtatraso";
            this.txtatraso.Size = new System.Drawing.Size(89, 20);
            this.txtatraso.TabIndex = 3;
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(200, 140);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(89, 20);
            this.txtconta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.txtconta);
            this.Controls.Add(this.txtatraso);
            this.Controls.Add(this.lblpagamento);
            this.Controls.Add(this.lblconta);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblconta;
        private System.Windows.Forms.Label lblpagamento;
        private System.Windows.Forms.TextBox txtatraso;
        private System.Windows.Forms.TextBox txtconta;
    }
}

