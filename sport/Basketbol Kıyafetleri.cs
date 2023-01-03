using System;
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
    public partial class Basketbol_Kıyafetleri : Form
    {
        Image image1;
        Image image2;
        Image image3;
        Image image4;
        Image image5;
        public Basketbol_Kıyafetleri()
        {
            InitializeComponent();
            image1 = Image.FromFile(@"..\..\imgs\pasketbol\lbas1.jpg");
            image2 = Image.FromFile(@"..\..\imgs\pasketbol\lbas4.jpg");
            image3 = Image.FromFile(@"..\..\imgs\pasketbol\lbas5.jpg");
            image4 = Image.FromFile(@"..\..\imgs\pasketbol\lbas8 copy.png");
            image5 = Image.FromFile(@"..\..\imgs\pasketbol\lbas3.jpg");
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

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
          
        }

        private void Basketbol_Kıyafetleri_Load(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image1);
            frm2.Show();
        }

        private void img2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image2);
            frm2.Show();
        }

        private void img3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image3);
            frm2.Show();
        }

        private void img4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image4);
            frm2.Show();
        }

        private void img5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image5);
            frm2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }
    }
}
