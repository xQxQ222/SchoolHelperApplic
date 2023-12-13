namespace WinFormsApp1
{
    public partial class StartScreen : Form
    {

        public StartScreen()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)//ћетод, который срабатывает при нажатии кнопки "–егистраци€". ѕерекидывает на окно регистрации аккаунта
        {
            var regForm = new RegistrationForm();
            regForm.Show();
            Hide();
        }

        

        private void LoginButton_Click(object sender, EventArgs e)//ћетод, который срабатывает при нажатии кнопки "¬ход". ѕерекидывает на окно входа в аккаунт
        {
            var logForm = new LoginForm();
            logForm.Show();
            Hide();
        }

        

        private void ExitButton_Click(object sender, EventArgs e)//ћетод кнопки закрыти€ приложени€
        {
            Application.Exit();
        }

        Point lastPoint;//ѕеременна€, в которой хранитс€ последн€€ точка расположени€ окна на экране пользовател€
        private void StartScreen_MouseMove(object sender, MouseEventArgs e)//ћетод, позвол€ющий перемещать данное окно "StartScreen" на экране пользовател€, путем зажати€ левой кнопки мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StartScreen_MouseDown(object sender, MouseEventArgs e)//ћетод, срабатывающий после того, как пользователь перестанет удерживать левую кнопку мыши. »змен€ет значение переменной lastPoint
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}