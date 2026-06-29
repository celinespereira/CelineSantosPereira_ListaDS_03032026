namespace ex35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroStr = textBox1.Text;

            if (numeroStr.Length == 3)
            {
                char c = numeroStr[0];
                char d = numeroStr[1];
                char u = numeroStr[2];

                string invertido = u.ToString() + d.ToString() + c.ToString();
                int numeroInvertido = int.Parse(invertido);

                label2.Text = $"Original: {numeroStr}\nInvertido: {numeroInvertido}";
            }
            else
            {
                label2.Text = "Digite um número de 3 dígitos!";
            }
        }
    }
}
