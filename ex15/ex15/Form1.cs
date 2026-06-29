namespace ex15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "3 x 0 = 0\n3 x 1 = 3\n3 x 2 = 6\n3 x 3 = 9\n" +
                         "3 x 4 = 12\n3 x 5 = 15\n3 x 6 = 18\n3 x 7 = 21\n" +
                         "3 x 8 = 24\n3 x 9 = 27\n3 x 10 = 30";
        }
    }
}
