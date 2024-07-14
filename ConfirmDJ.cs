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
    public partial class ConfirmDJ : Form
    {
        
        
        public ConfirmDJ()
        {
            InitializeComponent();

            //Adding data from dj's forms to the confirm form
            label16.Text = DJ.name;
            label18.Text = DJ.Surname;
            label19.Text = DJ.stageName;
            label20.Text = DJ.SAID;
            label21.Text = DJ.email;
            label22.Text = DJ.telNo;
            label30.Text = DJ.Photo;

            label23.Text = "R" + DJ2.lclIndoor;
            label24.Text = "R" + DJ2.lclOutdoor;
            label25.Text = "R" + DJ2.IntrnlIndoor;
            label26.Text = "R" + DJ2.IntrnlOutdoor;
            label27.Text = DJ2.instHandle;
            label28.Text = DJ2.fcbkHandle;
            label29.Text = DJ2.xaccountHandle;

            //label19.Text=stag
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        //Adding Dj to the database
        private void button1_Click(object sender, EventArgs e)
        {
            //Data
            string name = label16.Text;
            string surname = label18.Text;
            string stage_name = label19.Text;
            string id = label20.Text;
            string email = label21.Text;
            string telnumber = label22.Text;
            decimal lclind = Convert.ToDecimal(DJ2.lclIndoor);
            decimal lcllout = Convert.ToDecimal(DJ2.lclOutdoor);
            decimal IntrnlIn = Convert.ToDecimal(DJ2.IntrnlIndoor);
            decimal IntrnOut = Convert.ToDecimal(DJ2.IntrnlOutdoor);
            string insta = label27.Text;
            string fcbk = label28.Text;
            string xaccount = label29.Text;
            string photo = label30.Text;
            
            string status = "verified";

            try
            {

               

               
                dJsTableAdapter.InsertDj(name, surname, stage_name, id, email,
                    telnumber, lclind, lcllout, IntrnlIn, IntrnOut, insta, fcbk, 
                    xaccount, photo, status);

                MessageBox.Show("DJ added");
            }
            catch (Exception)
            {

                MessageBox.Show("Failed adding Dj");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DJ2 dj = new DJ2();
            dj.Show();
        }
    }
}
