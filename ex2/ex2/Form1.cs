namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Domingo\nSegunda\nTerça\nQuarta\nQuinta\nSexta\nSábado",
                          "Dias da Semana");
        }
    }
}
