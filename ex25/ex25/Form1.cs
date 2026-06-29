namespace ex25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int antecessor = numero - 1;
            int sucessor = numero + 1;

            label3.Text = $"Antecessor: {antecessor}\nSucessor: {sucessor}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
