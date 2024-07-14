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
    public partial class Genre : Form
    {
        public Genre()
        {
            InitializeComponent();
        }

        private void Genre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.DJs' table. You can move, or remove it, as needed.
            this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);
            // TODO: This line of code loads data into the 'ist3cxDataSet.DJ' table. You can move, or remove it, as needed.
            //this.dJTableAdapter.Fill(this.ist3cxDataSet.DJ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dJsTableAdapter.getDjID(comboBox1.Text));
            genresTableAdapter.InsertGenre(id, textBox1.Text);
        }
    }
}
