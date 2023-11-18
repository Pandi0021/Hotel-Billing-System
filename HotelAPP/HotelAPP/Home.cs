using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HotelAPP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food_New_Entry f = new Food_New_Entry();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
            this.Hide();
        }
    }
}
