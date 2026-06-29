namespace ex28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseRet = double.Parse(textBox1.Text);
            double altura = double.Parse(textBox2.Text);

            double perimetro = 2 * (baseRet + altura);
            double area = baseRet * altura;
            double diagonal = Math.Sqrt(Math.Pow(baseRet, 2) + Math.Pow(altura, 2));

            label4.Text = $"Perímetro: {perimetro:F2}\nÁrea: {area:F2}\nDiagonal: {diagonal:F2}";
        }
    }
}
