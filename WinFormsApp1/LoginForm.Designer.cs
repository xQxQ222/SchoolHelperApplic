namespace WinFormsApp1
{
    partial class LoginForm
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
            LoginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            LoginField = new TextBox();
            PasswordField = new TextBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ShowPassword = new CheckBox();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(592, 486);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(128, 41);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 204);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(283, 293);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // LoginField
            // 
            LoginField.Cursor = Cursors.IBeam;
            LoginField.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginField.Location = new Point(283, 229);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(202, 29);
            LoginField.TabIndex = 3;
            LoginField.TextChanged += textBox1_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.Cursor = Cursors.IBeam;
            PasswordField.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(283, 318);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(202, 29);
            PasswordField.TabIndex = 4;
            PasswordField.UseSystemPasswordChar = true;
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(233, 47);
            label3.Name = "label3";
            label3.Size = new Size(313, 61);
            label3.TabIndex = 5;
            label3.Text = "Авторизация";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(75, 486);
            button1.Name = "button1";
            button1.Size = new Size(128, 41);
            button1.TabIndex = 6;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1564535_customer_user_userphoto_account_person_icon;
            pictureBox1.Location = new Point(247, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._8201380_unlock_padlock_password_ui_lock_icon;
            pictureBox2.Location = new Point(247, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPassword.Location = new Point(491, 325);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(126, 20);
            ShowPassword.TabIndex = 9;
            ShowPassword.Text = "Показать пароль";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(752, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 34);
            label8.TabIndex = 27;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(387, 350);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 15);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Забыли пароль?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(784, 561);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(ShowPassword);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(PasswordField);
            Controls.Add(LoginField);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginForm";
            Load += LoginForm_Load;
            MouseDown += LoginForm_MouseDown;
            MouseMove += LoginForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label label1;
        private Label label2;
        private TextBox LoginField;
        private TextBox PasswordField;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox ShowPassword;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}