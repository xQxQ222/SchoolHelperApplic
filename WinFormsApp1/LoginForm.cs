using MySqlConnector;
using System.Data;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = LoginField.Text;
            String password = PasswordField.Text;

            bool userIsLoggedInSuccessfully = ReadFromDB.ReadCurrentUser(login, password); // выглядит нелогично

            if (userIsLoggedInSuccessfully)
            {
                MessageBox.Show("Пользователь успешно авторизован");
                Thread.Sleep(500);

                var form = new Menu();
                form.Show();
                this.Close();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var startScreen = new StartScreen();
            startScreen.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
                PasswordField.UseSystemPasswordChar = false;
            else if (ShowPassword.Checked == false)
                PasswordField.UseSystemPasswordChar = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ChangePass();
            form.Show();
            this.Close();
        }
    }
}
