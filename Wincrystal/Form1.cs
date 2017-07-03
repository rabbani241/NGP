using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Wincrystal
{
    public partial class Form1 : Form
    {
        ReportDocument rd = new ReportDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=atmecs;Integrated Security=True");
            SqlDataAdapter dr = new SqlDataAdapter("select*from products", cn);
            DataSet st = new DataSet();
            dr.Fill(st,"products");
            rd.Load(@"C:\Users\shaik.rabbani\Desktop\Wincrystal\Wincrystal\CrystalReport.rpt");
            rd.SetDataSource(st);
            int a;
            crystalReportViewer1.ReportSource = rd;
        }
    }
}
