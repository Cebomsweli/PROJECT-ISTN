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
    public partial class Look : Form
    {
        public Look()
        {
            InitializeComponent();
        }

        private void Look_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist3cxDataSet1.Book' table. You can move, or remove it, as needed.
            //this.bookTableAdapter.Fill(this.ist3cxDataSet1.Book);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //bookTableAdapter.FillBy(ist3cxDataSet1.Book, textBox1.Text);
        }
    }
}
