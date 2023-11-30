namespace WinFormsApp1
{
    partial class Journal
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            Вес = new DataGridViewTextBoxColumn();
            Название = new DataGridViewTextBoxColumn();
            Оценка = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Вес, Название, Оценка });
            dataGridView1.Location = new Point(429, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 50);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Дата";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Тип Работы";
            Column2.Name = "Column2";
            // 
            // Вес
            // 
            Вес.HeaderText = "Вес";
            Вес.Name = "Вес";
            // 
            // Название
            // 
            Название.HeaderText = "Название";
            Название.Name = "Название";
            // 
            // Оценка
            // 
            Оценка.HeaderText = "Оценка";
            Оценка.Name = "Оценка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 90);
            label1.TabIndex = 1;
            label1.Text = "Журнал";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(316, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 90);
            label2.TabIndex = 2;
            label2.Text = "/";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(361, 9);
            label3.Name = "label3";
            label3.Size = new Size(260, 90);
            label3.TabIndex = 3;
            label3.Text = "Класс\r\n";
            label3.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(627, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(763, 9);
            label4.Name = "label4";
            label4.Size = new Size(56, 90);
            label4.TabIndex = 5;
            label4.Text = "/";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(816, 9);
            label5.Name = "label5";
            label5.Size = new Size(349, 90);
            label5.TabIndex = 6;
            label5.Text = "Предмет";
            label5.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1171, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 23);
            comboBox2.TabIndex = 7;
            comboBox2.Visible = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 582);
            button1.Name = "button1";
            button1.Size = new Size(236, 93);
            button1.TabIndex = 11;
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
            // Journal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1500, 700);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Journal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Journal";
            MouseDown += Journal_MouseDown;
            MouseMove += Journal_MouseMove;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewTextBoxColumn Вес;
        private DataGridViewTextBoxColumn Название;
        private DataGridViewTextBoxColumn Оценка;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private Button button1;
        private Label label8;
    }
}