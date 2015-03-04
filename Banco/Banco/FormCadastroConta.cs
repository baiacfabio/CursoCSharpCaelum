using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Busca;
using Banco.Contas;
using Banco.Usuarios;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        private ICollection<string> devedores;

        private string tipoConta;
        private string[] tiposContas = {"Conta Corrente", "Conta Poupança"};

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string titular = textBoxTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);

            for (int i = 0; i < 30000; i++)
            {
                ehDevedor = this.devedores.Contains(titular);
            }

            if (!ehDevedor)
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
            else
            {
                MessageBox.Show("devedor");
            }
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
