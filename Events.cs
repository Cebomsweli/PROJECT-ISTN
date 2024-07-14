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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string events = textBox1.Text;
            try
            {
                eventsTableAdapter.InsertEvent(events);
                MessageBox.Show("Successful");
            }
            catch (Exception)
            {

                MessageBox.Show("Failed");
            }
            
        }
    }
}
