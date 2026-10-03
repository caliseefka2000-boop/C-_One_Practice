using System;
using System.Windows.Forms;

namespace Home_Assignment4
{
    public partial class TestScoreAverageForm : Form
    {
        public TestScoreAverageForm()
        {
            InitializeComponent();
        }

        private void calculateAverageButton_Click(object sender, EventArgs e)
        {
            try
            {
                double score1, score2, score3;

                if (double.TryParse(txtScore1.Text, out score1) &&
                    double.TryParse(txtScore2.Text, out score2) &&
                    double.TryParse(txtScore3.Text, out score3))
                {
                    double average = (score1 + score2 + score3) / 3.0;

                    lblAverageOutput.Text = average.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Fadlan geli tirooyin sax ah dhammaan saddexda meelood!", "Khalad Xog", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtScore1.Text = "";
            txtScore2.Text = "";
            txtScore3.Text = "";
            lblAverageOutput.Text = "";
            txtScore1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
