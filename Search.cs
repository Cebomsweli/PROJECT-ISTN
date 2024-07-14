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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist3dfDataSet1.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter.Fill(this.ist3dfDataSet1.Supplier);
            // TODO: This line of code loads data into the 'ist3dfDataSet.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.ist3dfDataSet.Staff);
            // TODO: This line of code loads data into the 'ist3dfDataSet.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter.Fill(this.ist3dfDataSet.Supplier);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //staffTableAdapter.SearchStaff(g12Wst2024DataSet.Staff,textBox1.Text);
            //dJTableAdapter.FillByStageName(ist3cxDataSet.DJ, textBox1.Text);
            //supplierTableAdapter.FillBy(ist3dfDataSet1.Supplier,textBox1.Text);
            //staffTableAdapter.FillByName(ist3dfDataSet.Staff,textBox1.Text);
        }
    }
}
