namespace ex20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario = double.Parse(textBox1.Text);
            double novo = salario * 1.30;

            MessageBox.Show($"Salário original: R$ {salario:F2}\n" +
                           $"Novo salário (30%): R$ {novo:F2}");
        }
    }
}
