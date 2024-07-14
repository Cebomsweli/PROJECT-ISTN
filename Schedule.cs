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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.DJs' table. You can move, or remove it, as needed.
            this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);
            // TODO: This line of code loads data into the 'ist3cxDataSet.DJ' table. You can move, or remove it, as needed.
            //this.dJTableAdapter.Fill(this.ist3cxDataSet.DJ);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(dJsTableAdapter.getDjID(comboBox1.Text));
            string note=textBox1.Text;
            string startDate = dateTimePicker1.Text;
            string endDate = dateTimePicker2.Text;

            //schedulesTableAdapter.InsertSchedule(id, startDate, endDate,note);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dJsTableAdapter.FillByStageName(g12Wst2024DataSet.DJs, textBox2.Text);
        }
    }
}
