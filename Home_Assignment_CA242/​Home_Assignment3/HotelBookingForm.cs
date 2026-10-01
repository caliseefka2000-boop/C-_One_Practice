private void btnCalculate_Click(object sender, EventArgs e)
{
    try
    {
        string guestName = txtGuestName.Text;
        string roomType = txtRoomType.Text;
        int nights = int.Parse(txtNights.Text);
        decimal pricePerNight = decimal.Parse(txtPriceNight.Text);

        decimal subtotal = nights * pricePerNight;
        decimal serviceTax = subtotal * 0.10m;
        decimal discount = subtotal * 0.05m;
        decimal totalAmount = (subtotal + serviceTax) - discount;

        lblServiceTax.Text = serviceTax.ToString("c");
        lblDiscount.Text = discount.ToString("c");
        lblTotalAmount.Text = totalAmount.ToString("c");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}
