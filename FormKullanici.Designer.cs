namespace KutuphaneYonetim
{
    partial class FormKullanici
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
            button3 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button6 = new Button();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(41, 315);
            button3.Name = "button3";
            button3.Size = new Size(141, 36);
            button3.TabIndex = 37;
            button3.Text = "İade Et";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(492, 20);
            button4.Name = "button4";
            button4.Size = new Size(117, 36);
            button4.TabIndex = 36;
            button4.Text = "Ödünç Al";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(202, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 66);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gecikme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(67, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 26;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(319, 21);
            button2.Name = "button2";
            button2.Size = new Size(117, 35);
            button2.TabIndex = 25;
            button2.Text = "Ödeme Yap";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(624, 20);
            button1.Name = "button1";
            button1.Size = new Size(141, 36);
            button1.TabIndex = 34;
            button1.Text = "Kitapları Göster";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kitap Adı", "Yazar Adı", "Kitap Türü" });
            comboBox1.Location = new Point(186, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 36);
            comboBox1.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(41, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 32;
            // 
            // button6
            // 
            button6.Location = new Point(354, 20);
            button6.Name = "button6";
            button6.Size = new Size(117, 36);
            button6.TabIndex = 31;
            button6.Text = "Sorgula";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(27, 357);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1015, 215);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödünç Kitap Listesi";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1009, 189);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(27, 74);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1018, 215);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitaplık";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1012, 189);
            dataGridView1.TabIndex = 0;
            // 
            // FormKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 593);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Name = "FormKullanici";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button6;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}