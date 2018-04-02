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
    public partial class clinic_approve : Form
    {
        public clinic_approve()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        SqlDataReader sdr;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //clear label เมื่อ textbox2 เปลี่ยนการค้นหา
            S1.Text = "";
            S2.Text = "";
            S3.Text = "";
            S4.Text = "";

            conn.Open();
            //string query = ("select * from patient where patient_idcard=" + int.Parse(textBox2.Text));
            string query = ("select * from employee_ru where emp_ru_idcard='" + textBox2.Text+"'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            sdr = cmd.ExecuteReader();

            //Select DATE_FORMAT(DATE_ADD(BirthDate, INTERVAL 543 YEAR), '%d/%m/%Y') AS BirthDate From tblolder
            
            if(sdr.Read())
            {
                S1.Text = (sdr["emp_ru_idcard"].ToString());
                S2.Text = (sdr["emp_ru_name"].ToString());
                S3.Text = (sdr["emp_ru_birthday"].ToString());
                S4.Text = (sdr["emp_ru_telmobile"].ToString());
                //S5.Text = (sdr["emp_ru_telmobile"].ToString());
                S6.Text = (sdr["emp_ru_status"].ToString());
            }
            /*else
            {
               MessageBox.Show("ไม่พบข้อมูล");
            }*/
            conn.Close();

            //textBox2.Clear();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "บัตรประชาชน")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "บัตรประชาชน";

                textBox2.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clinic_approve_step2 appr2 = new clinic_approve_step2();
            appr2.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }
    }
}

