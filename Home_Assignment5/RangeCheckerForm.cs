using System;
using System.Windows.Forms;

namespace Home_Assignment5
{
    public partial class RangeCheckerForm : Form
    {
        public RangeCheckerForm()
        {
            InitializeComponent();
        }

        private void btnCheckQualification_Click(object sender, EventArgs e)
        {
            try
            {
                int number;

                if (int.TryParse(txtNumber.Text, out number))
                {
                    if (number >= 1 && number <= 10)
                    {
                        lblDecision.Text = "The number is within the range of 1 through 10.";
                    }
                    else
                    {
                        lblDecision.Text = "The number is outside the valid range.";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            lblDecision.Text = "";
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
