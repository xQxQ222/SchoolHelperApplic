namespace WinFormsApp1
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            name = new Label();
            surename = new Label();
            patronymic = new Label();
            birthDate = new Label();
            status = new Label();
            email = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(745, -1);
            label1.Name = "label1";
            label1.Size = new Size(41, 43);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._628287_anonym_avatar_default_head_person_icon;
            pictureBox1.Location = new Point(64, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(90, 243);
            button1.Name = "button1";
            button1.Size = new Size(152, 44);
            button1.TabIndex = 2;
            button1.Text = "Сменить фотографию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(375, 37);
            label2.Name = "label2";
            label2.Size = new Size(331, 37);
            label2.TabIndex = 3;
            label2.Text = "Общая информация:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(375, 130);
            label3.Name = "label3";
            label3.Size = new Size(171, 286);
            label3.TabIndex = 4;
            label3.Text = "Имя:\r\n\r\nФамилия:\r\n\r\nОтчество:\r\n\r\nДата рождения:\r\n\r\nСтатус:\r\n\r\nE-mail:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(441, 132);
            name.Name = "name";
            name.Size = new Size(67, 24);
            name.TabIndex = 5;
            name.Text = "label4";
            // 
            // surename
            // 
            surename.AutoSize = true;
            surename.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            surename.Location = new Point(488, 183);
            surename.Name = "surename";
            surename.Size = new Size(67, 24);
            surename.TabIndex = 6;
            surename.Text = "label5";
            // 
            // patronymic
            // 
            patronymic.AutoSize = true;
            patronymic.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            patronymic.Location = new Point(488, 234);
            patronymic.Name = "patronymic";
            patronymic.Size = new Size(67, 24);
            patronymic.TabIndex = 7;
            patronymic.Text = "label6";
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            birthDate.Location = new Point(552, 287);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(67, 24);
            birthDate.TabIndex = 8;
            birthDate.Text = "label7";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            status.Location = new Point(463, 338);
            status.Name = "status";
            status.Size = new Size(67, 24);
            status.TabIndex = 9;
            status.Text = "label8";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(463, 392);
            email.Name = "email";
            email.Size = new Size(67, 24);
            email.TabIndex = 10;
            email.Text = "label9";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 479);
            button2.Name = "button2";
            button2.Size = new Size(120, 70);
            button2.TabIndex = 42;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(784, 561);
            Controls.Add(button2);
            Controls.Add(email);
            Controls.Add(status);
            Controls.Add(birthDate);
            Controls.Add(patronymic);
            Controls.Add(surename);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label name;
        private Label surename;
        private Label patronymic;
        private Label birthDate;
        private Label status;
        private Label email;
        private Button button2;
    }
}