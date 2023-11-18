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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
      
        private Random random = new Random();
         SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HotelDB;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            try{
            decimal p = Convert.ToDecimal(fp.Text);
            int qq = int.Parse(q.Text);
            decimal aa= qq * p;
            a.Text = aa+"";

            int billNo = Convert.ToInt32(bn.Text);
            string selectedFood = f.SelectedItem.ToString();
            int quantity = Convert.ToInt32(q.Text);
            decimal amount = Convert.ToDecimal(a.Text);

            string insertQuery = "INSERT INTO tblBilling (BillNo, Fid, Price, Quantity, Amount) " +
                "SELECT @BillNo, Fid, @Price, @Quantity, @Amount FROM tblFood WHERE Fname = @Fname";
            
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            command.Parameters.AddWithValue("@BillNo", billNo);
            command.Parameters.AddWithValue("@Fname", selectedFood);
            command.Parameters.AddWithValue("@Price", fp.Text);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@Amount", amount);

            int r=command.ExecuteNonQuery();
            MessageBox.Show((r != 0) ? " Data Saved..." : "data not saved");
            connection.Close();
            dis();
              }
            catch (Exception)
            {
                MessageBox.Show("no data");
            }
        }
        private void PopulateFoodComboBox()
        {
            try{
            string selectQuery = "SELECT Fname FROM tblFood ORDER BY Fname ASC";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                f.Items.Add(reader["Fname"].ToString());
            }
            reader.Close();
            connection.Close();
              }
            catch (Exception)
            {
                MessageBox.Show("no data");
            }
        }
        private void GenerateBillNo()
        {
            int billNo = random.Next(1000, 10000);
            bn.Text = billNo.ToString();
        }

        private void f_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            string selectedFood = f.SelectedItem.ToString();
            string selectQuery = "SELECT Fprice FROM tblFood WHERE Fname = @Fname";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@Fname", selectedFood);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                decimal foodPrice = Convert.ToDecimal(reader["Fprice"]);
                fp.Text = foodPrice.ToString();
            }
            reader.Close();
            
                string selectQuery2 = "SELECT * FROM tblBilling";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery2, connection);
                DataSet1 dataSet = new DataSet1();
                adapter.Fill(dataSet, "tblBilling");
                rs.DataSource = dataSet.Tables["tblBilling"];
                connection.Close();
              }
            catch (Exception)
            {
                MessageBox.Show("no data");
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            dis();
            PopulateFoodComboBox();
            GenerateBillNo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int SNo = Convert.ToInt32(rs.SelectedRows[0].Cells["SNo"].Value);
                Report r = new Report(SNo);
                r.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("no data");
            }
            this.Hide();
        }
        public void dis()
        {
            try
            {
                connection.Open();
                string selectQuery2 = "SELECT * FROM tblBilling";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery2, connection);
                DataSet1 dataSet = new DataSet1();
                adapter.Fill(dataSet, "tblBilling");
                rs.DataSource = dataSet.Tables["tblBilling"];
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("no data");
            }
          
        }
        public void select()
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
