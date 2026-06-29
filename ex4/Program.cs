using System;
using System.Windows.Forms;

namespace ex4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string nome = "Seu Nome";
            string dataNascimento = "01/01/2000";
            string endereco = "Seu Endereço, 123";
            string telefone = "(00) 00000-0000";

            string texto =
                "Nome: " + nome + Environment.NewLine +
                "Data de nascimento: " + dataNascimento + Environment.NewLine +
                "Endereço: " + endereco + Environment.NewLine +
                "Telefone: " + telefone;

            MessageBox.Show(texto, "Dados Pessoais");
        }
    }
}
