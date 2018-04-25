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

        private void clinic_doctor_service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.queue_visit_record' table. You can move, or remove it, as needed.
            this.queue_visit_recordTableAdapter.Fill(this.dataSet3.queue_visit_record);

        }
    }
}
