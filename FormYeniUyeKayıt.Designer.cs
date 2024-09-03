namespace KutuphaneYonetim
{
    partial class FormYeniUyeKayıt
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
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(185, 261);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 13;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(185, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 34);
            textBox3.TabIndex = 12;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(40, 176);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 11;
            label3.Text = "Şifre (Tekrar):";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(185, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 34);
            textBox2.TabIndex = 10;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(40, 111);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 9;
            label2.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(185, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 34);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 7;
            label1.Text = "Kullanıcı Adı:";
            // 
            // FormYeniUyeKayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 378);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormYeniUyeKayıt";
            Text = "Yeni Üye Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}