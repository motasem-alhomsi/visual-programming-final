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
    public partial class Buz_Hokeyi : Form
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
        public Buz_Hokeyi()
        {
            InitializeComponent();
            image1 = Image.FromFile(@"..\..\imgs\hokey\hok9.png");
            image2 = Image.FromFile(@"..\..\imgs\hokey\hok10.png");
            image3 = Image.FromFile(@"..\..\imgs\hokey\hok11.jpg");
            image4 = Image.FromFile(@"..\..\imgs\hokey\hok1.jpg");
            image5 = Image.FromFile(@"..\..\imgs\hokey\hok2.jpg");
            image6 = Image.FromFile(@"..\..\imgs\hokey\hok6.jpg");
            image7 = Image.FromFile(@"..\..\imgs\hokey\hok5.png");
            image8 = Image.FromFile(@"..\..\imgs\hokey\hok3.png");
            image9 = Image.FromFile(@"..\..\imgs\hokey\hok4 copy.png");
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            
        }

        private void Buz_Hokeyi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image2);
            frm2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image4);
            frm3.Show();
        }

        private void img1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image1);
            frm2.Show();
        }

        private void img3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image3);
            frm2.Show();
        }

        private void img5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image5);
            frm3.Show();
        }

        private void img6_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image6);
            frm4.Show();
        }

        private void img7_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image7);
            frm4.Show();
        }

        private void img8_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image8);
            frm4.Show();
        }

        private void img9_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image9);
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
