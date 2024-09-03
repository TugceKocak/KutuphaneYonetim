namespace KutuphaneYonetim
{
    partial class FormYonetici
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button6 = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 322);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(140, 32);
            label9.Name = "label9";
            label9.Size = new Size(0, 28);
            label9.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(148, 259);
            button2.Name = "button2";
            button2.Size = new Size(117, 48);
            button2.TabIndex = 11;
            button2.Text = "Yeni Kitap Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 259);
            button1.Name = "button1";
            button1.Size = new Size(139, 48);
            button1.TabIndex = 10;
            button1.Text = "Kitap Bilgilerini Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(140, 193);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 34);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(140, 155);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 34);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(140, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(140, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(16, 189);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 4;
            label5.Text = "Kitap Türü :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(16, 151);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 3;
            label4.Text = "ISBN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "Yazar Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID :";
            // 
            // button6
            // 
            button6.Location = new Point(340, 352);
            button6.Name = "button6";
            button6.Size = new Size(117, 36);
            button6.TabIndex = 13;
            button6.Text = "Sorgula";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(24, 394);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(954, 169);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(948, 143);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(27, 354);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kitap Adı", "Yazar Adı", "Kitap Türü" });
            comboBox1.Location = new Point(172, 352);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 36);
            comboBox1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(475, 352);
            button3.Name = "button3";
            button3.Size = new Size(117, 36);
            button3.TabIndex = 17;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(610, 352);
            button4.Name = "button4";
            button4.Size = new Size(141, 36);
            button4.TabIndex = 18;
            button4.Text = "Kitapları Göster";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormYonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 677);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBox4);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Name = "FormYonetici";
            Text = "Form1";
            FormClosed += FormYonetici_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button6;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
    }
}