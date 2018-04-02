using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic2018
{
    public partial class clinic_insert_employee2 : Form
    {
        public clinic_insert_employee2()
        {
            InitializeComponent();
        }

        private void clinic_insert_employee2_Load(object sender, EventArgs e)
        {
           
        }

        internal string Setlabel1
        {
            set { label1.Text = value; }
        }

        internal string Setlabel2
        {
            set { label2.Text = value; }
        }

        internal string Setlabel3
        {
            set { label3.Text = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
