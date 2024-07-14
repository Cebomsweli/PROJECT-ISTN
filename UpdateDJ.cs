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
    public partial class UpdateDJ : Form
    {
        public UpdateDJ()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDJ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.DJs' table. You can move, or remove it, as needed.
            this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);

        }


        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            dJsTableAdapter.FillByStageName(this.g12Wst2024DataSet.DJs, textBox7.Text);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to Confirm ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    dJsTableAdapter.Updatedj(textBox1.Text,
                     textBox2.Text,
                     textBox3.Text,
                     textBox4.Text,
                     textBox5.Text, textBox6.Text,
                     (int)dataGridView1.CurrentRow.Cells[0].Value);
                    this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);

                }
                else
                {
                    MessageBox.Show("Update Cancelled!!");
                }

            }
            catch (Exception ex)
            {


            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            dJsTableAdapter.FillByStageName(this.g12Wst2024DataSet.DJs, textBox9.Text);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox8.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            localindoor.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            LoutDoorR.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            IindoorR.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            IoutdoorR.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
           
               dJsTableAdapter.UpdateRate(Convert.ToDecimal(localindoor.Text),
                Convert.ToDecimal(LoutDoorR.Text),
                Convert.ToDecimal(IindoorR.Text),
                   Convert.ToDecimal(IoutdoorR.Text),
                 (int)dataGridView2.CurrentRow.Cells[0].Value);

            this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            localindoor.Text = "";
            LoutDoorR.Text = "";
            IindoorR.Text = "";
            IoutdoorR.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            insta.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            fbck.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            xacc.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            insta.Text = "";
            fbck.Text = "";
            xacc.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}