namespace Clinic2018
{
    partial class clinic_notification
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
            this.B_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_show
            // 
            this.B_show.Location = new System.Drawing.Point(96, 107);
            this.B_show.Name = "B_show";
            this.B_show.Size = new System.Drawing.Size(89, 28);
            this.B_show.TabIndex = 0;
            this.B_show.Text = "Show";
            this.B_show.UseVisualStyleBackColor = true;
            this.B_show.Click += new System.EventHandler(this.B_show_Click);
            // 
            // Clinic_notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.B_show);
            this.Name = "Clinic_notification";
            this.Text = "Clinic_notification";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_show;
    }
}