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
    public partial class Form4 : Form
    {
        Image image;
        int adat;
        string size;
        public Form4(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adat = Convert.ToInt32(numericUpDown1.Value);
            satın_alma_sayfası_1 ast1 = new satın_alma_sayfası_1 (image, adat , size);
            ast1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
    }
}
