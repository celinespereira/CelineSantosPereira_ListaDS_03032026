namespace ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nome: Celine Santos Pereira\n" +
                           "Nascimento: 07/11/2009\n" +
                           "Endereço: Rua Agvaldo antonin, 67\n" +
                           "Telefone: (11) 99999-9999";
        }
    }
}
