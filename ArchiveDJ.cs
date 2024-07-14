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
    public partial class ArchiveDJ : Form
    {
        public ArchiveDJ()
        {
            InitializeComponent();
        }

        private void ArchiveDJ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.ArchiveDJ' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.DJs' table. You can move, or remove it, as needed.
            this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dJsTableAdapter.FillByStageName(g12Wst2024DataSet.DJs,textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Method to Select the DJ to archive method
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            stageName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Delete selected DJ
            dJsTableAdapter.DeleteDj(stageName.Text);
        }
    }
}
