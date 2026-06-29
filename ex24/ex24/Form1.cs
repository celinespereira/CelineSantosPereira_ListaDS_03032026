namespace ex24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += $"{n} x {i} = {n * i}\n";
            }

            label3.Text = resultado;
        }
    }
}
