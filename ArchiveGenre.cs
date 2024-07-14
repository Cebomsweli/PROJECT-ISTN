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
    public partial class ArchiveGenre : Form
    {
        public ArchiveGenre()
        {
            InitializeComponent();
        }

        private void ArchiveGenre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.g12Wst2024DataSet.Genres);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            genresTableAdapter.FillByGenreName(g12Wst2024DataSet.Genres, txtName.Text);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //
        }
    }
}
