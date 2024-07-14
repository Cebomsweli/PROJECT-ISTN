using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BookingsReport : Form
    {
        public BookingsReport()
        {
            InitializeComponent();
        }

        private void BookingsReport_Load(object sender, EventArgs e)
        {
            clientsTA.Fill(ds1.Clients);
            bookingsTA.Fill(ds1.Bookings);
            dJsTA.Fill(ds1.DJs);
            bookingDjReport1.SetDataSource(ds1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookingDjReport1.SetParameterValue("Stage_name", textBox1.Text);
            crystalReportViewer1.ReportSource = bookingDjReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
