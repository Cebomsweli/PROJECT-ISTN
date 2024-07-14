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
    public partial class ArchiveClient : Form
    {

        int clientID = 0;
        string clientName = "";
        string clientSurname = "";
        string cellNumber = "";
        string emails = "";
        string compName = "";
        string houseNumber = "";
        string streetName = "";
        string city = "";
        string postCode = "";
        public ArchiveClient()
        {
            InitializeComponent();
        }

       
        private void ArchiveClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.g12Wst2024DataSet2.Clients);
            // TODO: This line of code loads data into the 'g12Wst2024DataSet3.ArchivedClients' table. You can move, or remove it, as needed.
            this.archivedClientsTableAdapter.Fill(this.g12Wst2024DataSet3.ArchivedClients);
            // TODO: This line of code loads data into the 'g12Wst2024DataSet2.Clients' table. You can move, or remove it, as needed.
            // this.clientsTableAdapter.Fill(this.g12Wst2024DataSet2.Clients);
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.Clients' table. You can move, or remove it, as needed.

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surnameTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            clientID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            clientName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            clientSurname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cellNumber = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            emails = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            compName = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            houseNumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            streetName = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            city = dataGridView1.CurrentRow.Cells[8].ToString();
            postCode = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientsTableAdapter.FillByClientname(g12Wst2024DataSet2.Clients, textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surnameTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            clientID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            clientName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            clientSurname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cellNumber = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            emails = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            compName = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            houseNumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            streetName = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            city = dataGridView1.CurrentRow.Cells[8].ToString();
            postCode = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clients details

            DialogResult result = MessageBox.Show("Do you want to archive the client", "Confirm",
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                clientsTableAdapter.DeleteClients(clientID);
                archivedClientsTableAdapter.insertClient(clientID, clientName, clientSurname, cellNumber, emails, compName, houseNumber, streetName, city, postCode);
                MessageBox.Show("The client has been archived successfully!");
                this.clientsTableAdapter.Fill(this.g12Wst2024DataSet2.Clients);
                this.archivedClientsTableAdapter.Fill(this.g12Wst2024DataSet3.ArchivedClients);
            }
        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surnameTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            clientID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            clientName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            clientSurname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cellNumber = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            emails = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            compName = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            houseNumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            streetName = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            city = dataGridView1.CurrentRow.Cells[8].ToString();
            postCode = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }
    }
}
