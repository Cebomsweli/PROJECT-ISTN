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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void FormSetup(Form myForm)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }


        private void cLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Navigate to the Client.
        private void cREATECLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
            //panel4.Visible = false;
            panel5.Visible = false;
            Client cli = new Client();
            FormSetup(cli);


            //this.Hide();
            //Client client = new Client();
            //client.Show();
        }

        //Navigate to the DJ page.
        private void cREATEDJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            //panel4.Visible = false;
            panel5.Visible = false;

            DJ cli = new DJ();
            FormSetup(cli);
            //this.Hide();
            //DJ dJ = new DJ();   
            //dJ.Show();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Booking book = new Booking();
            //book.Show();
        }

        //Update DJ Schedule
        private void uPDATESCHEDULEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            Schedule cli = new Schedule();
            FormSetup(cli);
            
        }

        //Write the review
        private void rEVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            Review cli = new Review();
            FormSetup(cli);
            //this.Hide();
            //Review review = new Review();
            //review.Show();
        }

        private void uPDATECLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
            //panel4.Visible = false;
            panel5.Visible = false;
            UpdateClient cli = new UpdateClient();
            FormSetup(cli);

            //this.Hide();
            //UpdateClient review = new UpdateClient();
            //review.Show();

        }

        private void uPDATEDJToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
            //panel4.Visible = false;
            panel5.Visible = false;
            UpdateDJ cli = new UpdateDJ();
            FormSetup(cli);
            //this.Hide();
            //UpdateDJ review = new UpdateDJ();
            //review.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void sTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aDDSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            Staff cli = new Staff();
            FormSetup(cli);
            //this.Hide(); ;k
            //Staff staff = new Staff();
            //staff.Show();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewAllDJSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewDJ dj = new ViewDJ();
            dj.Show();

        }

        private void vIEWALLCLIENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            ViewClients cli = new ViewClients();
            FormSetup(cli);


        }

        private void viewAllBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            viewbookings cli = new viewbookings();
            FormSetup(cli);
            //k
            //this.Hide();
            //viewbookings book = new viewbookings();
            //book.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
    }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dELETECLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            ArchiveClient cli = new ArchiveClient();
            FormSetup(cli);
        }

        private void vIEWARCHIVEDCLIENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            ArchiveClient cli = new ArchiveClient();
            FormSetup(cli);
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            ArchiveDJ dj = new ArchiveDJ();
            FormSetup(dj);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            Report cli = new Report();
            FormSetup(cli);
            //this.Hide();

            //Report report = new Report();
            //report.Show();
        }

        private void bARGRAPHSREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            BookingsReport cli = new BookingsReport();
            FormSetup(cli);
            //this.Hide();
            //BookingsReport rep = new BookingsReport();
            //rep.Show();
        }

        private void mAKEABOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //panel4.Visible = false;
            panel5.Visible = false;
            Booking cli = new Booking();
            FormSetup(cli);
        }
    }
}
