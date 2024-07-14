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
    public partial class Booking : Form
    {

        //Static variable to carry variables to confirm form.
        public static string DJ = "";
        public static string Date = "";
        public static string time ="";
        public static string Duration = "";
        public static string eventType ="";
        public static string locationType = "";
        public static string Venue = "";
        public static string bookType = "";
        public static string organisation = "";
        public static string names = "";
        public static string email = "";
        public static string contNumber = "";
        public static string Company = "";
        public static string eventID = "";
        public static string dj_id = "";
        public static double cost = 0;
        public static string id = "";
        public static string loc = "";
        public static string country = "";
        public Booking()
        {
            InitializeComponent();
            

        }

        //Navigating to Menu form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //bookTableAdapter.FillBy(ist3cxDataSet.Book, txtTime.Text);
        }

        //Loading a comboBox
        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g12Wst2024DataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.g12Wst2024DataSet2.Clients);
            // TODO: This line of code loads data into the 'g12Wst2024DataSet.DJs' table. You can move, or remove it, as needed.
            this.dJsTableAdapter.Fill(this.g12Wst2024DataSet.DJs);
            this.eventsTableAdapter.Fill(this.g12Wst2024DataSet.Events);

            // Set the minimum date to the current date
            date1.MinDate = DateTime.Today.AddDays(4);

            // Set the initial value to the current date
            date1.Value = DateTime.Today.AddDays(4);



            DurCombo.Items.Add("1");
            DurCombo.Items.Add("2");
            DurCombo.Items.Add("3");
            DurCombo.Items.Add("4");
            DurCombo.Items.Add("5");
            DurCombo.Items.Add("6");

            bookingTypes.Items.Add("Individual");
            bookingTypes.Items.Add("Organisation");

            LocType.Items.Add("Local Indoor");
            LocType.Items.Add("Local Outdoor");
            LocType.Items.Add("International Indoor");
            LocType.Items.Add("International Outdoor");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDJ.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            dj_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }


        //Method to check if the selected time is with the booked range or not.
        private bool IsTimeBetween(TimeSpan startTime, TimeSpan endTime, TimeSpan selectedTime)
        {
            if (startTime > endTime)
            {
                return selectedTime >= startTime || selectedTime <= endTime;
            }
            else
            {
                return selectedTime >= startTime && selectedTime <= endTime;
            }
        }

        double rate = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                //Assigning data to the static variables
                DJ = txtDJ.Text;
                Date = date1.Text;
                time = txtTime.Text;
                Duration = DurCombo.Text;
                eventType = EventBookType.Text;
                locationType = LocType.Text;
                Venue = venues.Text;
                bookType = bookingTypes.Text;
                organisation = OrgName.Text;
                names = name.Text;
                email = txtEmail.Text;
                contNumber = phoneNumber.Text;
                Company = companys.Text;
                country = textBox4.Text;
                loc = textBox3.Text;
                //getting rates and calculating cost

                int durationHours = Convert.ToInt32(Duration);

                double exchangeRate = 18.76; // 1 USD = 18.76 ZAR
                if (LocType.Text == "Local Indoor")
                {
                    rate = Convert.ToInt32(dJsTableAdapter.getLocalIndoorRate(txtDJ.Text));

                    cost = (durationHours * rate) / exchangeRate;

                }
                else if (LocType.Text == "Local Outdoor")
                {
                    rate = Convert.ToInt32(dJsTableAdapter.getLocalOutDoorRate(txtDJ.Text));

                    cost = (durationHours * rate) / exchangeRate;
                }
                else if (LocType.Text == "International Indoor")
                {
                    rate = Convert.ToInt32(dJsTableAdapter.getInternationalIndoorRate(txtDJ.Text));

                    cost = (durationHours * rate) / exchangeRate;
                }
                else if (LocType.Text == "International Outdoor")
                {
                    rate = Convert.ToInt32(dJsTableAdapter.getInternationalOutDoorRate(txtDJ.Text));

                    cost = (durationHours * rate) / exchangeRate;
                }


                //getting ids
                eventID = eventsTableAdapter.getEventId(EventBookType.Text).ToString();

                //Checking if the DJ is booked or not.

                //get the selected dj id
                int djID = Convert.ToInt32(dj_id);

                //Get start time and end time 

                string djTimeString = bookingsTableAdapter.getDjTime(djID).ToString();
                DateTime djDateTime;

                //convertign string to date time
                if (DateTime.TryParse(djTimeString, out djDateTime))
                {
                    //MessageBox.Show("Invalid date");
                }

                TimeSpan startTime, endTime, selectedTime;


                startTime = djDateTime.TimeOfDay;


                if (!TimeSpan.TryParse(txtTime.Text, out selectedTime) ||
                    !TimeSpan.TryParse(txtTime.Text, out selectedTime))
                {
                    //MessageBox.Show("Invalid time");
                }



                
                DateTime selectedDate = date1.Value.Date; //date from the new booker


                //Getting end  time for the DJ.
                string date = selectedDate.ToLongDateString();

                int DJdur = Convert.ToInt32(bookingsTableAdapter.getDjDurTime(djID, date));




                TimeSpan duration = TimeSpan.FromHours(DJdur);
                endTime = startTime.Add(duration);

                //string dateInBookings = bookedDate.ToLongDateString();
                string chosedByClient = selectedDate.ToLongDateString();




                //Checking if the DJ is booked or not
                bookingsTableAdapter.checkDjAvailability(g12Wst2024DataSet.Bookings, djID, chosedByClient, selectedTime.ToString());
                if (g12Wst2024DataSet.Bookings.Rows.Count > 0)
                {
                    MessageBox.Show("The DJ is Booked at this specified time, Please choose another or select another");

                }

                else if (IsTimeBetween(startTime, endTime, selectedTime))
                {
                    MessageBox.Show("The DJ is booked for this specified time and date!, " +
                        "Please choose another");
                }

                else
                {
                    this.Hide();
                    ConfirmBooking confirm = new ConfirmBooking();
                    confirm.Show();
                }
            }



            catch (Exception)
            {

                MessageBox.Show("Make sure that the event type is selected!");
            }


        }

        

        

        private void bookingTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookingTypes.Text.Equals("Organisation"))
            {
                OrgName.Visible = true;
                OrgNameLabel.Visible = true;
            }
            else
            {
                OrgName.Visible = false;
                OrgNameLabel.Visible = false;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dJsTableAdapter.FillByStageName(g12Wst2024DataSet.DJs, textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            clientsTableAdapter1.FillByClientname(g12Wst2024DataSet2.Clients, textBox2.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            phoneNumber.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            companys.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

            //Getting ids
            id = dataGridView2.CurrentRow.Cells[0].Value.ToString();


        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
