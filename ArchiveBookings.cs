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
    public partial class ArchiveBookings : Form
    {
        public ArchiveBookings()
        {
            InitializeComponent();
        }

        private void ArchiveBookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.g12Wst2024DataSet.Bookings);

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEmail.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookingsTableAdapter.DeleteBooking(txtEmail.Text, txtDate.Text);
            MessageBox.Show("Booking has been removed");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
