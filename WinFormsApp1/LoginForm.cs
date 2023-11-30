using MySql.Data.MySqlClient;
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

            DB db = new DB();
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь успешно авторизован");
                Thread.Sleep(500);

                var read = command.ExecuteReader();
                read.Read();

                var withoutTime = read.GetString(6).Split(' ')[0];
                var day = int.Parse(withoutTime.Split('.')[0]);
                var month = int.Parse(withoutTime.Split('.')[1]);
                var year = int.Parse(withoutTime.Split(".")[2]);
                var date = new DateTime(year, month, day);
                currentUser._id = int.Parse(read.GetString(0));
                currentUser._login = read.GetString(1);
                currentUser._password = read.GetString(2);
                currentUser._name = read.GetString(3);
                currentUser._surename = read.GetString(4);
                currentUser._patronymic = read.GetString(5);
                currentUser._Date = date;
                currentUser._status = read.GetString(7);
                currentUser._email = read.GetString(8);
                var form = new Menu();
                form.Show();
                this.Close();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
            db.closeConnection();
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
