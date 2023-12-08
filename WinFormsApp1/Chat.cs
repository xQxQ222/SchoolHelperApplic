using MySqlConnector;
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
            var recip = ReadFromDB.GetRecipients();
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
            var recip = ReadFromDB.GetRecipients();
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
