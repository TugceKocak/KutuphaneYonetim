namespace KutuphaneYonetim
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(258, 248);
            button1.Name = "button1";
            button1.Size = new Size(205, 54);
            button1.TabIndex = 0;
            button1.Text = "Kullanıcı Girişi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(67, 90);
            label1.Name = "label1";
            label1.Size = new Size(152, 31);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(67, 155);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(67, 339);
            label3.Name = "label3";
            label3.Size = new Size(0, 31);
            label3.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(345, 12);
            button2.Name = "button2";
            button2.Size = new Size(131, 42);
            button2.TabIndex = 6;
            button2.Text = "Kayıt Ol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(32, 248);
            button3.Name = "button3";
            button3.Size = new Size(205, 54);
            button3.TabIndex = 7;
            button3.Text = "Yönetici Girişi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(488, 394);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGiris";
            Text = "Kutuphane Yönetim Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}
