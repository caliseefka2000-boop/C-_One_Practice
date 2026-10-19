using System;
using System.Windows.Forms;

namespace Home_Assignment
{
    public partial class VehicleRentalForm : Form
    {
        public VehicleRentalForm()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtname.Text.Trim();
                int age, rentalDays, experience;

                if (string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show("Please enter customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtname.Focus();
                    return;
                }

                if (!int.TryParse(txtage.Text, out age) || age < 18 || age > 80)
                {
                    MessageBox.Show("Customer age must be between 18 and 80 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtage.Focus();
                    return;
                }

                if (!int.TryParse(txtdays.Text, out rentalDays) || rentalDays < 1 || rentalDays > 30)
                {
                    MessageBox.Show("Rental days must be between 1 and 30 days.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdays.Focus();
                    return;
                }

                if (!int.TryParse(txtexperience.Text, out experience) || experience < 0)
                {
                    MessageBox.Show("Driving experience cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtexperience.Focus();
                    return;
                }

                if (age < 21)
                {
                    MessageBox.Show("Customers below 21 years are not eligible to rent.", "Eligibility Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (experience < 1)
                {
                    MessageBox.Show("Customers must have at least 1 year of driving experience.", "Eligibility Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string vehicleType = "";
                decimal dailyRate = 0;

                if (rdoeconomy.Checked)
                {
                    vehicleType = "Economy";
                    dailyRate = 35m;
                }
                else if (rdosuv.Checked)
                {
                    vehicleType = "SUV";
                    dailyRate = 60m;
                }
                else if (rdoluxury.Checked)
                {
                    if (age < 25 || experience < 3)
                    {
                        MessageBox.Show("Luxury vehicles require at least 25 years of age and 3 years of driving experience.", "Eligibility Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    vehicleType = "Luxury";
                    dailyRate = 100m;
                }
                else
                {
                    MessageBox.Show("Please select a vehicle type.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal basicRentalCost = dailyRate * rentalDays;
                decimal discount = 0;

                if (rentalDays >= 14)
                {
                    discount = basicRentalCost * 0.10m;
                }
                else if (rentalDays >= 7)
                {
                    discount = basicRentalCost * 0.05m;
                }

                decimal insuranceCost = 0;
                if (chkinsurance.Checked)
                {
                    insuranceCost = 15m * rentalDays;
                }

                decimal youngDriverSurcharge = 0;
                if (age >= 21 && age <= 24)
                {
                    youngDriverSurcharge = basicRentalCost * 0.10m;
                }

                decimal finalRentalCost = (basicRentalCost - discount) + insuranceCost + youngDriverSurcharge;

                istresults.Text = "Rental Details\r\n" +
                                  "----------------------------------------\r\n" +
                                  "Customer Name          : " + customerName + "\r\n" +
                                  "Customer Age           : " + age + "\r\n" +
                                  "Driving Experience     : " + experience + " years\r\n" +
                                  "Vehicle Type           : " + vehicleType + "\r\n" +
                                  "Daily Rate             : " + dailyRate.ToString("c") + "\r\n" +
                                  "Rental Days            : " + rentalDays + "\r\n" +
                                  "Basic Rental Cost      : " + basicRentalCost.ToString("c") + "\r\n" +
                                  "Discount               : " + discount.ToString("c") + "\r\n" +
                                  "Insurance Cost         : " + insuranceCost.ToString("c") + "\r\n" +
                                  "Young Driver Surcharge : " + youngDriverSurcharge.ToString("c") + "\r\n" +
                                  "Final Rental Cost      : " + finalRentalCost.ToString("c") + "\r\n\r\n" +
                                  "Rental Status          : Approved";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtage.Text = "";
            txtdays.Text = "";
            txtexperience.Text = "";
            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;
            chkinsurance.Checked = false;
            istresults.Text = "";
            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
