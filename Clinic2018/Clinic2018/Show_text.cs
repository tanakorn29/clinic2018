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
    public partial class Show_text : Form
    {
        public Show_text()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        internal string Setlabel
        {
            set { label1.Text = "ค่าที่ได้รับ :" + " "+ value; }
       
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
