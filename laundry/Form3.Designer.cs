using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace laundry
{
    partial class Form3
    {
        private IContainer components = null;
        private Panel pnlStatusDisplay;
        private Label lblStatusText;
        public Label lblStatusValue;
        private GroupBox gbStatusProgress;
        public RadioButton rbPending;
        public RadioButton rbWashing;
        public RadioButton rbReady;
        private ProgressBar pbPending;
        private ProgressBar pbWashing;
        private ProgressBar pbReady;
        private Label lblOrderDetailsTitle;
        public Label lblOrderIDValue;
        public Label lblCustomerNameValue;
        private Panel pnlOrderDetails;
        private Panel pnlShopContact;
        private Label lblShopContactTitle;
        private Label lblShopNameContact;
        private Label lblShopPhoneContact;
        private Label lblShopContactNumber;
        private Button btnDone;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlStatusDisplay = new Panel();
            lblStatusText = new Label();
            lblStatusValue = new Label();
            gbStatusProgress = new GroupBox();
            rbPending = new RadioButton();
            pbPending = new ProgressBar();
            rbWashing = new RadioButton();
            pbWashing = new ProgressBar();
            rbReady = new RadioButton();
            pbReady = new ProgressBar();
            lblOrderDetailsTitle = new Label();
            lblOrderIDValue = new Label();
            lblCustomerNameValue = new Label();
            pnlOrderDetails = new Panel();
            pnlShopContact = new Panel();
            lblShopContactTitle = new Label();
            lblShopNameContact = new Label();
            lblShopPhoneContact = new Label();
            lblShopContactNumber = new Label();
            btnDone = new Button();
            pictureBox1 = new PictureBox();
            pnlStatusDisplay.SuspendLayout();
            gbStatusProgress.SuspendLayout();
            pnlOrderDetails.SuspendLayout();
            pnlShopContact.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlStatusDisplay
            // 
            pnlStatusDisplay.BackColor = Color.White;
            pnlStatusDisplay.BorderStyle = BorderStyle.FixedSingle;
            pnlStatusDisplay.Controls.Add(lblStatusText);
            pnlStatusDisplay.Controls.Add(lblStatusValue);
            pnlStatusDisplay.Location = new Point(18, 106);
            pnlStatusDisplay.Margin = new Padding(3, 2, 3, 2);
            pnlStatusDisplay.Name = "pnlStatusDisplay";
            pnlStatusDisplay.Padding = new Padding(9, 8, 9, 8);
            pnlStatusDisplay.Size = new Size(420, 93);
            pnlStatusDisplay.TabIndex = 0;
            // 
            // lblStatusText
            // 
            lblStatusText.AutoSize = true;
            lblStatusText.Font = new Font("Segoe UI", 16F);
            lblStatusText.Location = new Point(124, 8);
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(159, 30);
            lblStatusText.TabIndex = 0;
            lblStatusText.Text = "Your laundry is:";
            lblStatusText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusValue
            // 
            lblStatusValue.Dock = DockStyle.Top;
            lblStatusValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblStatusValue.ForeColor = Color.FromArgb(0, 40, 100);
            lblStatusValue.Location = new Point(9, 8);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(400, 93);
            lblStatusValue.TabIndex = 1;
            lblStatusValue.Text = "WASHING";
            lblStatusValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbStatusProgress
            // 
            gbStatusProgress.BackColor = Color.White;
            gbStatusProgress.Controls.Add(rbPending);
            gbStatusProgress.Controls.Add(pbPending);
            gbStatusProgress.Controls.Add(rbWashing);
            gbStatusProgress.Controls.Add(pbWashing);
            gbStatusProgress.Controls.Add(rbReady);
            gbStatusProgress.Controls.Add(pbReady);
            gbStatusProgress.FlatStyle = FlatStyle.Flat;
            gbStatusProgress.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            gbStatusProgress.Location = new Point(18, 224);
            gbStatusProgress.Margin = new Padding(3, 2, 3, 2);
            gbStatusProgress.Name = "gbStatusProgress";
            gbStatusProgress.Padding = new Padding(9, 8, 9, 8);
            gbStatusProgress.Size = new Size(420, 135);
            gbStatusProgress.TabIndex = 1;
            gbStatusProgress.TabStop = false;
            gbStatusProgress.Text = "Status Progress:";
            // 
            // rbPending
            // 
            rbPending.AutoSize = true;
            rbPending.FlatStyle = FlatStyle.Flat;
            rbPending.Font = new Font("Segoe UI", 13F);
            rbPending.Location = new Point(26, 26);
            rbPending.Margin = new Padding(3, 2, 3, 2);
            rbPending.Name = "rbPending";
            rbPending.Size = new Size(93, 29);
            rbPending.TabIndex = 0;
            rbPending.Text = "Pending";
            // 
            // pbPending
            // 
            pbPending.Enabled = false;
            pbPending.ForeColor = Color.LightGray;
            pbPending.Location = new Point(131, 32);
            pbPending.Margin = new Padding(3, 2, 3, 2);
            pbPending.Name = "pbPending";
            pbPending.Size = new Size(262, 8);
            pbPending.TabIndex = 1;
            // 
            // rbWashing
            // 
            rbWashing.AutoSize = true;
            rbWashing.FlatStyle = FlatStyle.Flat;
            rbWashing.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbWashing.Location = new Point(26, 60);
            rbWashing.Margin = new Padding(3, 2, 3, 2);
            rbWashing.Name = "rbWashing";
            rbWashing.Size = new Size(97, 29);
            rbWashing.TabIndex = 2;
            rbWashing.Text = "Washing";
            // 
            // pbWashing
            // 
            pbWashing.Enabled = false;
            pbWashing.ForeColor = Color.FromArgb(30, 40, 60);
            pbWashing.Location = new Point(131, 65);
            pbWashing.Margin = new Padding(3, 2, 3, 2);
            pbWashing.Name = "pbWashing";
            pbWashing.Size = new Size(262, 8);
            pbWashing.TabIndex = 3;
            // 
            // rbReady
            // 
            rbReady.AutoSize = true;
            rbReady.FlatStyle = FlatStyle.Flat;
            rbReady.Font = new Font("Segoe UI", 13F);
            rbReady.Location = new Point(26, 94);
            rbReady.Margin = new Padding(3, 2, 3, 2);
            rbReady.Name = "rbReady";
            rbReady.Size = new Size(162, 29);
            rbReady.TabIndex = 4;
            rbReady.Text = "Ready for Pickup";
            // 
            // pbReady
            // 
            pbReady.Enabled = false;
            pbReady.ForeColor = Color.LightGray;
            pbReady.Location = new Point(131, 99);
            pbReady.Margin = new Padding(3, 2, 3, 2);
            pbReady.Name = "pbReady";
            pbReady.Size = new Size(262, 8);
            pbReady.TabIndex = 5;
            // 
            // lblOrderDetailsTitle
            // 
            lblOrderDetailsTitle.AutoSize = true;
            lblOrderDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOrderDetailsTitle.Location = new Point(9, 8);
            lblOrderDetailsTitle.Name = "lblOrderDetailsTitle";
            lblOrderDetailsTitle.Size = new Size(110, 21);
            lblOrderDetailsTitle.TabIndex = 0;
            lblOrderDetailsTitle.Text = "Order Details";
            // 
            // lblOrderIDValue
            // 
            lblOrderIDValue.AutoSize = true;
            lblOrderIDValue.Font = new Font("Segoe UI", 11F);
            lblOrderIDValue.Location = new Point(9, 26);
            lblOrderIDValue.Name = "lblOrderIDValue";
            lblOrderIDValue.Size = new Size(122, 20);
            lblOrderIDValue.TabIndex = 1;
            lblOrderIDValue.Text = "Order ID: #00052";
            // 
            // lblCustomerNameValue
            // 
            lblCustomerNameValue.AutoSize = true;
            lblCustomerNameValue.Font = new Font("Segoe UI", 11F);
            lblCustomerNameValue.Location = new Point(9, 45);
            lblCustomerNameValue.Name = "lblCustomerNameValue";
            lblCustomerNameValue.Size = new Size(149, 20);
            lblCustomerNameValue.TabIndex = 2;
            lblCustomerNameValue.Text = "Customer Name: kort";
            // 
            // pnlOrderDetails
            // 
            pnlOrderDetails.BackColor = Color.White;
            pnlOrderDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderDetails.Controls.Add(lblOrderDetailsTitle);
            pnlOrderDetails.Controls.Add(lblOrderIDValue);
            pnlOrderDetails.Controls.Add(lblCustomerNameValue);
            pnlOrderDetails.Location = new Point(18, 377);
            pnlOrderDetails.Margin = new Padding(3, 2, 3, 2);
            pnlOrderDetails.Name = "pnlOrderDetails";
            pnlOrderDetails.Padding = new Padding(9, 8, 9, 8);
            pnlOrderDetails.Size = new Size(420, 68);
            pnlOrderDetails.TabIndex = 2;
            // 
            // pnlShopContact
            // 
            pnlShopContact.BackColor = Color.White;
            pnlShopContact.BorderStyle = BorderStyle.FixedSingle;
            pnlShopContact.Controls.Add(lblShopContactTitle);
            pnlShopContact.Controls.Add(lblShopNameContact);
            pnlShopContact.Controls.Add(lblShopPhoneContact);
            pnlShopContact.Controls.Add(lblShopContactNumber);
            pnlShopContact.Location = new Point(18, 466);
            pnlShopContact.Margin = new Padding(3, 2, 3, 2);
            pnlShopContact.Name = "pnlShopContact";
            pnlShopContact.Padding = new Padding(9, 8, 9, 8);
            pnlShopContact.Size = new Size(420, 68);
            pnlShopContact.TabIndex = 3;
            // 
            // lblShopContactTitle
            // 
            lblShopContactTitle.AutoSize = true;
            lblShopContactTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblShopContactTitle.Location = new Point(9, 8);
            lblShopContactTitle.Name = "lblShopContactTitle";
            lblShopContactTitle.Size = new Size(112, 21);
            lblShopContactTitle.TabIndex = 0;
            lblShopContactTitle.Text = "Shop Contact";
            // 
            // lblShopNameContact
            // 
            lblShopNameContact.AutoSize = true;
            lblShopNameContact.Font = new Font("Segoe UI", 11F);
            lblShopNameContact.Location = new Point(9, 26);
            lblShopNameContact.Name = "lblShopNameContact";
            lblShopNameContact.Size = new Size(260, 20);
            lblShopNameContact.TabIndex = 1;
            lblShopNameContact.Text = "Shop Name:  Labamoto Laundry Shop";
            // 
            // lblShopPhoneContact
            // 
            lblShopPhoneContact.AutoSize = true;
            lblShopPhoneContact.Font = new Font("Segoe UI", 11F);
            lblShopPhoneContact.ForeColor = Color.Red;
            lblShopPhoneContact.Location = new Point(9, 45);
            lblShopPhoneContact.Name = "lblShopPhoneContact";
            lblShopPhoneContact.Size = new Size(121, 20);
            lblShopPhoneContact.TabIndex = 2;
            lblShopPhoneContact.Text = "Contact Number:";
            // 
            // lblShopContactNumber
            // 
            lblShopContactNumber.AutoSize = true;
            lblShopContactNumber.Font = new Font("Segoe UI", 11F);
            lblShopContactNumber.Location = new Point(122, 45);
            lblShopContactNumber.Name = "lblShopContactNumber";
            lblShopContactNumber.Size = new Size(109, 20);
            lblShopContactNumber.TabIndex = 3;
            lblShopContactNumber.Text = "(123) 456-7890";
            // 
            // btnDone
            // 
            btnDone.BackColor = SystemColors.Highlight;
            btnDone.ForeColor = Color.White;
            btnDone.Location = new Point(27, 563);
            btnDone.Margin = new Padding(3, 2, 3, 2);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(410, 37);
            btnDone.TabIndex = 4;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoblue;
            pictureBox1.Location = new Point(124, 25);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 40);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 628);
            Controls.Add(pictureBox1);
            Controls.Add(pnlStatusDisplay);
            Controls.Add(gbStatusProgress);
            Controls.Add(pnlOrderDetails);
            Controls.Add(pnlShopContact);
            Controls.Add(btnDone);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Order Status";
            pnlStatusDisplay.ResumeLayout(false);
            pnlStatusDisplay.PerformLayout();
            gbStatusProgress.ResumeLayout(false);
            gbStatusProgress.PerformLayout();
            pnlOrderDetails.ResumeLayout(false);
            pnlOrderDetails.PerformLayout();
            pnlShopContact.ResumeLayout(false);
            pnlShopContact.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
    }
}
