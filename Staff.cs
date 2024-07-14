using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Staff : Form
    {
        Class1 verify = new Class1();
        public Staff()
        {
            InitializeComponent();
        }

        

        //Adding to Staff Table
        private void button2_Click(object sender, EventArgs e)
        {
            string Name = Client_name.Text;
            string Surname = surname.Text;
            string cellNumber = phone_number.Text;
            string passWord = password.Text;
            string email = client_email.Text;
            string Role = role.Text;

            try
            {
                DialogResult result = MessageBox.Show("Do you want to create an account?", "Confirm",
                MessageBoxButtons.YesNoCancel);

                if (!verify.IsValidPhoneNumber(phone_number.Text))
                {
                    MessageBox.Show("Please enter Correct cellphone number format.");
                    phone_number.BackColor = Color.Red;

                }

                    //validate email
                    if (!verify.CheckPasswordMatch(password.Text, confirm.Text))
                {
                    MessageBox.Show("Please enter a matching password!");
                    confirm.BackColor = Color.Red;

                }
                if (!verify.IsStrongPassword(password.Text))
                {
                    MessageBox.Show("Please enter a Strong password!");
                    password.BackColor = Color.Red;

                }

                //validate email
                if (!verify.ValidateEmail(email))
                {
                    MessageBox.Show("Please enter a valid email!");
                    client_email.BackColor = Color.Red;

                }
                if (!verify.IsValidName(Client_name.Text))
                {
                    MessageBox.Show("Please enter a valid Name");
                    Client_name.BackColor = Color.Red;
                }
                if (!verify.IsValidName(surname.Text))
                {
                    MessageBox.Show("Please enter a valid Name");
                    surname.BackColor = Color.Red;

                }


                if (result==DialogResult.Yes && verify.ValidateEmail(email) && 
                    verify.CheckPasswordMatch(password.Text, confirm.Text) &&
                    verify.IsStrongPassword(password.Text) &&
                    verify.IsValidPhoneNumber(phone_number.Text) && 
                    verify.IsValidName(Client_name.Text) &&
                    verify.IsValidName(surname.Text))
                {
                    staffTableAdapter.InsertStaff(Name, Surname, cellNumber, Role, email, passWord);
                    MessageBox.Show("The staff has been added successfully");
                    
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("An error has occured):");
            }
            
            
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu =new Menu();
            menu.Show();
        }

        private void Client_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            role.Items.Add("Manager");
            role.Items.Add("Clerk");    

        }
    }
}
