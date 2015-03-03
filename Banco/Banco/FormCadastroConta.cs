using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Usuarios;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        private string tipoConta;
        private string[] tiposContas = {"Conta Corrente", "Conta Poupança"};

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Conta conta = null;
            if (this.tipoConta.Equals("Conta Corrente"))
            {
                conta = new ContaCorrente();
            }
            else if (this.tipoConta.Equals("Conta Poupança"))
            {
                conta = new ContaPoupanca();
            }


            conta.Titular = new Cliente(textBoxTitular.Text);

            this.formPrincipal.AdicionaConta(conta);
            this.Hide();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            foreach (string tipoConta in tiposContas)
            {
                comboTipo.Items.Add(tipoConta);
            }

            textBoxNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoConta = tiposContas[comboTipo.SelectedIndex];
        }
    }
}
