using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic2018
{
    public partial class clinic_time_attendance : Form
    {
        Timer t = new Timer();

        public clinic_time_attendance()
        {
            InitializeComponent();
        }

        private void clinic_time_attendance_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();


            label2.Text = DateTime.Now.ToString("dddd d MMMM yyyy", new CultureInfo("th-TH"));
            
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            String time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label1.Text = time;

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            /*string query = ("select emp_ru_name from employee_ru where emp_ru_idcard = '"+tb1.Text+"'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);*/

            //clinic_time_attendance_welcome ctaw = new clinic_time_attendance_welcome;
            //ctaw.Show();
                

            /*กรอก ปชช โชว์ message box
            ยินดีต้อนรับ: ชื่อ สกุล
            เข้าเวลา: ใส่เวลา
            กำหนดเวลา 5วิ หน้าต่างหาย พร้อมบันทึกข้อมูล*/

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string query = ("select emp_ru_name from employee_ru where emp_ru_idcard = '"+tb1.Text+"'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            string rdio = "";

            if(radioButton1.Checked)
            {
                //MessageBox.Show("คุณ "+radioButton1+"แล้วจ้า");

                //rdio = radioButton1.Text;
                //query(emp_ru_idcard)/.ToString();

            }
            if (radioButton2.Checked)
            {

            }
            MessageBox.Show(rdio, query);


        }
    }
}
