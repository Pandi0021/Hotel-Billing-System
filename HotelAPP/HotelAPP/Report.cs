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
using Microsoft.Reporting.WinForms;

namespace HotelAPP
{
    public partial class Report : Form
    {
        int Sno;
        public Report(int value)
        {
            InitializeComponent();
            Sno= value;
        }

        
         SqlConnection con = new SqlConnection
        (@"Data Source=(localdb)\v11.0;Initial Catalog=HotelDB;Integrated Security=True");
        private void Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try {
            SqlCommand cmd = new SqlCommand("SELECT tblBilling.BillNo,tblBilling.BillDate,tblBilling.Price,tblBilling.Quantity,tblBilling.Amount,tblFood.Fname FROM tblBilling INNER JOIN tblFood ON tblBilling.Fid = tblFood.Fid where SNo="+Sno, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable d = new DataTable("DataTable1");
            sd.Fill(d);
            ReportDataSource rd = new ReportDataSource("DataSet1", d);
            reportViewer1.LocalReport.ReportPath = "E:\\pandi\\.net\\Project new\\HotelAPP\\HotelAPP\\Report.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rd);
            reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                MessageBox.Show("Select item");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
            b.Show();
            this.Hide();
        }
    }
}
