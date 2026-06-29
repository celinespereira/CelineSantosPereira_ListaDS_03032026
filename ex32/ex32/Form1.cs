namespace ex32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(textBox1.Text);

            double perimetro = 2 * Math.PI * raio;
            double area = Math.PI * Math.Pow(raio, 2);

            label2.Text = $"Perímetro: {perimetro:F2}\nÁrea: {area:F2}";
        }
    }
}
