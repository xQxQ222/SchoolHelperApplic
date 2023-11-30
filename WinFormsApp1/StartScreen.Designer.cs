namespace WinFormsApp1
{
    partial class StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Registration = new Button();
            Login = new Button();
            label1 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Registration
            // 
            Registration.AutoSize = true;
            Registration.Cursor = Cursors.Hand;
            Registration.FlatAppearance.BorderSize = 2;
            Registration.FlatStyle = FlatStyle.Flat;
            Registration.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Registration.Location = new Point(294, 316);
            Registration.Name = "Registration";
            Registration.Size = new Size(181, 58);
            Registration.TabIndex = 0;
            Registration.Text = "Регистрация";
            Registration.UseVisualStyleBackColor = true;
            Registration.Click += button1_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Cursor = Cursors.Hand;
            Login.FlatAppearance.BorderSize = 2;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Login.Location = new Point(294, 203);
            Login.Name = "Login";
            Login.Size = new Size(181, 58);
            Login.TabIndex = 1;
            Login.Text = "Вход";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 66);
            label1.Name = "label1";
            label1.Size = new Size(446, 61);
            label1.TabIndex = 2;
            label1.Text = "Добро пожаловать!";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(750, -2);
            label8.Name = "label8";
            label8.Size = new Size(34, 34);
            label8.TabIndex = 27;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(784, 561);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(Registration);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += StartScreen_Load;
            MouseDown += StartScreen_MouseDown;
            MouseMove += StartScreen_MouseMove;
            Resize += StartScreen_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Registration;
        private Button Login;
        private Label label1;
        private Label label8;
    }
}