namespace WinFormsApp1
{
    partial class VerifyUsers
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
            verifyUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button3 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)verifyUser).BeginInit();
            SuspendLayout();
            // 
            // verifyUser
            // 
            verifyUser.BackgroundColor = SystemColors.ControlDarkDark;
            verifyUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            verifyUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            verifyUser.Location = new Point(60, 128);
            verifyUser.Name = "verifyUser";
            verifyUser.RowTemplate.Height = 25;
            verifyUser.Size = new Size(640, 161);
            verifyUser.TabIndex = 0;
            verifyUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Фамилия";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Имя";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Отчество";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Статус";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Дата Рождения";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "";
            Column6.Name = "Column6";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(600, 165);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 1;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 526);
            button3.Name = "button3";
            button3.Size = new Size(117, 62);
            button3.TabIndex = 54;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(768, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 34);
            label8.TabIndex = 55;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // VerifyUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 244);
            ClientSize = new Size(800, 600);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(verifyUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerifyUsers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VerifyUsers";
            Load += VerifyUsers_Load;
            ((System.ComponentModel.ISupportInitialize)verifyUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView verifyUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button1;
        private Button button3;
        private Label label8;
    }
}