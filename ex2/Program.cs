using System;
using System.Windows.Forms;

namespace ex2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] dias = new[]
            {
                "Domingo","Segunda-feira","Terça-feira","Quarta-feira",
                "Quinta-feira","Sexta-feira","Sábado"
            };

            string texto = string.Join(Environment.NewLine, dias);
            MessageBox.Show(texto, "Dias da Semana");
        }
    }
}
