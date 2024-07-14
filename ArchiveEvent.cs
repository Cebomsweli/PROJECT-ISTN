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
    public partial class ArchiveEvent : Form
    {
        public ArchiveEvent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ArchiveEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.g12Wst2024DataSet.Events);

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEvtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            eventsTableAdapter.FillByEvent(g12Wst2024DataSet.Events,txtEvtName.Text);
        }
    }
}
