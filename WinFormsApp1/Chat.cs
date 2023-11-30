using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            var recip = GetRecipients();
            comboBox1.DataSource = recip.Item1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            var recip = GetRecipients();
            DB dB = new DB();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `messages` (`sender`, `recipient`, `message`, `messageDate`) VALUES (@sender, @recipient, @message, @messageDate)", dB.getConnection());
            cmd.Parameters.Add("@sender", MySqlDbType.VarChar).Value = currentUser._login;
            cmd.Parameters.Add("@recipient", MySqlDbType.VarChar).Value = recip.Item2[comboBox1.Text];
            cmd.Parameters.Add("@message", MySqlDbType.Text).Value = richTextBox1.Text;
            cmd.Parameters.Add("@messageDate", MySqlDbType.Date).Value = DateTime.Now;
            dB.openConnection();
            MessageBox.Show("Сообщение успешно отправлено");
            richTextBox1.Clear();
            cmd.ExecuteNonQuery();
            dB.closeConnection();
        }

        public Tuple<List<string>, Dictionary<string, string>> GetRecipients()
        {
            var list = new List<string>();
            var dic = new Dictionary<string, string>();
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = null;
            if (currentUser._status == "Ученик")
                command = new MySqlCommand("SELECT * FROM `users` WHERE `status` LIKE 'Учитель'", db.getConnection());
            else if (currentUser._status == "Учитель")
                command = new MySqlCommand("SELECT * FROM `users` WHERE 'status' LIKE 'Учитель' OR 'Ученик'", db.getConnection());
            else
            {
                command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.openConnection();
            list.Add("");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var read = command.ExecuteReader();
                    read.Read();
                    var login = read.GetString(1);
                    var name = read.GetString(3);
                    var surname = read.GetString(4);
                    var patronymic = read.GetString(5);
                    var fullName = $"{surname} {name.Substring(0, 1)}. {patronymic.Substring(0, 1)}.";
                    string teacher = fullName;
                    dic[fullName] = login;
                    list.Add(teacher);
                }
            }
            db.closeConnection();
            var tuple = new Tuple<List<string>, Dictionary<string, string>>(list, dic);
            return tuple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
