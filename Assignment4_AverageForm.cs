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

                    string grade = "";

                    if (average >= 90)
                    {
                        grade = "A (Very Good)";
                    }
                    else if (average >= 80)
                    {
                        grade = "B (Good)";
                    }
                    else if (average >= 70)
                    {
                        grade = "C (Credit)";
                    }
                    else if (average >= 60)
                    {
                        grade = "D (Pass)";
                    }
                    else
                    {
                        grade = "F (Fail)";
                    }

                    MessageBox.Show("Average: " + average.ToString("n1") + "\nGrade: " + grade, "Exam Result");
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers in all three boxes!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
