using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Contas
{
    class ContaPoupanca: Conta
    {
        public ContaPoupanca() : base()
        {
            this.taxaSaque = 0.10;
            this.taxaDeposito = 0;
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
    }
}
