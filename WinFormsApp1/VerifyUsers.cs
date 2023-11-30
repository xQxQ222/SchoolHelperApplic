namespace WinFormsApp1
{
    public partial class VerifyUsers : Form
    {
        public VerifyUsers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerifyUsers_Load(object sender, EventArgs e)
        {
            verifyUser.Rows.Add("Иванов", "Алексей", "Романович", "Ученик", "14.06.2004");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
