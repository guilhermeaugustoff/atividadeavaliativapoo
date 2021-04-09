namespace Atividade_Avaliativa_POO
{
    partial class Form3
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdiarias = new System.Windows.Forms.TextBox();
            this.lblpagamento = new System.Windows.Forms.Label();
            this.lblconta = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(360, 180);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(81, 20);
            this.txtnome.TabIndex = 9;
            // 
            // txtdiarias
            // 
            this.txtdiarias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtdiarias.Location = new System.Drawing.Point(360, 225);
            this.txtdiarias.Name = "txtdiarias";
            this.txtdiarias.Size = new System.Drawing.Size(81, 20);
            this.txtdiarias.TabIndex = 8;
            this.txtdiarias.TextChanged += new System.EventHandler(this.txtdiarias_TextChanged);
            // 
            // lblpagamento
            // 
            this.lblpagamento.AutoSize = true;
            this.lblpagamento.Location = new System.Drawing.Point(329, 209);
            this.lblpagamento.Name = "lblpagamento";
            this.lblpagamento.Size = new System.Drawing.Size(148, 13);
            this.lblpagamento.TabIndex = 7;
            this.lblpagamento.Text = "Insira a quantidade de diárias.";
            this.lblpagamento.Click += new System.EventHandler(this.lblpagamento_Click);
            // 
            // lblconta
            // 
            this.lblconta.AutoSize = true;
            this.lblconta.Location = new System.Drawing.Point(357, 164);
            this.lblconta.Name = "lblconta";
            this.lblconta.Size = new System.Drawing.Size(84, 13);
            this.lblconta.TabIndex = 6;
            this.lblconta.Text = "Insira seu nome.";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(360, 262);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(81, 23);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtdiarias);
            this.Controls.Add(this.lblpagamento);
            this.Controls.Add(this.lblconta);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdiarias;
        private System.Windows.Forms.Label lblpagamento;
        private System.Windows.Forms.Label lblconta;
        private System.Windows.Forms.Button btncalcular;
    }
}