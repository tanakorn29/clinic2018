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

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            tb1.MaxLength = 13;

            //clear label เมื่อ tb1 เปลี่ยนการค้นหา
            S1.Text = "";
            S2.Text = "";
            S3.Text = "";
            S4.Text = "";
            S5.Text = "";
            S6.Text = "";

            conn.Open();

            string query = ("select eru.emp_ru_idcard, emp_ru_name, emp_ru_birthday, emp_ru_telmobile, pos_name, privil_status from employee_ru eru left join position pos on pos.pos_id = eru.pos_id left join privilege pivi on pivi.emp_ru_idcard = eru.emp_ru_idcard where eru.emp_ru_idcard = '" + tb1.Text + "'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                S1.Text = (sdr["emp_ru_idcard"].ToString());
                S2.Text = (sdr["emp_ru_name"].ToString());
                S3.Text = (sdr["emp_ru_birthday"].ToString());
                S4.Text = (sdr["emp_ru_telmobile"].ToString());
                S5.Text = (sdr["pos_name"].ToString());
                S6.Text = (sdr["privil_status"].ToString());
            }
            /*else if (this.sdr.GetSqlString3)
            {
                S1.Text = (sdr["emp_ru_idcard"].ToString());
                S2.Text = (sdr["emp_ru_name"].ToString());
                S3.Text = (sdr["emp_ru_birthday"].ToString());
                S4.Text = (sdr["emp_ru_telmobile"].ToString());
                S5.Text = (sdr["pos_name"].ToString());
                S6.Text = "ไม่อนุญาต";
            }*/

            conn.Close();

            //textBox2.Clear();
            //Select DATE_FORMAT(DATE_ADD(BirthDate, INTERVAL 543 YEAR), '%d/%m/%Y') AS BirthDate From tblolder
        }

        private void tb1_Enter(object sender, EventArgs e)
        {
            if (tb1.Text == "บัตรประชาชน")
            {
                tb1.Text = "";

                tb1.ForeColor = Color.Black;
            }
        }

        private void tb1_Leave(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                tb1.Text = "บัตรประชาชน";

                tb1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clinic_approve_step2 appr2 = new clinic_approve_step2();
            appr2.Show();
        }

        private void tb1_MouseClick(object sender, MouseEventArgs e)
        {
            tb1.Clear();
        }
    }
}

