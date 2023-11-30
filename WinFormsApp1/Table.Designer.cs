namespace WinFormsApp1
{
    partial class Table
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label8 = new Label();
            Search = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(478, 90);
            label1.TabIndex = 0;
            label1.Text = "Расписание";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 223);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(126, 305);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 23);
            comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(126, 402);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(167, 23);
            comboBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 198);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 6;
            label2.Text = "Класс";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(126, 280);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 7;
            label3.Text = "Кабинет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(126, 377);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 8;
            label4.Text = "Учитель\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(703, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 48);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "№";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Урок";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Кабинет";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Учитель";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Время";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(57, 879);
            button1.Name = "button1";
            button1.Size = new Size(236, 93);
            button1.TabIndex = 10;
            button1.Text = "Вернуться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1467, -1);
            label8.Name = "label8";
            label8.Size = new Size(34, 34);
            label8.TabIndex = 29;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // Search
            // 
            Search.FlatStyle = FlatStyle.Flat;
            Search.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Search.Location = new Point(126, 453);
            Search.Name = "Search";
            Search.Size = new Size(102, 44);
            Search.TabIndex = 30;
            Search.Text = "Поиск";
            Search.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._211817_search_strong_icon;
            pictureBox1.Location = new Point(234, 453);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1196, 879);
            button2.Name = "button2";
            button2.Size = new Size(251, 109);
            button2.TabIndex = 32;
            button2.Text = "Изменить расписание";
            button2.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1500, 1000);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(Search);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Table";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Table";
            Load += Table_Load;
            MouseDown += Table_MouseDown;
            MouseMove += Table_MouseMove;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
        private Label label8;
        private Button Search;
        private PictureBox pictureBox1;
        private Button button2;
    }
}