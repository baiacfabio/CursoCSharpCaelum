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

        private List<Conta> contas; 
        private int numeroDeContas;

        private Dictionary<string, Conta> dicionario;


        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);

            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;

            comboContas.Items.Add(conta);
            comboDestino.Items.Add(conta);

            comboContas.DisplayMember = "Titular";
            comboDestino.DisplayMember = "Titular";

            //atualiza o dicionario
            this.dicionario.Add(conta.Titular.Nome, conta);
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
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();

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

        private void buttonBuscaTitular_Click(object sender, EventArgs e)
        {
            string nomeTitular = textBoxBuscaTitular.Text;

            try
            {
                //faz a busca no dicionario
                Conta conta = dicionario[nomeTitular];

                //atualizar o item selecionado do comboContas
                //isso ja traz os dados pra preencher os campos da conta no form
                comboContas.SelectedItem = conta;
            }
            catch (Exception)
            {
                MessageBox.Show("Titular não encontrado");
            }
        }

        private void buttonRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }

    }
}
