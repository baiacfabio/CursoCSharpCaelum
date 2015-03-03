using System;
using System.Windows.Forms;

namespace Banco.Contas
{
    class ContaCorrente: Conta, ITributavel
    {

        public ContaCorrente() : base()
        {
            
            this.taxaSaque = 0.05;
            this.taxaDeposito = 0.10;
        }

        public override bool Saca(double valor)
        {
            if (this.Saldo >= (valor + taxaSaque))
            {
                this.Saldo -= (valor + taxaSaque);
                MessageBox.Show("Saque realizado com Sucesso!");
                return true;
            }
            else
            {
                throw new SaldoInsuficienteException();
            }

        }

        public override void Deposita(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Não é possível depositar um valor negativo");
            }
            this.Saldo += (valor - taxaDeposito);
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}
