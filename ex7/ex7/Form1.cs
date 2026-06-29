namespace ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Janeiro\nFevereiro\nMarço\nAbril\nMaio\nJunho\n" +
                           "Julho\nAgosto\nSetembro\nOutubro\nNovembro\nDezembro";
        }
    }
}
