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
    public partial class Search : Form
    {
        
      
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataSet;

        public Search()
        {
            InitializeComponent();
           
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=HotelDB;Integrated Security=True");
        private void SearchFoodItems(string searchKeyword)
        {
            try{
            string selectQuery = "SELECT Fname, Ftype, Fprice, Favailable FROM tblFood WHERE Fname LIKE @keyword";
            command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@keyword", "%" + searchKeyword + "%");

            adapter = new SqlDataAdapter(command);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "tblFood");

            dataGridView.DataSource = dataSet.Tables["tblFood"];
              }
            catch (Exception)
            {
                MessageBox.Show("no data");
            }
        }

        private void SearchBillingEntries(string searchKeyword)
        {
            try{
            string selectQuery = "SELECT BillNo, BillDate, Fid, Price, Quantity, Amount FROM tblBilling WHERE BillNo LIKE @keyword";
            command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@keyword", "%" + searchKeyword + "%");

            adapter = new SqlDataAdapter(command);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "tblBilling");

            dataGridView.DataSource = dataSet.Tables["tblBilling"];
              }
            catch (Exception)
            {
                MessageBox.Show("no data");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }
    
        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void rs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioFoodItems_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
             Home h = new Home();
            h.Show();
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearchKeyword.Text.Trim();

            if (radioFoodItems.Checked)
            {
                SearchFoodItems(searchKeyword);
            }
            else if (radioBillingEntries.Checked)
            {
                SearchBillingEntries(searchKeyword);
            }
        }
    }
}
