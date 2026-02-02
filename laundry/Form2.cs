using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZXing;
using ZXing.Common;

namespace laundry
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=localhost;Database=laundryshopsystem;Uid=root;Pwd=kajsjsxz00;";
        private string? decodedOrderId = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox_QRUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var img = (Bitmap)Image.FromFile(ofd.FileName);
                        pictureBox_QRUpload.Image = img;

                        // Decode QR code using ZXing
                        int width = img.Width;
                        int height = img.Height;
                        byte[] pixels = new byte[width * height * 3];
                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                Color c = img.GetPixel(x, y);
                                int idx = (y * width + x) * 3;
                                pixels[idx] = c.R;
                                pixels[idx + 1] = c.G;
                                pixels[idx + 2] = c.B;
                            }
                        }

                        var source = new RGBLuminanceSource(pixels, width, height, RGBLuminanceSource.BitmapFormat.RGB24);
                        var reader = new BarcodeReaderGeneric();
                        var result = reader.Decode(source);
                        if (result != null)
                        {
                            decodedOrderId = result.Text;
                            MessageBox.Show($"QR Decoded: {decodedOrderId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            decodedOrderId = null;
                            MessageBox.Show("No QR code detected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(decodedOrderId))
            {
                MessageBox.Show("Please upload a QR code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch order details from DB
            var orderData = FetchOrderDetails(decodedOrderId);
            if (orderData == null)
            {
                MessageBox.Show("Order not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open Form3 (Receipt) with order data
            Form3 form3 = new Form3(orderData);
            form3.ShowDialog();
        }

        private DataTable? FetchOrderDetails(string orderId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            o.OrderID, 
                            o.CustomerID, 
                            o.Status, 
                            o.OrderDate
                        FROM orders o
                        WHERE o.OrderID = @OrderID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return dt.Rows.Count > 0 ? dt : null;
        }
    }
}