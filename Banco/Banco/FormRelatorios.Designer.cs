namespace Banco
{
    partial class FormRelatorios
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
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonFiltroSaldo = new System.Windows.Forms.Button();
            this.buttonAntigas = new System.Windows.Forms.Button();
            this.groupBoxResumo = new System.Windows.Forms.GroupBox();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.labelMaiorSaldoValue = new System.Windows.Forms.Label();
            this.labelSaldoTotalValue = new System.Windows.Forms.Label();
            this.groupBoxResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(13, 13);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(259, 121);
            this.listBoxResultado.TabIndex = 0;
            // 
            // buttonFiltroSaldo
            // 
            this.buttonFiltroSaldo.Location = new System.Drawing.Point(13, 257);
            this.buttonFiltroSaldo.Name = "buttonFiltroSaldo";
            this.buttonFiltroSaldo.Size = new System.Drawing.Size(119, 23);
            this.buttonFiltroSaldo.TabIndex = 1;
            this.buttonFiltroSaldo.Text = "Saldo > 5000";
            this.buttonFiltroSaldo.UseVisualStyleBackColor = true;
            this.buttonFiltroSaldo.Click += new System.EventHandler(this.buttonFiltroSaldo_Click);
            // 
            // buttonAntigas
            // 
            this.buttonAntigas.Location = new System.Drawing.Point(153, 257);
            this.buttonAntigas.Name = "buttonAntigas";
            this.buttonAntigas.Size = new System.Drawing.Size(119, 23);
            this.buttonAntigas.TabIndex = 2;
            this.buttonAntigas.Text = "Antigas";
            this.buttonAntigas.UseVisualStyleBackColor = true;
            this.buttonAntigas.Click += new System.EventHandler(this.buttonAntigas_Click);
            // 
            // groupBoxResumo
            // 
            this.groupBoxResumo.Controls.Add(this.labelMaiorSaldoValue);
            this.groupBoxResumo.Controls.Add(this.labelSaldoTotalValue);
            this.groupBoxResumo.Controls.Add(this.labelMaiorSaldo);
            this.groupBoxResumo.Controls.Add(this.labelSaldoTotal);
            this.groupBoxResumo.Location = new System.Drawing.Point(13, 144);
            this.groupBoxResumo.Name = "groupBoxResumo";
            this.groupBoxResumo.Size = new System.Drawing.Size(259, 100);
            this.groupBoxResumo.TabIndex = 3;
            this.groupBoxResumo.TabStop = false;
            this.groupBoxResumo.Text = "Resumo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(7, 20);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(61, 13);
            this.labelSaldoTotal.TabIndex = 0;
            this.labelSaldoTotal.Text = "Saldo Total";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(7, 57);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(63, 13);
            this.labelMaiorSaldo.TabIndex = 1;
            this.labelMaiorSaldo.Text = "Maior Saldo";
            // 
            // labelMaiorSaldoValue
            // 
            this.labelMaiorSaldoValue.AutoSize = true;
            this.labelMaiorSaldoValue.Location = new System.Drawing.Point(137, 57);
            this.labelMaiorSaldoValue.Name = "labelMaiorSaldoValue";
            this.labelMaiorSaldoValue.Size = new System.Drawing.Size(10, 13);
            this.labelMaiorSaldoValue.TabIndex = 3;
            this.labelMaiorSaldoValue.Text = "-";
            // 
            // labelSaldoTotalValue
            // 
            this.labelSaldoTotalValue.AutoSize = true;
            this.labelSaldoTotalValue.Location = new System.Drawing.Point(137, 20);
            this.labelSaldoTotalValue.Name = "labelSaldoTotalValue";
            this.labelSaldoTotalValue.Size = new System.Drawing.Size(10, 13);
            this.labelSaldoTotalValue.TabIndex = 2;
            this.labelSaldoTotalValue.Text = "-";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 295);
            this.Controls.Add(this.groupBoxResumo);
            this.Controls.Add(this.buttonAntigas);
            this.Controls.Add(this.buttonFiltroSaldo);
            this.Controls.Add(this.listBoxResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBoxResumo.ResumeLayout(false);
            this.groupBoxResumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonFiltroSaldo;
        private System.Windows.Forms.Button buttonAntigas;
        private System.Windows.Forms.GroupBox groupBoxResumo;
        private System.Windows.Forms.Label labelMaiorSaldoValue;
        private System.Windows.Forms.Label labelSaldoTotalValue;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;

    }
}