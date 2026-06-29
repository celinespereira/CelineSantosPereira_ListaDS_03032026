namespace ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabuada = "";

            for (int i = 0; i <= 10; i++)
            {
                tabuada = tabuada + "3 x " + i + " = " + (3 * i) + "\n";
            }

            MessageBox.Show(tabuada, "Tabuada do 3");
        }
    }
}
