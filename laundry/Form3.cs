using System;
using System.Data;
using System.Windows.Forms;

namespace laundry
{
    public partial class Form3 : Form
    {
        private DataTable orderData;

        public Form3(DataTable data)
        {
            InitializeComponent();
            orderData = data;
            DisplayReceipt();
        }

        private void DisplayReceipt()
        {
            if (orderData == null || orderData.Rows.Count == 0)
            {
                MessageBox.Show("No order data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = orderData.Rows[0];

            // Display order information
            string orderId = row["OrderID"]?.ToString() ?? "N/A";
            string customerId = row["CustomerID"]?.ToString() ?? "N/A";
            string orderDate = "N/A";
            if (row["OrderDate"] != DBNull.Value && DateTime.TryParse(row["OrderDate"].ToString(), out DateTime parsedDate))
            {
                orderDate = parsedDate.ToString("MMM dd, yyyy");
            }
            string status = row["Status"]?.ToString() ?? "N/A";

            // Update status display at top
            lblStatusValue.Text = status.ToUpper();

            // Populate receipt details
            PopulateReceiptDetails(orderId, customerId, orderDate);
        }

        private void PopulateReceiptDetails(string orderId, string customerId, string orderDate)
        {
            // Shop Information (static)
            lblShopName.Text = "Labamoto Days";
            lblShopLocation.Text = "Camp Downes";
            lblShopContact.Text = "Contact: 09706944403";
            lblShopEmail.Text = "Email: maniliandres00@gmail.com";
            lblShopPermit.Text = "Permit: 12321321";
            lblShopTIN.Text = "TIN: 12122112";

            // Order Details from Database
            lblOrderIDValue.Text = $"Order ID: #{orderId}";
            lblDateValue.Text = $"Date: {orderDate}";
            lblCustomerNameValue.Text = $"Customer Name: {customerId}";

            // Get dynamic data from orderData
            DataRow row = orderData.Rows[0];

            // Order Breakdown - from database
            string itemDescription = row["OrderDescription"]?.ToString() ?? "Service";
            string itemDetails = row["ItemDetails"]?.ToString() ?? "N/A";
            string itemPrice = row["ItemPrice"]?.ToString() ?? "0.00";
            
            lblItemName.Text = itemDescription;
            lblItemDetails.Text = itemDetails;
            lblItemPrice.Text = $"PHP {itemPrice}";

            // Totals and Payment - from database
            string totalAmount = row["TotalAmount"]?.ToString() ?? "0.00";
            string rushFee = row["RushFee"]?.ToString() ?? "0.00";
            string paymentMethod = row["PaymentMethod"]?.ToString() ?? "N/A";
            string amountPaid = row["AmountPaid"]?.ToString() ?? "0.00";
            string expectedCompletion = row["ExpectedCompletionDate"]?.ToString() ?? "N/A";

            // Calculate subtotal and change
            double subtotal = double.Parse(itemPrice ?? "0");
            double rush = double.Parse(rushFee ?? "0");
            double total = double.Parse(totalAmount ?? "0");
            double paid = double.Parse(amountPaid ?? "0");
            double change = paid - total;

            lblSubtotal.Text = $"Subtotal: PHP {subtotal:F2}";
            lblRushService.Text = $"Rush Service (+50%): PHP {rush:F2}";
            lblTotalDue.Text = $"Total Amount Due: PHP {total:F2}";
            lblPaymentMethod.Text = $"Payment Method: {paymentMethod}";
            lblAmountPaid.Text = $"Amount Paid: PHP {paid:F2}";
            lblChange.Text = $"Change: PHP {Math.Max(change, 0):F2}";
            lblCompletionDate.Text = $"Expected Completion: {expectedCompletion}";

            // Shop Contact
            lblShopContactTitle.Text = "Shop Contact";
            lblShopNameContact.Text = "Shop Name: Labamoto Days";
            lblShopPhoneContact.Text = "Contact Number: 09706944403";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

