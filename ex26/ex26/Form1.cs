namespace ex26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = int.Parse(textBox1.Text);
            int divisor = int.Parse(textBox2.Text);

            if (divisor != 0)
            {
                int quociente = dividendo / divisor;
                int resto = dividendo % divisor;

                label4.Text = $"Dividendo: {dividendo}\nDivisor: {divisor}\nQuociente: {quociente}\nResto: {resto}";
            }
            else
            {
                label4.Text = "Não é possível dividir por zero!";
            }
        }
    }
}
