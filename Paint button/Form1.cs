namespace Paint_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.PointToScreen(e.Location);
           
        }
    }
}