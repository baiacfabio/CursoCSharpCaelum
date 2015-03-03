namespace Banco
{
    partial class Form1
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
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.labelTitular = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxTitular = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.groupBoxBusca = new System.Windows.Forms.GroupBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.labelBusca = new System.Windows.Forms.Label();
            this.buttonNovaConta = new System.Windows.Forms.Button();
            this.buttonCalcImpostos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.Location = new System.Drawing.Point(9, 188);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar.TabIndex = 0;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = true;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Location = new System.Drawing.Point(6, 26);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(36, 13);
            this.labelTitular.TabIndex = 1;
            this.labelTitular.Text = "Titular";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(6, 61);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "Numero";
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.Location = new System.Drawing.Point(121, 23);
            this.textBoxTitular.Name = "textBoxTitular";
            this.textBoxTitular.Size = new System.Drawing.Size(202, 20);
            this.textBoxTitular.TabIndex = 3;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(121, 58);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(202, 20);
            this.textBoxNumero.TabIndex = 4;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(121, 93);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(202, 20);
            this.textBoxSaldo.TabIndex = 6;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(6, 96);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(34, 13);
            this.labelSaldo.TabIndex = 5;
            this.labelSaldo.Text = "Saldo";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(121, 129);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(202, 20);
            this.textBoxValor.TabIndex = 8;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(6, 132);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(31, 13);
            this.labelValor.TabIndex = 7;
            this.labelValor.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCalcImpostos);
            this.groupBox1.Controls.Add(this.buttonNovaConta);
            this.groupBox1.Controls.Add(this.buttonTransferir);
            this.groupBox1.Controls.Add(this.buttonSacar);
            this.groupBox1.Controls.Add(this.labelTitular);
            this.groupBox1.Controls.Add(this.buttonDepositar);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(this.labelNumero);
            this.groupBox1.Controls.Add(this.labelValor);
            this.groupBox1.Controls.Add(this.textBoxTitular);
            this.groupBox1.Controls.Add(this.textBoxSaldo);
            this.groupBox1.Controls.Add(this.textBoxNumero);
            this.groupBox1.Controls.Add(this.labelSaldo);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Location = new System.Drawing.Point(168, 188);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(75, 23);
            this.buttonTransferir.TabIndex = 10;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTranferir_Click);
            // 
            // buttonSacar
            // 
            this.buttonSacar.Location = new System.Drawing.Point(89, 188);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(75, 23);
            this.buttonSacar.TabIndex = 9;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = true;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // groupBoxBusca
            // 
            this.groupBoxBusca.Controls.Add(this.comboDestino);
            this.groupBoxBusca.Controls.Add(this.labelDestino);
            this.groupBoxBusca.Controls.Add(this.comboContas);
            this.groupBoxBusca.Controls.Add(this.labelBusca);
            this.groupBoxBusca.Location = new System.Drawing.Point(12, 14);
            this.groupBoxBusca.Name = "groupBoxBusca";
            this.groupBoxBusca.Size = new System.Drawing.Size(338, 100);
            this.groupBoxBusca.TabIndex = 10;
            this.groupBoxBusca.TabStop = false;
            this.groupBoxBusca.Text = "Busca de Conta";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(121, 64);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(202, 21);
            this.comboDestino.TabIndex = 3;
            this.comboDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(6, 67);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(74, 13);
            this.labelDestino.TabIndex = 2;
            this.labelDestino.Text = "Conta Destino";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(121, 26);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(202, 21);
            this.comboContas.TabIndex = 1;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // labelBusca
            // 
            this.labelBusca.AutoSize = true;
            this.labelBusca.Location = new System.Drawing.Point(6, 29);
            this.labelBusca.Name = "labelBusca";
            this.labelBusca.Size = new System.Drawing.Size(85, 13);
            this.labelBusca.TabIndex = 0;
            this.labelBusca.Text = "Escolha a Conta";
            // 
            // buttonNovaConta
            // 
            this.buttonNovaConta.Location = new System.Drawing.Point(248, 188);
            this.buttonNovaConta.Name = "buttonNovaConta";
            this.buttonNovaConta.Size = new System.Drawing.Size(75, 23);
            this.buttonNovaConta.TabIndex = 11;
            this.buttonNovaConta.Text = "Nova Conta";
            this.buttonNovaConta.UseVisualStyleBackColor = true;
            this.buttonNovaConta.Click += new System.EventHandler(this.buttonNovaConta_Click);
            // 
            // buttonCalcImpostos
            // 
            this.buttonCalcImpostos.Location = new System.Drawing.Point(9, 217);
            this.buttonCalcImpostos.Name = "buttonCalcImpostos";
            this.buttonCalcImpostos.Size = new System.Drawing.Size(155, 23);
            this.buttonCalcImpostos.TabIndex = 12;
            this.buttonCalcImpostos.Text = "Calcular Tributos";
            this.buttonCalcImpostos.UseVisualStyleBackColor = true;
            this.buttonCalcImpostos.Click += new System.EventHandler(this.buttonCalcImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 370);
            this.Controls.Add(this.groupBoxBusca);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBusca.ResumeLayout(false);
            this.groupBoxBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxTitular;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.GroupBox groupBoxBusca;
        private System.Windows.Forms.Label labelBusca;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.Button buttonNovaConta;
        private System.Windows.Forms.Button buttonCalcImpostos;
    }
}

