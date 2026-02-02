using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace laundry
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private PictureBox pictureBox_QRUpload;
        private Button btnShowReceipt;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_QRUpload = new PictureBox();
            btnShowReceipt = new Button();
            ((ISupportInitialize)pictureBox_QRUpload).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_QRUpload
            // 
            pictureBox_QRUpload.BackColor = SystemColors.ControlLightLight;
            pictureBox_QRUpload.BorderStyle = BorderStyle.Fixed3D;
            pictureBox_QRUpload.Cursor = Cursors.Hand;
            pictureBox_QRUpload.Location = new Point(60, 106);
            pictureBox_QRUpload.Name = "pictureBox_QRUpload";
            pictureBox_QRUpload.Size = new Size(250, 250);
            pictureBox_QRUpload.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_QRUpload.TabIndex = 0;
            pictureBox_QRUpload.TabStop = false;
            pictureBox_QRUpload.Click += pictureBox_QRUpload_Click;
            // 
            // btnShowReceipt
            // 
            btnShowReceipt.Location = new Point(60, 386);
            btnShowReceipt.Name = "btnShowReceipt";
            btnShowReceipt.Size = new Size(250, 47);
            btnShowReceipt.TabIndex = 1;
            btnShowReceipt.Text = "Show Receipt";
            btnShowReceipt.UseVisualStyleBackColor = true;
            btnShowReceipt.Click += btnShowReceipt_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 580);
            Controls.Add(pictureBox_QRUpload);
            Controls.Add(btnShowReceipt);
            Name = "Form2";
            Text = "QR Upload - Laundry System";
            ((ISupportInitialize)pictureBox_QRUpload).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}   