using Newtonsoft.Json;
using System.Net;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        static bool isOnProfileButton;
        static bool isOnExitButton;
        public Menu()
        {
            InitializeComponent();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            if (User.Current._status == "Администратор")
            {
                button1.Location = new System.Drawing.Point(74, 146);
                button2.Location = new System.Drawing.Point(74, 398);
                button3.Location = new System.Drawing.Point(74, 635);
                button4.Location = new System.Drawing.Point(74, 837);
                pictureBox5.Location = new System.Drawing.Point(335, 165);
                pictureBox4.Location = new System.Drawing.Point(335, 417);
                pictureBox2.Location = new System.Drawing.Point(335, 654);
                pictureBox11.Location = new System.Drawing.Point(335, 856);
                richTextBox1.ReadOnly = false; richTextBox2.ReadOnly = false;
                richTextBox3.ReadOnly = false; richTextBox4.ReadOnly = false;
            }
            else
            {
                button4.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                button1.Location = new System.Drawing.Point(64, 192);
                button2.Location = new System.Drawing.Point(64, 486);
                button3.Location = new System.Drawing.Point(64, 763);
                pictureBox5.Location = new System.Drawing.Point(325, 211);
                pictureBox4.Location = new System.Drawing.Point(325, 505);
                pictureBox2.Location = new System.Drawing.Point(325, 782);
                richTextBox1.ReadOnly = true;
                richTextBox2.ReadOnly = true;
                richTextBox3.ReadOnly = true;
                richTextBox4.ReadOnly = true;
            }
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=Izhevsk&APPID=94048917cc9847b12ba053b704683a9e");
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    answer = await sr.ReadToEndAsync();
                }
            }

            response.Close();

            OpenWeather.OpenWeather oW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

            WeatherIcon.Image = oW.weather[0].Icon;

            string plus;
            if (oW.main.temp > 0)
                plus = "+";
            else
                plus = "";
            label4.Text = oW.weather[0].description;

            string[] sides = new string[] { "С", "СВ", "В", "ЮВ", "Ю", "ЮЗ", "З", "СЗ" };
            label6.Text = plus + oW.main.temp.ToString("0.#") + "°С";
            label9.Text = oW.wind.speed.ToString() + "м/с, ";
            var degr = (int)Math.Ceiling(oW.wind.deg / 45) - 1;
            label10.Text = sides[degr];
            label7.Text = oW.main.humidity.ToString() + "%";
            label8.Text = ((int)oW.main.pressure).ToString() + "мм.рт.с.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Table();
            form.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Journal();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Chat();
            form.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new VerifyUsers();
            form.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private async void pictureBox3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {


        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            var form = new Profile();
            form.Show();
            this.Close();
        }
        private bool isShow = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isShow)
                isShow = false;
            else isShow = true;
            flowLayoutPanel1.Visible = isShow;
        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var form = new StartScreen();
            form.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            var form=new CreateNews();
            form.Show();
            this.Close();
        }
    }
}
