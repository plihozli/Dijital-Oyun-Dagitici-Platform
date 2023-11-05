using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void h_b_b_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fo4 = new Form4();
            fo4.ShowDialog();
        }

        private void b_e_b_Click(object sender, EventArgs e)
        {
            Form5 fo5 = new Form5();
            fo5.ShowDialog();
        }

        private void ö_b_b_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void F2_giris1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
        }

        private void F2_giris2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
        }
    }
}
