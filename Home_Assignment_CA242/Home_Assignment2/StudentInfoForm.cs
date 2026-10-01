private void btnshowinfo_Click(object sender, EventArgs e)
{
    try
    {
        string studentName = txtname.Text;
        string studentId = txtstudentid.Text;
        string department = txtdepartment.Text;
        string semester = txtsemester.Text;

        string fullInfo = "Name: " + studentName + "\nID: " + studentId + "\nDepartment: " + department + "\nSemester: " + semester;
        lbloutput.Text = fullInfo;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

private void btnclear_Click(object sender, EventArgs e)
{
    txtname.Text = "";
    txtstudentid.Text = "";
    txtdepartment.Text = "";
    txtsemester.Text = "";
    lbloutput.Text = "";
    txtname.Focus();
}

private void btnexit_Click(object sender, EventArgs e)
{
    this.Close();
}
