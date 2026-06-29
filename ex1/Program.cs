using System;
using System.Windows.Forms;

namespace ex1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] meses = new[]
            {
                "Janeiro","Fevereiro","Março","Abril","Maio","Junho",
                "Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"
            };

            string texto = string.Join(Environment.NewLine, meses);
            MessageBox.Show(texto, "Meses do Ano");
        }
    }
}
