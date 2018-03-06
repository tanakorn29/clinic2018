using System;
using System.Windows.Forms;
//-----------------------------------
using System.Data.SqlClient;
using System.Drawing;
using System.ComponentModel;
using System.Data;

namespace Clinic2018
{
    public partial class clinic_insert : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        
        public clinic_insert()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void patient_id_TextChanged(object sender, KeyPressEventArgs e)
        {
            patient_id.MaxLength = 13;
            if (patient_id.Text ==  )
            {
                label6.ForeColor = Color.Green;
                label6.Text = "ครบ 13 หลัก";
            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Text = "ไม่ครบ 13 หลัก";
            }
        }*/

        private bool IsNumeric(string text)
        {
            throw new NotImplementedException();
        }

        private void patient_id_Validated(object sender, CancelEventArgs  e)
        {
            patient_id.MaxLength = 13;
            ErrorProvider ep = new ErrorProvider();

            if (string.IsNullOrEmpty(patient_id.Text))
            {
                e.Cancel = true;
                patient_id.Focus();
                ep.SetError(patient_id, " Please enter your user name");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(patient_id, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertquery = "insert into patient(patient_id, patient_name, patient_birthday) values('" +
                patient_id.Text + "', '" + patient_name.Text + "', '" + dateTimePicker1.Text + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertquery, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //แสดงข้อความแทน
                    label6.ForeColor = Color.Green;
                    label6.Text = "ครบ 13 หลัก";

                    //แสดงป็อปอัพข้อความแทน
                    //MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        //เลือกวัน เดือน ปีเกิด แสดงอายุ
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan tspan = to - from;
            double days = tspan.TotalDays;
            label5.Text = (days / 365).ToString("0");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 13;
            if (char.IsNumber(e.KeyChar)||e.KeyChar=='-')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            /*conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select province_name from provinces" ,conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["province_name"].ToString());
            }

            conn.Close();*/


        }

        private void button4_Click(object sender, EventArgs e)
        {
        }


        /*public void Regexp(string re, TextBox tb, PictureBox pc, Label lbel, string s)
        {
            //patient_id.MaxLength = 13;
            Regex reger = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.valid;
                lbel.ForeColor = Color.Red;
                lbel.Text = s + " InValid";
            }
            else
            {
                pc.Image = Properties.Resources.valid;
                lbel.ForeColor = Color.Green;
                lbel.Text = s + " Valid";
            }*/

    }   
}
