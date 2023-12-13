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

        private void LoginButton_Click(object sender, EventArgs e)//Метод, берущий значения логина и пароля из существующих полей и с помощью класса DB ищет пользователя в базе данных
        {
            String login = LoginField.Text;
            String password = PasswordField.Text;

            bool userIsLoggedInSuccessfully = ReadFromDB.ReadCurrentUser(login, password); 

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


        private void BackButton_Click(object sender, EventArgs e)//Метод, который при нажатии на кнопку "Назад" перекидывает пользователя на окно "StartScreen"
        {
            var startScreen = new StartScreen();
            startScreen.Show();
            Close();
        }


        private void ShowPassword_CheckedChanged(object sender, EventArgs e)//Метод, который в зависимости от выбора пользователя показывать или не показывать пароль применяет метод UseSystemPasswordChar к PasswordField
        {
            if (ShowPassword.Checked == true)
                PasswordField.UseSystemPasswordChar = false;
            else if (ShowPassword.Checked == false)
                PasswordField.UseSystemPasswordChar = true;
        }

        private void EscapeButton_Click(object sender, EventArgs e)//Метод кнопки закрытия приложения
        {
            Application.Exit();
        }
        Point lastPoint;//Переменная, в которой хранится последняя точка расположения окна на экране пользователя

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)//Метод, срабатывающий после того, как пользователь перестанет удерживать левую кнопку мыши. Изменяет значение переменной lastPoint
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)//Метод, позволяющий перемещать данное окно "StartScreen" на экране пользователя, путем зажатия левой кнопки мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ForgotPassLinkLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)//При нажатии на LinkLabel "Забыли пароль?" перекидывает пользователя на окно ChangePassword
        {
            var form = new ChangePass();
            form.Show();
            this.Close();
        }
    }
}
