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
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        //Navigate to Menu page
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comment = textBox2.Text;
            string rateScaler = comboBox1.Text;
            //int dj_id = Convert.ToInt32(dJsTableAdapter.getDjID(comboBox2.Text));
            string client_id = clientsTableAdapter.getClientId(textBox1.Text).ToString();
            //reviewsTableAdapter.InsertReview(client_id, dj_id, comment, rateScaler);
        }

        private void Review_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.DJs' table. You can move, or remove it, as needed.
            this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);

            comboBox1.Items.Add("Very Dissatisfied");
            comboBox1.Items.Add("Dissatisfied");
            comboBox1.Items.Add("Neatral");
            comboBox1.Items.Add("Satisfied");
            comboBox1.Items.Add("Very Satisfied");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.dJsTableAdapter.FillByStageName(this.g12Wst2024DataSet.DJs ,textBox3.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string comment = textBox2.Text;
            string rateScaler = comboBox1.Text;
            //int dj_id = Convert.ToInt32(dJsTableAdapter.getDjID(comboBox2.Text));
            string client_id = clientsTableAdapter.getClientId(textBox1.Text).ToString();
            if(client_id == "")
            {
                MessageBox.Show("The Client does not exist");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to submit a review?","Confirm",
                    MessageBoxButtons.OKCancel);
                if (result==DialogResult.OK)
                {
                    MessageBox.Show("review submitted");
                    reviewsTableAdapter.InsertReview(client_id, (int)dataGridView1.CurrentRow.Cells[0].Value, comment, rateScaler);
                }
                else
                {
                    MessageBox.Show("review Cancelled");
                }
                
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }
    }
}
