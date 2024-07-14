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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Navigate to Menu
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                //verify email
                staffTableAdapter.FillByEmails(g12Wst2024DataSet.Staff, textBox1.Text);
                if (g12Wst2024DataSet.Staff.Rows.Count > 0)
                {
                    //Make textbox green.

                }
                else
                {
                    MessageBox.Show("Enter a valid email!");
                }

                //verify password
                staffTableAdapter.FillByPasswords(g12Wst2024DataSet.Staff, textBox2.Text);
                if (g12Wst2024DataSet.Staff.Rows.Count > 0)
                {
                    //Make texbox green
                }
                else
                {
                    MessageBox.Show("Enter a valid password!");
                }

                //Login when entered details are valid
                staffTableAdapter.FillByDetails(g12Wst2024DataSet.Staff, textBox1.Text, textBox2.Text);
                if (g12Wst2024DataSet.Staff.Rows.Count > 0)
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                }
                

            }
            catch (Exception)
            {

                MessageBox.Show("404 error");
            }



        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Staff mystaff = new Staff();
            mystaff.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
