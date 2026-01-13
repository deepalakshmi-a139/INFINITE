using System;
using System.Text.RegularExpressions;
using System.Web.UI;
using ElectricityBillingAutomation.Models;
using ElectricityBillingAutomation.BusinessLogic;

namespace ElectricityBillingAutomation
{
    public partial class AddBill : Page
    {
        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Consumer Number validation: must start with EB + 5 digits
                if (!Regex.IsMatch(txtConsumerNumber.Text, @"^EB\d{5}$"))
                {
                    throw new FormatException("Invalid Consumer Number");
                }

                // ✅ Consumer Name validation
                if (string.IsNullOrWhiteSpace(txtConsumerName.Text))
                {
                    lblResult.CssClass = "alert alert-danger";
                    lblResult.Text = "Consumer Name is required.";
                    return;
                }

                // ✅ Units validation
                if (!int.TryParse(txtUnits.Text, out int units))
                {
                    lblResult.CssClass = "alert alert-danger";
                    lblResult.Text = "Units Consumed must be numeric.";
                    return;
                }

                BillValidator validator = new BillValidator();
                string result = validator.ValidateUnitsConsumed(units);

                if (result != "Valid")
                {
                    lblResult.CssClass = "alert alert-danger";
                    lblResult.Text = result;
                    return;
                }

                // ✅ Build ElectricityBill object
                ElectricityBill eb = new ElectricityBill
                {
                    ConsumerNumber = txtConsumerNumber.Text,
                    ConsumerName = txtConsumerName.Text,
                    UnitsConsumed = units
                };

                // ✅ Calculate and store bill
                ElectricityBoard board = new ElectricityBoard();
                board.CalculateBill(eb);
                board.AddBill(eb);

                // ✅ Success message with link to ViewBills
                lblResult.CssClass = "alert alert-success mt-3 d-block text-center";
                lblResult.Text = $"Bill Added Successfully! Amount = {eb.BillAmount}. " +
                                 $"<a href='ViewBills.aspx' class='alert-link'>Click here to view bills</a>";
            }
            catch (FormatException ex)
            {
                lblResult.CssClass = "alert alert-danger mt-3 d-block text-center";
                lblResult.Text = ex.Message; // "Invalid Consumer Number"
            }
            catch (Exception ex)
            {
                lblResult.CssClass = "alert alert-danger mt-3 d-block text-center";
                lblResult.Text = "Error: " + ex.Message;
            }
        }
    }
}
