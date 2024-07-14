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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.Reviews' table. You can move, or remove it, as needed.
            this.reviewsTableAdapter.Fill(this.g12Wst2024DataSet.Reviews);
            // TODO: This line of code loads data into the 'g12Report.DJs1' table. You can move, or remove it, as needed.
            this.dJs1TableAdapter.Fill(this.g12Report.DJs1);
            // TODO: This line of code loads data into the 'g12Report.DJs' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'g12Report.DJs1' table. You can move, or remove it, as needed.
            this.dJs1TableAdapter.Fill(this.g12Report.DJs1);
            // TODO: This line of code loads data into the 'g12Report1.DJs1' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'g12Report.DJs1' table. You can move, or remove it, as needed.
            this.dJs1TableAdapter.Fill(this.g12Report.DJs1);
            // TODO: This line of code loads data into the 'g12Report.DJs' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'g12Report.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.g12Report.Bookings);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //this.bookingsTableAdapter.FillBydate(this.g12Report.Bookings,
            //    dateTimePicker1.Value.Date.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bookingsTableAdapter.FillByrange(this.g12Report.Bookings,
                dateTimePicker1.Value.Date.ToString()
                ,dateTimePicker2.Value.Date.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }
    }
}
