using System;
using System.Windows.Forms;

namespace Home_Assignment
{
    public partial class HotelBookingForm : Form
    {
        public HotelBookingForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string guestName = txtGuestName.Text.Trim();
                int guestAge, nights, guests;

                if (string.IsNullOrEmpty(guestName))
                {
                    MessageBox.Show("Guest Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGuestName.Focus();
                    return;
                }

                if (!int.TryParse(txtGuestAge.Text, out guestAge) || guestAge < 18 || guestAge > 90)
                {
                    MessageBox.Show("Guest age must be between 18 and 90.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGuestAge.Focus();
                    return;
                }

                if (!int.TryParse(txtNights.Text, out nights) || nights < 1 || nights > 30)
                {
                    MessageBox.Show("Number of nights must be between 1 and 30.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNights.Focus();
                    return;
                }

                if (!int.TryParse(txtGuests.Text, out guests) || guests < 1 || guests > 6)
                {
                    MessageBox.Show("Number of guests must be between 1 and 6.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGuests.Focus();
                    return;
                }

                string roomType = "";
                decimal ratePerNight = 0;
                int maxCapacity = 0;

                if (rdoStandard.Checked)
                {
                    roomType = "Standard";
                    ratePerNight = 50m;
                    maxCapacity = 2;
                }
                else if (rdoNormal.Checked)
                {
                    roomType = "Normal";
                    ratePerNight = 80m;
                    maxCapacity = 4;
                }
                else if (rdoHight.Checked)
                {
                    roomType = "Suite (Hight)";
                    ratePerNight = 130m;
                    maxCapacity = 6;
                }
                else
                {
                    MessageBox.Show("Please select a room type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (guests > maxCapacity)
                {
                    MessageBox.Show(roomType + " rooms can accommodate a maximum of " + maxCapacity + " guests.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal basicCost = ratePerNight * nights;
                decimal discount = 0;

                if (nights >= 10)
                {
                    discount = basicCost * 0.12m;
                }
                else if (nights >= 5)
                {
                    discount = basicCost * 0.05m;
                }

                decimal breakfastCost = 0;
                if (chkBreakfast.Checked)
                {
                    breakfastCost = 10m * guests * nights;
                }

                decimal serviceSurcharge = 0;
                if (guests > 4)
                {
                    serviceSurcharge = basicCost * 0.05m;
                }

                decimal subTotal = (basicCost - discount) + breakfastCost + serviceSurcharge;
                decimal seniorDiscount = 0;

                if (guestAge >= 60)
                {
                    seniorDiscount = subTotal * 0.05m;
                }

                decimal finalTotal = subTotal - seniorDiscount;

                txtBookingDetails.Text = "Booking Details\r\n" +
                                         "----------------------------------------\r\n" +
                                         "Guest Name       : " + guestName + "\r\n" +
                                         "Guest Age        : " + guestAge + "\r\n" +
                                         "Room Type        : " + roomType + "\r\n" +
                                         "Number of Nights : " + nights + "\r\n" +
                                         "Number of Guests : " + guests + "\r\n" +
                                         "Basic Cost       : " + basicCost.ToString("c") + "\r\n" +
                                         "Length Discount  : " + discount.ToString("c") + "\r\n" +
                                         "Breakfast Cost   : " + breakfastCost.ToString("c") + "\r\n" +
                                         "Service Surcharge: " + serviceSurcharge.ToString("c") + "\r\n" +
                                         "Senior Discount  : " + seniorDiscount.ToString("c") + "\r\n" +
                                         "Final Total Cost : " + finalTotal.ToString("c") + "\r\n\r\n" +
                                         "Booking Status   : Approved";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Text = "";
            txtGuestAge.Text = "";
            txtNights.Text = "";
            txtGuests.Text = "";
            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;
            chkBreakfast.Checked = false;
            txtBookingDetails.Text = "";
            txtGuestName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
