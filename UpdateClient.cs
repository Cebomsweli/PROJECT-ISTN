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
    public partial class UpdateClient : Form
    {
        Class1 verify = new Class1();
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.g12Wst2024DataSet2.Clients);
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.Clients' table. You can move, or remove it, as needed.

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.clientsTableAdapter.FillByClientname(this.g12Wst2024DataSet2.Clients , textBox1.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CellNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            compName.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to Confirm ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
               
                    clientsTableAdapter.UpdateQuery(name.Text, Surname.Text, CellNumber.Text, Email.Text, compName.Text
               ,address.Text, textBox2.Text, textBox3.Text, textBox4.Text, (int)dataGridView1.CurrentRow.Cells[0].Value);
                    this.clientsTableAdapter.Fill(this.g12Wst2024DataSet2.Clients);
                    MessageBox.Show("Updated ");         

            }
            else
            {
                MessageBox.Show("Update Cancelled!!");
            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            name.Text = "";
            Surname.Text = "";
            CellNumber.Text = "";
            Email.Text = "";
            compName.Text = "";
            address.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}
