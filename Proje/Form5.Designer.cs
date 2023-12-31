namespace Proje
{
    partial class Form5
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
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(569, 343);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 2;
            label1.Text = "Toplam Fiyat";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(678, 343);
            label2.Name = "label2";
            label2.Size = new Size(91, 37);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(569, 34);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 4;
            label3.Text = "Bakiye";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 40);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 5;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(604, 400);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 6;
            button2.Text = "Ödeme Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(123, 297);
            button3.Name = "button3";
            button3.Size = new Size(85, 23);
            button3.TabIndex = 7;
            button3.Text = "Getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.Location = new Point(29, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(508, 231);
            dataGridView1.TabIndex = 8;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__11_;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.InfoText;
            Name = "Form5";
            Text = "Odeme Yeri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Button button2;
        private Button button3;
        public Label label4;
        public DataGridView dataGridView1;
    }
}