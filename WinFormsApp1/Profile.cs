using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            name.Text = User.Current._name;
            surename.Text = User.Current._surename;
            patronymic.Text = User.Current._patronymic;
            status.Text = User.Current._status;
            birthDate.Text = User.Current._Date.ToShortDateString();
            email.Text = User.Current._email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            this.Close();
        }
    }
}
