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
    public partial class Food_New_Entry : Form
       
    {
         
        public Food_New_Entry()
        {
            InitializeComponent();
        }
        char ftt;
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HotelDB;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Food_New_Entry_Load(object sender, EventArgs e)
        {
            ViewFoodItems();
        }
        private void ViewFoodItems()
        {
            try
            {
                string selectQuery = "SELECT Fid, Fname, Ftype, Fprice, Favailable FROM tblFood";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataSet1 dataSet = new DataSet1();
                adapter.Fill(dataSet, "tblFood");
                rs.DataSource = dataSet.Tables["tblFood"];
            }
            catch (Exception)
            {
                 MessageBox.Show("No item");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ifn = fn.Text;
                char ift = ftt;
                double ifp = double.Parse(fp.Text);
                string ifa = fa.Text;
                SqlCommand cmd = new SqlCommand("insert into tblFood (Fname,Ftype,Fprice,Favailable) values ('" + ifn + "','" + ift + "'," + ifp + ",'" + ifa + "')", con);
                con.Open();
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show((r != 0) ? " Data Saved..." : "data not saved");
                con.Close();
                ViewFoodItems();
            }
            catch (Exception)
            {
                 MessageBox.Show("Not Add new item");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int fid = Convert.ToInt32(rs.SelectedRows[0].Cells["Fid"].Value);
                SqlCommand cmd = new SqlCommand("delete from tblFood where fid='" + fid + "'", con);
                con.Open();
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show((r != 0) ? " Data deleted..." : "invalid food ID");
                con.Close();
                ViewFoodItems();
            }
            catch (Exception)
            {
                 MessageBox.Show("select item");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try{
            int fid = Convert.ToInt32(rs.SelectedRows[0].Cells["Fid"].Value);
            string fname = fn.Text;
            char ftype = ftt;
            decimal fprice = Convert.ToDecimal(fp.Text);
            string favailability = fa.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE tblFood SET Fname = @Fname, Ftype = @Ftype, Fprice = @Fprice, Favailable = @Favailable WHERE Fid = @Fid", con);
            cmd.Parameters.AddWithValue("@Fname", fname);
            cmd.Parameters.AddWithValue("@Ftype", ftype);
            cmd.Parameters.AddWithValue("@Fprice", fprice);
            cmd.Parameters.AddWithValue("@Favailable", favailability);
            cmd.Parameters.AddWithValue("@Fid", fid);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show((r != 0) ? " Data updated..." : "invalid");
            con.Close();
            ViewFoodItems();
             }
            catch (Exception)
            {
                 MessageBox.Show("select item");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            int fid = Convert.ToInt32(rs.SelectedRows[0].Cells["Fid"].Value);
            string selectQuery = "SELECT Fname, Ftype, Fprice, Favailable FROM tblFood WHERE Fid = @Fid";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@Fid", fid);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                fn.Text = reader["Fname"].ToString();
                ft.Text = reader["Ftype"].ToString();
                fp.Text = reader["Fprice"].ToString();
                fa.SelectedItem = reader["Favailable"].ToString();
            }
            reader.Close();
            con.Close();
            ViewFoodItems();
            }
            catch (Exception)
            {
                MessageBox.Show("select item");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            ViewFoodItems();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ftt='V';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ftt='N';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        
    }

}
