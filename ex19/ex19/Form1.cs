namespace ex19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);

            string msg = $"Soma: {n1 + n2}\n" +
                        $"Subtração: {n1 - n2}\n" +
                        $"Multiplicação: {n1 * n2}\n" +
                        $"Divisão: {(n2 != 0 ? (n1 / n2).ToString() : "erro")}";

            MessageBox.Show(msg);
        }
    }
}
