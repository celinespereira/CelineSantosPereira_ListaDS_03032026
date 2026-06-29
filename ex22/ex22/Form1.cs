namespace ex22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);

            string resultado = $"Soma: {n1 + n2:F2}\n" +
                              $"Sub: {n1 - n2:F2}\n" +
                              $"Mult: {n1 * n2:F2}\n" +
                              $"Div: {(n2 != 0 ? (n1 / n2).ToString("F2") : "erro")}";

            label4.Text = resultado;
        }
    }
}
