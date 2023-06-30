namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int X = rnd.Next(0, 600);
            int Y = rnd.Next(0, 450);
            button1.Location = new Point(X, Y);
        }

    }
}