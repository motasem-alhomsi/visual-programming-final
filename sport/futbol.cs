﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sport
{
    public partial class futbol : Form
    {
        Image image1;
        Image image2;
        Image image3;
        Image image4;
        Image image5;
        Image image6;
        Image image7;
        Image image8;
        Image image9;
        public futbol()
        {
            InitializeComponent();
            image1 = Image.FromFile(@"..\..\imgs\3.png");
            image2 = Image.FromFile(@"..\..\imgs\2018.png");
            image3 = Image.FromFile(@"..\..\imgs\sssa.jpg");
            image6 = Image.FromFile(@"..\..\imgs\nikk.jpg");
            image5 = Image.FromFile(@"..\..\imgs\nik.jpg");
            image4 = Image.FromFile(@"..\..\imgs\mes.jpg");
            image9 = Image.FromFile(@"..\..\imgs\kff.jpg");
            image8 = Image.FromFile(@"..\..\imgs\kf.jpg");
            image7 = Image.FromFile(@"..\..\imgs\kk.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image1);
            frm4.Show();
        }

        private void futbol_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

            
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image2);
            frm4.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image3);
            frm4.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image6);
            frm3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image5);
            frm3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image4);
            frm3.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image9);
            frm2.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image8);
            frm2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image7);
            frm4.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Red;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Black;
        }
    }
}
