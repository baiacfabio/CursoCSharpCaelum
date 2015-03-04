using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using(Stream entrada = File.Open("texto.txt", FileMode.Open))
                using(StreamReader leitor = new StreamReader(entrada))
                {
                    textBoxConteudo.Text = leitor.ReadToEnd();
                }
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textBoxConteudo.Text);
            }

            
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string busca = textBoxBusca.Text;
            string textoDoEditor = textBoxConteudo.Text;
            
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0)
            {
                MessageBox.Show("Encontrado o texto: " + busca);
            }
            else
            {
                MessageBox.Show("Texto não encontrado");
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string busca = textBoxBusca.Text;
            string replacement = textBoxReplace.Text;

            string textoDoEditor = textBoxConteudo.Text;

            textoDoEditor = textoDoEditor.Replace(busca, replacement);

            //atualiza o editor
            textBoxConteudo.Text = textoDoEditor;

            //atualiza o texto no arquivo
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoDoEditor);
            }
        }

        private void buttonToUpper_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textBoxConteudo.SelectionStart;
            int tamanhoSelecao = textBoxConteudo.SelectionLength;

            // agora vamos utilizar o Substring para pegar o texto selecionado
            string textoSelecionado = textBoxConteudo.Text
                            .Substring(inicioSelecao, tamanhoSelecao);

            // além do texto selecionado, precisamos do texto antes da seleção:
            string antes = textBoxConteudo.Text
                            .Substring(0, inicioSelecao);

            // e também do texto depois
            string depois = textBoxConteudo.Text
                            .Substring(inicioSelecao + tamanhoSelecao);

            // E agora só precisamos redefinir o campo texto
            textBoxConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
        }

        private void buttonToLower_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textBoxConteudo.SelectionStart;
            int tamanhoSelecao = textBoxConteudo.SelectionLength;

            // agora vamos utilizar o Substring para pegar o texto selecionado
            string textoSelecionado = textBoxConteudo.Text
                            .Substring(inicioSelecao, tamanhoSelecao);

            // além do texto selecionado, precisamos do texto antes da seleção:
            string antes = textBoxConteudo.Text
                            .Substring(0, inicioSelecao);

            // e também do texto depois
            string depois = textBoxConteudo.Text
                            .Substring(inicioSelecao + tamanhoSelecao);

            // E agora só precisamos redefinir o campo texto
            textBoxConteudo.Text = antes + textoSelecionado.ToLower() + depois;
        }
    }
}
