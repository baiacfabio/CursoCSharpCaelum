using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Usuarios
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string rg;
        private string endereco;
        private int idade;

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            if (this.Idade > 18)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
