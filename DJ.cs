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
    public partial class DJ : Form
    {
        //public variables for storing DJ data
         public static string name = "";
         public static string Surname = "";
         public static string stageName = "";
         public static string SAID = "";
         public static string email = "";
         public static string telNo = "";
         public static string Photo = "";
         Class1 verify = new Class1();

        public DJ()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DJ2 dj = new DJ2();
            dj.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DJ_Load(object sender, EventArgs e)
        {
            
        }

        

        //Retrieving the images from the file explorer.
        private void button4_Click(object sender, EventArgs e)
        {
            //Opens the file in files system.
            openFileDialog1.Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                txtImg.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(txtImg.Text);
            }

        }

        //
        private void button2_Click(object sender, EventArgs e)
        {

            if (!(verify.IsValidName(textBox1.Text)))
            {
                MessageBox.Show("please Enter valid name ");
                textBox1.BackColor = Color.Red;
            }
            if (!verify.IsValidIDNumber(textBox4.Text))
            {
                MessageBox.Show("please Enter valid ID number ");
                textBox4.BackColor = Color.Red;
            }
            if (!verify.IsValidPhoneNumber(textBox6.Text))
            {
                MessageBox.Show("please Enter valid Phone number contaning Digits ");
                textBox6.BackColor = Color.Red;

            }
            
            if (!verify.IsValidName(textBox2.Text))
            {
                MessageBox.Show("please Enter valid Surname ");
                textBox2.BackColor = Color.Red;

            }
            if (!verify.ValidateEmail(textBox5.Text))
            {
                MessageBox.Show("please Enter valid Email ");
                textBox5.BackColor = Color.Red;

            }
            if(verify.IsValidName(textBox1.Text) && verify.IsValidName(textBox2.Text) &&
                verify.IsValidIDNumber(textBox4.Text) && verify.IsValidPhoneNumber(textBox6.Text) &&
                verify.ValidateEmail(textBox5.Text))
            {
                //Adding data from texboxes
                name = textBox1.Text;
                Surname = textBox2.Text;
                stageName = textBox3.Text;
                SAID = textBox4.Text;
                email = textBox5.Text;
                telNo = textBox6.Text;
                Photo = txtImg.Text;

                this.Hide();
                DJ2 dj = new DJ2();
                dj.Show();

            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
