namespace WinFormsApp1
{
    public partial class StartScreen : Form
    {
        
        public StartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();
            regForm.Show();
            Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var regForm = new LoginForm();
            regForm.Show();
            Hide();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
        }
        private void StartScreen_Resize(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void StartScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StartScreen_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}