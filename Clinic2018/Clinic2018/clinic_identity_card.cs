using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic2018
{
    public partial class clinic_identity_card : Form
    {
        
        public clinic_identity_card()
        {
            InitializeComponent();
        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }
        internal string Setlabel
        {
            set { label1.Text = "ค่าที่ได้รับ :" + " " + value; }
        }

        private void clinic_identity_card_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
