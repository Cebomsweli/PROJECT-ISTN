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
    public partial class ViewClients : Form
    {
        public ViewClients()
        {
            InitializeComponent();
        }

        private void ViewClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.g12Wst2024DataSet2.Clients);
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.Clients' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
