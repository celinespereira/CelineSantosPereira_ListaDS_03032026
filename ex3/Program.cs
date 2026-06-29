using System;
using System.Text;
using System.Windows.Forms;

namespace ex3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StringBuilder sb = new StringBuilder();
            int n = 3;
            for (int i = 0; i <= 10; i++)
            {
                sb.Append($"{n} X {i} = {n * i};");
                if (i < 10) sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Tabuada do 3");
        }
    }
}
