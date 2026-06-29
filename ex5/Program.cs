using System;
using System.Windows.Forms;

namespace ex5
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DateTime nascimento = new DateTime(2000, 1, 1);
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - nascimento.Year;
            if (nascimento.Date > hoje.AddYears(-idade)) idade--;

            MessageBox.Show("Minha idade é: " + idade, "Idade");
        }
    }
}
