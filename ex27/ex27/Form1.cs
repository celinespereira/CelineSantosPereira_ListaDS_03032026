namespace ex27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = double.Parse(textBox1.Text);
            double novoSaldo = saldo * 1.01;

            label2.Text = $"Saldo original: R$ {saldo:F2}\nNovo saldo: R$ {novoSaldo:F2}";
        }
    }
}
