namespace Clinic2018
{
    partial class clinic_barcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clinic_barcode));
            this.T_barcode = new System.Windows.Forms.TextBox();
            this.T_qrcode = new System.Windows.Forms.TextBox();
            this.B_barcode = new System.Windows.Forms.Button();
            this.B_qrcode = new System.Windows.Forms.Button();
            this.Picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // T_barcode
            // 
            this.T_barcode.Location = new System.Drawing.Point(12, 264);
            this.T_barcode.Name = "T_barcode";
            this.T_barcode.Size = new System.Drawing.Size(312, 20);
            this.T_barcode.TabIndex = 1;
            // 
            // T_qrcode
            // 
            this.T_qrcode.Location = new System.Drawing.Point(12, 300);
            this.T_qrcode.Name = "T_qrcode";
            this.T_qrcode.Size = new System.Drawing.Size(312, 20);
            this.T_qrcode.TabIndex = 2;
            // 
            // B_barcode
            // 
            this.B_barcode.Location = new System.Drawing.Point(352, 264);
            this.B_barcode.Name = "B_barcode";
            this.B_barcode.Size = new System.Drawing.Size(99, 23);
            this.B_barcode.TabIndex = 3;
            this.B_barcode.Text = "Barcode";
            this.B_barcode.UseVisualStyleBackColor = true;
            this.B_barcode.Click += new System.EventHandler(this.B_barcode_Click);
            // 
            // B_qrcode
            // 
            this.B_qrcode.Location = new System.Drawing.Point(352, 297);
            this.B_qrcode.Name = "B_qrcode";
            this.B_qrcode.Size = new System.Drawing.Size(99, 23);
            this.B_qrcode.TabIndex = 4;
            this.B_qrcode.Text = "QrCode";
            this.B_qrcode.UseVisualStyleBackColor = true;
            this.B_qrcode.Click += new System.EventHandler(this.B_qrcode_Click);
            // 
            // Picbox
            // 
            this.Picbox.BackColor = System.Drawing.SystemColors.Window;
            this.Picbox.Location = new System.Drawing.Point(12, 12);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(436, 246);
            this.Picbox.TabIndex = 5;
            this.Picbox.TabStop = false;
            // 
            // clinic_barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 335);
            this.Controls.Add(this.Picbox);
            this.Controls.Add(this.B_qrcode);
            this.Controls.Add(this.B_barcode);
            this.Controls.Add(this.T_qrcode);
            this.Controls.Add(this.T_barcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clinic_barcode";
            this.Text = "clinic_barcode";
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox T_barcode;
        private System.Windows.Forms.TextBox T_qrcode;
        private System.Windows.Forms.Button B_barcode;
        private System.Windows.Forms.Button B_qrcode;
        private System.Windows.Forms.PictureBox Picbox;
    }
}