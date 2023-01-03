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
    public partial class hesabim : Form
    {
        public hesabim()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        MySqlDataAdapter ad = new MySqlDataAdapter();
        MySqlDataAdapter add = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtt = new DataTable();
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

        private void hesabim_Load(object sender, EventArgs e)
        {
            try
            {
                ad =new MySqlDataAdapter( "SELECT * FROM bilgi",con);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                add = new MySqlDataAdapter("SELECT * FROM odeme", con);
                add.Fill(dtt);
                dataGridView2.DataSource = dtt;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }
    }
}
