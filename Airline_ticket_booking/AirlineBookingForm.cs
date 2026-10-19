using System;
using System.Windows.Forms;

namespace Home_Assignment
{
    public partial class AirlineBookingForm : Form
    {
        public AirlineBookingForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string passengerName = txtPassengerName.Text.Trim();
                int age, tickets;
                decimal baggageWeight;

                if (string.IsNullOrEmpty(passengerName))
                {
                    MessageBox.Show("Passenger Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassengerName.Focus();
                    return;
                }

                if (!int.TryParse(txtPassengerAge.Text, out age) || age < 1 || age > 100)
                {
                    MessageBox.Show("Passenger age must be between 1 and 100 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassengerAge.Focus();
                    return;
                }

                if (!int.TryParse(txtTickets.Text, out tickets) || tickets < 1 || tickets > 5)
                {
                    MessageBox.Show("Number of tickets must be between 1 and 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTickets.Focus();
                    return;
                }

                if (!decimal.TryParse(txtBaggage.Text, out baggageWeight) || baggageWeight < 0 || baggageWeight > (50 * tickets))
                {
                    MessageBox.Show("Baggage weight cannot be negative and cannot exceed 50 kg per passenger.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBaggage.Focus();
                    return;
                }

                string travelClass = "";
                decimal ticketPrice = 0;

                if (rdoFirstClass.Checked)
                {
                    if (age < 12)
                    {
                        MessageBox.Show("Passengers below 12 years cannot book First Class. Booking rejected.", "Booking Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    travelClass = "First Class";
                    ticketPrice = 250m;
                }
                else if (rdoNormalClass.Checked)
                {
                    travelClass = "Normal Class";
                    ticketPrice = 120m;
                }
                else if (rdoBusinessClass.Checked)
                {
                    travelClass = "Business Class";
                    ticketPrice = 180m;
                }
                else
                {
                    MessageBox.Show("Please select a travel class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal basicTicketCost = ticketPrice * tickets;
                decimal ticketDiscount = 0;

                if (tickets == 5)
                {
                    ticketDiscount = basicTicketCost * 0.10m;
                }
                else if (tickets >= 3)
                {
                    ticketDiscount = basicTicketCost * 0.05m;
                }

                decimal ageDiscount = 0;
                if (age < 12)
                {
                    ageDiscount = (basicTicketCost - ticketDiscount) * 0.20m;
                }
                else if (age >= 60)
                {
                    ageDiscount = (basicTicketCost - ticketDiscount) * 0.10m;
                }

                decimal insuranceCost = 0;
                if (chkInsurance.Checked)
                {
                    insuranceCost = 25m * tickets;
                }

                decimal baggageFee = 0;
                decimal allowedBaggage = 20m * tickets;
                if (baggageWeight > allowedBaggage)
                {
                    decimal excessWeight = baggageWeight - allowedBaggage;
                    baggageFee = excessWeight * 2m; // $2 per extra kg
                }

                decimal finalAmount = (basicTicketCost - ticketDiscount - ageDiscount) + insuranceCost + baggageFee;

                txtBookingResults.Text = "Airline Booking Details\r\n" +
                                         "----------------------------------------\r\n" +
                                         "Passenger Name   : " + passengerName + "\r\n" +
                                         "Passenger Age    : " + age + "\r\n" +
                                         "Travel Class     : " + travelClass + "\r\n" +
                                         "Number of Tickets: " + tickets + "\r\n" +
                                         "Baggage Weight   : " + baggageWeight + " kg\r\n" +
                                         "Basic Ticket Cost: " + basicTicketCost.ToString("c") + "\r\n" +
                                         "Ticket Discount  : " + ticketDiscount.ToString("c") + "\r\n" +
                                         "Age Discount     : " + ageDiscount.ToString("c") + "\r\n" +
                                         "Insurance Cost   : " + insuranceCost.ToString("c") + "\r\n" +
                                         "Excess Baggage Fee: " + baggageFee.ToString("c") + "\r\n" +
                                         "Final Total Cost : " + finalAmount.ToString("c") + "\r\n\r\n" +
                                         "Booking Status   : Approved";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Text = "";
            txtPassengerAge.Text = "";
            txtTickets.Text = "";
            txtBaggage.Text = "";
            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;
            chkInsurance.Checked = false;
            txtBookingResults.Text = "";
            txtPassengerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
