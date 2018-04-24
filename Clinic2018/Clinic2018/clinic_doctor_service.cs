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
    public partial class clinic_doctor_service : Form
    {
        public clinic_doctor_service()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clinic_appointment app = new clinic_appointment();
            app.Show();
        }
    }
}
