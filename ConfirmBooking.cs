using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class ConfirmBooking : Form
    {

        //Accessing the data from the Booking form
        int clientId = 0;
        int event_id = 0;
        int dj_id = 0;
        decimal totCost = 0;
        public ConfirmBooking()
        {
            InitializeComponent();


            clientId = Convert.ToInt32(Booking.id);
            event_id = Convert.ToInt32(Booking.eventID);
            dj_id = Convert.ToInt32(Booking.dj_id);

            label16.Text = Booking.DJ;
            label17.Text = Booking.Date;
            label18.Text = Booking.time;
            label19.Text = Booking.Duration;
            label20.Text = Booking.eventType;
            label21.Text = Booking.locationType;
            label22.Text = Booking.Venue;
            label23.Text = Booking.bookType;
            label24.Text = Booking.organisation;
            label25.Text = Booking.names;
            label26.Text = Booking.email;
            label27.Text = Booking.contNumber;
            label28.Text = Booking.Company;
            label29.Text = Booking.cost.ToString("c2");
            totCost = Convert.ToDecimal(Booking.cost);
            label33.Text = Booking.loc;
            label30.Text = Booking.country;
        }

       
       
        //Navigate to booking
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking book = new Booking();
            book.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = label17.Text;
            string evntType = label20.Text;
            string time = label18.Text;
            int duration = Convert.ToInt32(label19.Text);
            string orgName = label24.Text;
            string locType = label21.Text;
            string venue = label22.Text;
            string conctNo = label27.Text;
            string bookType = label23.Text;
            string email = label26.Text;
            string clientName = label25.Text;
            string compName = label28.Text;
            string status = "seccessful";
            TimeSpan timeSpan = TimeSpan.Parse(Booking.time);


            DialogResult result = MessageBox.Show("Do you want make a booking?", "Confirm", 
                MessageBoxButtons.YesNoCancel);

            if (result==DialogResult.Yes)
            {
                bookingsTableAdapter.InsertBooking(clientId, dj_id, event_id, date,
                                             evntType, time, duration, orgName,
                                             locType, venue, conctNo, bookType,
                                              email, compName, totCost, status);

                MessageBox.Show("Your booking has been received and you will be updated soon!");
                this.Hide();
                Menu men = new Menu();
                men.Show();
            }
           

        }
    }
}
