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
    public partial class Client : Form
    {
        Class1 verify = new Class1();
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Adding the client details to the Client table.
        private void button2_Click(object sender, EventArgs e)
        {
            //verify input.


            //Data from user
            string Name = this.name.Text;
            string surname = Surname.Text;
            string cellphoneNumber = CellNumber.Text;
            string email = Email.Text;
            string company = compName.Text;
            string houseNumber = txtHNo.Text;
            string StreetName = txtStrN.Text;
            string city = txtCity.Text;
            string postacCode = txtPC.Text;

            try
            {


                if (!verify.IsValidName(name.Text))
                {
                    MessageBox.Show("Please enter a valid name!");
                    name.BackColor = Color.Red;
                }

                if (!verify.ValidateEmail(Email.Text))
                {
                    MessageBox.Show("Please a correct email!");
                    Email.BackColor = Color.Red;
                }

                if (!verify.IsValidPhoneNumber(CellNumber.Text))
                {
                    MessageBox.Show("Please enter a valid cell phone number!");
                    CellNumber.BackColor = Color.Red;
                }

                if (!verify.IsValidName(Surname.Text))
                {
                    MessageBox.Show("Make sure that the surname is entered correctly! ");
                    Surname.BackColor = Color.Red;
                }

                DialogResult result = MessageBox.Show("Do you want to add client?", "Confirm",
                MessageBoxButtons.YesNoCancel);
                
                if (result==DialogResult.Yes && verify.IsValidName(name.Text) &&
                    verify.ValidateEmail(Email.Text) &&
                    verify.IsValidPhoneNumber(CellNumber.Text) &&
                    verify.IsValidName(Surname.Text)
                    )
                {
                  
                    clientsTableAdapter.InsertClients(Name, surname, cellphoneNumber, email, company, houseNumber, StreetName, city, postacCode);
                    MessageBox.Show("Client has been added successfully");

                    
                }
                   
            }
            catch (Exception)
            {

                MessageBox.Show("An error occur");
            }
            
            
         
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
