using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sport
{
    public partial class satın_alma_sayfası_1 : Form
    {

        public satın_alma_sayfası_1(Image image , int adat , string size)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            label12.Text = adat.ToString();
            label13.Text = size;

        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void satın_alma_sayfası_1_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(20, 192, 192, 192);
            groupBox2.BackColor = Color.FromArgb(20, 192, 192, 192);
            groupBox2.BackColor = Color.FromArgb(20, 192, 192, 192);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
             textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Hata! Lütfen tüm bilgileri doldurunuz");
            }
            else
            {
                string str = "INSERT INTO bilgi values(@id,@adi,@soyadi,@email,@telefone,@adres,@adet,@size)";
                MySqlCommand cmd = new MySqlCommand(str,con);
                cmd.Parameters.AddWithValue("@id",textBox11.Text);
                cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@telefone", textBox10.Text);
                cmd.Parameters.AddWithValue("@adres", textBox4.Text);
                cmd.Parameters.AddWithValue("@adet", label12.Text);
                cmd.Parameters.AddWithValue("@size", label13.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                string st = "INSERT INTO odeme values(@id,@kartno,@ay,@cvv,@kartname,@not)";
                MySqlCommand cmdd = new MySqlCommand(st, con);
                cmdd.Parameters.AddWithValue("@id", textBox12.Text);
                cmdd.Parameters.AddWithValue("@kartno", textBox8.Text);
                cmdd.Parameters.AddWithValue("@ay", textBox7.Text);
                cmdd.Parameters.AddWithValue("@cvv", textBox5.Text);
                cmdd.Parameters.AddWithValue("@kartname", textBox6.Text);
                cmdd.Parameters.AddWithValue("@not", textBox9.Text);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Red;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Black;
        }
    }
}
