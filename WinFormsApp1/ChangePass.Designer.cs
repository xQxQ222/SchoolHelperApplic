namespace WinFormsApp1
{
    partial class ChangePass
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
            pictureBox4 = new PictureBox();
            emailBox = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            CodeBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            newPass = new TextBox();
            label3 = new Label();
            button3 = new Button();
            ShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._134146_mail_email_icon;
            pictureBox4.Location = new Point(108, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            // 
            // emailBox
            // 
            emailBox.Cursor = Cursors.IBeam;
            emailBox.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            emailBox.Location = new Point(144, 89);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(202, 29);
            emailBox.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(144, 62);
            label6.Name = "label6";
            label6.Size = new Size(66, 24);
            label6.TabIndex = 41;
            label6.Text = "E-Mail";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8678775_fingerprint_biometric_security_icon;
            pictureBox1.Location = new Point(108, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // CodeBox
            // 
            CodeBox.Cursor = Cursors.IBeam;
            CodeBox.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CodeBox.Location = new Point(144, 178);
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(79, 29);
            CodeBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 151);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 44;
            label1.Text = "Код";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(144, 121);
            label2.Name = "label2";
            label2.Size = new Size(199, 12);
            label2.TabIndex = 47;
            label2.Text = "Введите почту, привязанную к вашему аккаунту";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(352, 92);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 48;
            button1.Text = "Отправить код";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(502, 294);
            button2.Name = "button2";
            button2.Size = new Size(76, 43);
            button2.TabIndex = 49;
            button2.Text = "Далее";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1564520_code_open_password_icon;
            pictureBox2.Location = new Point(108, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // newPass
            // 
            newPass.Cursor = Cursors.IBeam;
            newPass.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            newPass.Location = new Point(144, 255);
            newPass.Name = "newPass";
            newPass.Size = new Size(202, 29);
            newPass.TabIndex = 51;
            newPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(144, 228);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 50;
            label3.Text = "Новый пароль";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(22, 295);
            button3.Name = "button3";
            button3.Size = new Size(76, 41);
            button3.TabIndex = 53;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPassword.Location = new Point(352, 264);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(126, 20);
            ShowPassword.TabIndex = 54;
            ShowPassword.Text = "Показать пароль";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(600, 350);
            Controls.Add(ShowPassword);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(newPass);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(CodeBox);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(emailBox);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePass";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePass";
            Load += ChangePass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TextBox emailBox;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox CodeBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private TextBox newPass;
        private Label label3;
        private Button button3;
        private CheckBox ShowPassword;
    }
}