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
    public partial class DJ2 : Form
    {
        Class1 verify = new Class1();

        //Public variables to variables
        public static string lclIndoor = "";
        public static string lclOutdoor = "";
        public static string IntrnlIndoor = "";
        public static string IntrnlOutdoor = "";
        public static string instHandle = "";
        public static string fcbkHandle = "";
        public static string xaccountHandle = "";
        public static string status = "";

        public DJ2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DJ dj = new DJ();
            dj.Show();
        }

        //Go to confirm details
        private void button1_Click(object sender, EventArgs e)
        {
            //Verifying if it's money or not
            if (!verify.isMoney(LindoorRate.Text))
            {
                MessageBox.Show("Please enter digits only!");
                LindoorRate.BackColor = Color.Red;
            }

            if (!verify.isMoney(LoutDoorR.Text))
            {
                MessageBox.Show("Please enter digits only!");
                LoutDoorR.BackColor = Color.Red;
            }

            if (!verify.isMoney(IindoorR.Text))
            {
                MessageBox.Show("Please enter digits only!");
                IindoorR.BackColor = Color.Red;
            }


            if (!verify.isMoney(IoutdoorR.Text))
            {
                MessageBox.Show("Please enter digits only!");
                IoutdoorR.BackColor = Color.Red;
            }

            //adding datsa to public variables
            lclIndoor = LindoorRate.Text;
            lclOutdoor = LoutDoorR.Text;
            IntrnlIndoor = IindoorR.Text;
            IntrnlOutdoor = IoutdoorR.Text;
            instHandle =insta.Text;
            fcbkHandle =fbck.Text;
            xaccountHandle = insta.Text;
            status = "";

            if (verify.isMoney(IoutdoorR.Text))
            {
                this.Hide();
                ConfirmDJ confirm = new ConfirmDJ();
                confirm.Show();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
