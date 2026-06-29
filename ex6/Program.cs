using System;
using System.Windows.Forms;

namespace ex6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string texto = string.Join("-", new[] { "1", "2", "3", "4", "5" });
            MessageBox.Show(texto, "Números de 1 a 5");
        }
    }
}
