namespace ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nome: Celine Santos Pereira\n" +
                         "Nascimento: 77/77/7777\n" +
                         "Endereço: Rua Thiago Pereira Antonelo, 13\n" +
                         "Telefone: (11) 676767-6767";
        }
    }
}
