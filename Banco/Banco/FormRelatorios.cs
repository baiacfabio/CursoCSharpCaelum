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

namespace Banco
{
    public partial class FormRelatorios : Form
    {

        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas )
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void buttonFiltroSaldo_Click(object sender, EventArgs e)
        {
            //primeiramente limpa a lista
            listBoxResultado.Items.Clear();

            //busca por contas com saldo maior que 5000
            var resultado = from c in contas 
                where c.Saldo > 5000
                orderby c.Titular.Nome ascending
                select new { c.Numero, c.Titular, c.Saldo };
            
            foreach (var c in resultado)
            {
                listBoxResultado.Items.Add(c);
            }

            //atualiza os valores do Resumo
            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            labelSaldoTotalValue.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldoValue.Text = Convert.ToString(maiorSaldo);
        }

        private void buttonAntigas_Click(object sender, EventArgs e)
        {
            //primeiramente limpa a lista
            listBoxResultado.Items.Clear();

            //busca por contas antigas (inferiores a 10), com saldo maior que 1000

            //forma 1 
            var resultado = from c in contas
                            where c.Saldo > 1000 && c.Numero < 10
                            orderby c.Titular.Nome ascending, c.Numero descending 
                            select new { c.Numero, c.Titular, c.Saldo };

            //forma 2
            /*var resultado = contas
                    .Where(c => c.Saldo > 1000 && c.Numero < 10)
                    .OrderBy(c => c.Titular.Nome)
                    .ThenBy(c => c.Numero;*/

            foreach (var c in resultado)
            {
                listBoxResultado.Items.Add(c);
            }


            //atualiza os valores do Resumo
            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            labelSaldoTotalValue.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldoValue.Text = Convert.ToString(maiorSaldo);
        }
    }
}
