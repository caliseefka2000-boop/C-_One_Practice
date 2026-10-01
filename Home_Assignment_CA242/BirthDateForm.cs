private void showDateButton_Click(object sender, EventArgs e)
{
    try
    {
        string dayOfWeek = dayOfWeekTextBox.Text;
        string month = monthTextBox.Text;
        string dayOfMonth = dayOfMonthTextBox.Text;
        string year = yearTextBox.Text;

        string fullDate = dayOfWeek + ", " + month + " " + dayOfMonth + ", " + year;
        dateOutputLabel.Text = fullDate;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

private void clearButton_Click(object sender, EventArgs e)
{
    dayOfWeekTextBox.Text = "";
    monthTextBox.Text = "";
    dayOfMonthTextBox.Text = "";
    yearTextBox.Text = "";
    dateOutputLabel.Text = "";
    dayOfWeekTextBox.Focus();
}

private void exitButton_Click(object sender, EventArgs e)
{
    this.Close();
}
