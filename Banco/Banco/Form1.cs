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
    public partial class Form1 : Form
    {

        private Conta[] contas;
        private int numeroDeContas;


        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            Conta[] maisContas = new Conta[this.numeroDeContas + 1];

            //adiciona as contas do array antigo ao novo array maior
            int pos = 0;
            foreach(Conta c in this.contas){
                maisContas[pos] = c;
                pos++;
            }
            this.contas = maisContas;


            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;

            comboContas.Items.Add(conta);
            comboDestino.Items.Add(conta);
        }


        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            //int indice = comboContas.SelectedIndex;
            //Conta contaSelecionada = this.contas[indice];

            Conta contaSelecionada = (Conta) comboContas.SelectedItem;

            string valorDigitado = textBoxValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            try
            {
                contaSelecionada.Deposita(valorOperacao);
                textBoxSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Argumento Inválido");
            }
            
            
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            //int indice = comboContas.SelectedIndex;
            //Conta contaSelecionada = this.contas[indice];

            Conta contaSelecionada = (Conta) comboContas.SelectedItem;

            string valorDigitado = textBoxValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            try
            {
                contaSelecionada.Saca(valorOperacao);
                textBoxSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            }
            catch (SaldoInsuficienteException)
            {

                MessageBox.Show("Saldo insuficiente!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[1];

            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("Fabio");
            c1.Numero = 0;
            this.AdicionaConta(c1);
            
            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Stela");
            c2.Numero = 1;
            this.AdicionaConta(c2);

            Conta c3 = new ContaPoupanca();
            c3.Titular = new Cliente("Flavio");
            c3.Numero = 2;
            this.AdicionaConta(c3);

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indice = comboContas.SelectedIndex;
            //Conta contaSelecionada = this.contas[indice];

            Conta contaSelecionada = (Conta) comboContas.SelectedItem;

            textBoxNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textBoxTitular.Text = Convert.ToString(contaSelecionada.Titular.Nome);
            textBoxSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonTranferir_Click(object sender, EventArgs e)
        {
            //int indiceOrigem = comboContas.SelectedIndex;
            //int indiceDestino = comboDestino.SelectedIndex;

            //Conta contaOrigem = this.contas[indiceOrigem];
            //Conta contaDestino = this.contas[indiceDestino];

            Conta contaOrigem = (Conta) comboContas.SelectedItem;
            Conta contaDestino = (Conta) comboDestino.SelectedItem;

            string valorDigitado = textBoxValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            contaOrigem.Transfere(valorOperacao, contaDestino);

        }

        private void buttonNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formCadastro = new FormCadastroConta(this);
            formCadastro.ShowDialog();

        }

        private void buttonCalcImpostos_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.contas[comboContas.SelectedIndex];
            if (contaSelecionada is ITributavel)
            {
                ContaCorrente contaCorrente = (ContaCorrente)contaSelecionada;
                string tributos = Convert.ToString(contaCorrente.CalculaTributos());
                MessageBox.Show("É tributável. Tributos: " + tributos);
            }
            else
            {
                MessageBox.Show("Conta não tributável");
            }
        }

    }
}
