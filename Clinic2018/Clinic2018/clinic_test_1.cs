using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic2018
{
    public partial class clinic_test_1 : Form
    {
        public clinic_test_1()
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

        //สร้างไว้ข้างนอก เพื่องานต่อการเรียกใช้ในส่วนอื่นๆ
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ในช่องค้นหา ใช้ Event ชื่อว่า TextChanged เมื่อช่องค้นหามีการเปลี่ยนแปลง ข้อความจะถูกเปลี่ยน
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string query = "select patient.patient_idcard as 'บัตรประชาชน', patient.patient_name as 'ชื่อ/สกุล', patient.patient_birthday as 'วัน เดือน ปีเกิด', patient.patient_telmobile as 'เบอร์โทรศัพท์',user_control.uct_user as 'UserName', user_control.uct_password as 'PassWord' from patient inner join user_control on patient.patient_idcard = user_control.patient_idcard where patient.patient_idcard='" + textBox1.Text + "'";
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            Show_text st = new Show_text();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
