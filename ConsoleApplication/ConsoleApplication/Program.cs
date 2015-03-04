using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mensagem que vai para o terminal");

            TextReader leitor = Console.In;
            TextWriter escritor = Console.Out;

            string linha = leitor.ReadLine();
            

            while (linha != null)
            {
                linha = leitor.ReadLine();

                //escreve o que o usuario digita
                escritor.WriteLine("You say: "+linha);

            }
        }
    }
}
