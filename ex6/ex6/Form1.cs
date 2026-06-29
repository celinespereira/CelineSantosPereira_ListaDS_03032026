namespace ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeros = "";

            for (int i = 1; i <= 5; i++)
            {
                numeros += i;

                if (i < 5)
                {
                    numeros += " - "; 
                }
            }

            MessageBox.Show(numeros);
        }
    }
}
