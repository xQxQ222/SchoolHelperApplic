using MySqlConnector;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace WinFormsApp1
{

    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
                "",
                "Администратор",
                "Учитель",
                "Ученик"
            };
            list.Sort();
            status.DataSource = list;
            codeField.Enabled = false;
            codeField.Visible = false;
            pictureBox5.Visible = false;
            label7.Visible = false;
            ConfirmCodeButton.Visible = false;
            ConfirmCodeButton.Enabled = false;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
                PasswordField.UseSystemPasswordChar = false;
            else if (ShowPassword.Checked == false)
                PasswordField.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new StartScreen();
            form.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        Point lastPoint;
        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if (checkUser() || checkEmail())
            if (ReadFromDB.CheckIfNameOfUserInBD(LoginField.Text) || ReadFromDB.CheckIfEmailInBD(emailBox.Text))
            {
                MessageBox.Show("Пользователь с таким логином или E-mail уже существует");
                return;
            }
            //Тута лежит закоментированный предыдущий код
            #region
            //DB db = new DB();
            //MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `last name`,`otchestvo`, `birthdate`, `status`,`email`) VALUES (@log,@pass,@name,@surename,@otch,@birthDate,@status,@email);", db.getConnection());

            //command.Parameters.Add("@log", MySqlDbType.VarChar).Value = LoginField.Text;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordField.Text;
            //command.Parameters.Add("@name", MySqlDbType.Text).Value = name.Text;
            //command.Parameters.Add("@surename", MySqlDbType.Text).Value = surname.Text;
            //command.Parameters.Add("@otch", MySqlDbType.VarChar).Value = Otchestvo.Text;
            //command.Parameters.Add("@birthDate", MySqlDbType.Date).Value = birthDate.Value;
            //command.Parameters.Add("@status", MySqlDbType.Text).Value = status.Text;
            //command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailBox.Text;

            //db.openConnection();
            //if (command.ExecuteNonQuery() == 1)
            //    MessageBox.Show("Пользователь успешно зарегистрирован");
            //else
            //{
            //    MessageBox.Show("Ошибка в регистрации. Проверьте заполнены ли все поля");
            //    return;
            //}
            //db.closeConnection();
            #endregion 

            User newUser = new User() {_login = LoginField.Text, _password = PasswordField.Text,_name = name.Text, _surename = surname.Text,
                _patronymic = Otchestvo.Text, _Date = birthDate.Value, _status = status.Text, _email = emailBox.Text};
                    
            var userSuccessfullyRegistered = WriteToDB.RegisterANewUser(newUser); // логически странно

            if (userSuccessfullyRegistered)
                MessageBox.Show("Пользователь успешно зарегистрирован");
            else
            {
                MessageBox.Show("Ошибка в регистрации. Проверьте заполнены ли все поля");
                return;
            }

            Thread.Sleep(1000);
            var form = new StartScreen();
            form.Show();
            this.Close();
        }

        //public bool checkUser()
        //{
        //    DB db = new DB();
        //    DataTable dt = new DataTable();

        //    MySqlDataAdapter adapter = new MySqlDataAdapter();

        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
        //    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);

        //    if (dt.Rows.Count > 0)
        //    {
        //        MessageBox.Show("Пользователь с таким именем уже существует");
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        //public bool checkEmail() 
        //{
        //    DB db = new DB();
        //    DataTable dt = new DataTable();

        //    MySqlDataAdapter adapter = new MySqlDataAdapter();

        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email`=@uE", db.getConnection());
        //    command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = emailBox.Text;

        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);

        //    if (dt.Rows.Count > 0)
        //    {
        //        MessageBox.Show("Пользователь с такой почтой уже существует");
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stat = status.SelectedItem.ToString();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void SurnameLabel_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            emailBox.Enabled = false;
            codeField.Enabled = true;
            codeField.Visible = true;
            label7.Visible = true;
            pictureBox5.Visible = true;
            ConfirmCodeButton.Visible = true;
            ConfirmCodeButton.Enabled = true;
            button2.Visible = false;
            button2.Enabled = false;
            int code = SendMessage(emailBox.Text);
            _code = code;
        }
        int _code;
        bool isCorrectCode = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (isCorrectEmailCode(_code))
            {
                codeField.Enabled = false;
                codeField.Visible = false;
                pictureBox5.Visible = false;
                ConfirmCodeButton.Visible = false;
                ConfirmCodeButton.Enabled = false;
                label7.Visible = false;
                isCorrectCode = true;
            }
            else
            {
                MessageBox.Show("Неверный код подтверждения");
            }
        }
        public bool isCorrectEmailCode(int code)
        {
            if (codeField.Text == code.ToString() && codeField.Text != "0")
            {
                return true;
            }
            return false;
        }
        public int SendMessage(string adressTo)
        {
            emailBox.Enabled = false;
            try
            {
                string from = @"schoolhelper634@gmail.com"; // адреса отправителя
                string pass = "ewlr vryt jiey qyqa"; // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = "Одноразовый код для подтверждения почты"; // тема
                var r = new Random();
                var code = r.Next(100000, 999999);
                mess.Body = code.ToString(); // текст сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com"; //smtp-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); // отправка пользователю
                MessageBox.Show("Сообщение было отправлено на почту");
                return code;
            }
            catch
            {
                MessageBox.Show("Ошибка отправки. Проверьте правильность написания почты");
                return 0;
            }

        }
    }
}
