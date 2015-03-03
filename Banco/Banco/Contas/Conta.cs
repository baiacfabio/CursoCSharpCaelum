using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Banco.Usuarios;

namespace Banco.Contas
{
    public abstract class Conta
    {
        private double saldo;
        private Cliente titular;
        private int numero;

        protected double taxaSaque;
        protected double taxaDeposito;

        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }

        private static int numeroDeContas;


        protected Conta()
        {
            numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public abstract bool Saca(double valor);


        public abstract void Deposita(double valorOperacao);

        public virtual void Transfere(double valorOperacao, Conta contaDestino)
        {
            if (this.Saca(valorOperacao))
            {
                contaDestino.Deposita(valorOperacao);
                MessageBox.Show("Transferencia realizada com sucesso!");
            }
        }

        
        internal static int ProximoNumero()
        {
            return Conta.numeroDeContas;
        }

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }
    }
}
