namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string meses = "Janeiro\n" +
                           "Fevereiro\n" +
                           "Março\n" +
                           "Abril\n" +
                           "Maio\n" +
                           "Junho\n" +
                           "Julho\n" +
                           "Agosto\n" +
                           "Setembro\n" +
                           "Outubro\n" +
                           "Novembro\n" +
                           "Dezembro";

            MessageBox.Show(meses, "Meses do Ano");
        }
    }
}
