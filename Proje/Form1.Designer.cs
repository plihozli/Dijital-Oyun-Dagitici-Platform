namespace Proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            label7 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(605, 34);
            button2.Name = "button2";
            button2.Size = new Size(153, 133);
            button2.TabIndex = 1;
            button2.Text = "KullanIcI Girisi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(605, 227);
            button3.Name = "button3";
            button3.Size = new Size(153, 133);
            button3.TabIndex = 2;
            button3.Text = "Kayit Olma Paneli";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.images__11_;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 365);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(185, 248);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 13;
            label2.Text = "TelefonNO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.IndianRed;
            label10.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(158, 205);
            label10.Name = "label10";
            label10.Size = new Size(116, 18);
            label10.TabIndex = 12;
            label10.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(307, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(218, 283);
            button4.Name = "button4";
            button4.Size = new Size(138, 57);
            button4.TabIndex = 10;
            button4.Text = "Kayıt Ol";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(307, 76);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(307, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.IndianRed;
            label5.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(95, 167);
            label5.Name = "label5";
            label5.Size = new Size(179, 18);
            label5.TabIndex = 4;
            label5.Text = "E-postanızı giriniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(158, 124);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 3;
            label4.Text = "Sifre Tekrar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(104, 81);
            label3.Name = "label3";
            label3.Size = new Size(170, 18);
            label3.TabIndex = 2;
            label3.Text = "Sifre Belirleyiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(242, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı Belirleyiniz";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox6);
            panel2.Location = new Point(27, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 365);
            panel2.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkRed;
            button5.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(183, 185);
            button5.Name = "button5";
            button5.Size = new Size(151, 70);
            button5.TabIndex = 4;
            button5.Text = "GİRİŞ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Yellow;
            label7.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(72, 116);
            label7.Name = "label7";
            label7.Size = new Size(53, 18);
            label7.TabIndex = 3;
            label7.Text = "Sifre";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(188, 106);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(146, 23);
            textBox7.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Khaki;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 70);
            label6.Name = "label6";
            label6.Size = new Size(125, 18);
            label6.TabIndex = 1;
            label6.Text = "Kullanıcı Adı";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(188, 69);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(146, 23);
            textBox6.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(791, 423);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Kullanici Giris Ve Kayit";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Panel panel2;
        private Label label6;
        private TextBox textBox6;
        private Button button5;
        private Label label7;
        private TextBox textBox7;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label2;
    }
}