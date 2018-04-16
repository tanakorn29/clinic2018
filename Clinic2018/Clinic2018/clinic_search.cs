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
    public partial class clinic_search : Form
    {
        public clinic_search()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "บัตรประชาชน")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "บัตรประชาชน";

                textBox1.ForeColor = Color.Silver;
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 13;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string query = ("select * from employee_ru eru, opd, privilege where eru.emp_ru_idcard = opd.emp_ru_id and opd.emp_ru_id = privilege.emp_ru_idcard and eru.emp_ru_idcard = '" + textBox1.Text + "'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            //------------------------------ปิงปอง--------------------------------------
            //if (textBox1.Text == cmd.Connection.Database && textBox1.MaxLength == 13)
            //{
            foreach (DataRow item in dt.Rows)
                 {
                     int n = dataGridView1.Rows.Add();
                     dataGridView1.Rows[n].Cells[0].Value = item["emp_ru_idcard"].ToString();
                     dataGridView1.Rows[n].Cells[1].Value = item["emp_ru_name"].ToString();
                     dataGridView1.Rows[n].Cells[2].Value = item["emp_ru_birthday"].ToString();
                     dataGridView1.Rows[n].Cells[3].Value = item["emp_ru_telmobile"].ToString();
                     dataGridView1.Rows[n].Cells[4].Value = item["privil_status"].ToString();
                 }
             //}
            /*if (textBox1.Text != cmd.Connection.Database && textBox1.MaxLength == 13)
            {
                 clinic_approve cliapp = new clinic_approve();
                 cliapp.Show();
            }*/
            //------------------------------ปิงปอง--------------------------------------


            //------------------------------ไม่ได้ใช้ เก็บไว้ --------------------------------------
            /*select eru.emp_ru_idcard, eru.emp_ru_name, privilege.privil_status
            from employee_ru eru
            inner join opd on eru.emp_ru_idcard = opd.emp_ru_id
            inner join privilege on opd.emp_ru_id = privilege.emp_ru_idcard

            select eru.emp_ru_idcard, eru.emp_ru_name, privilege.privil_status 
            from employee_ru eru, opd, privilege
            where eru.emp_ru_idcard = opd.emp_ru_id
            and opd.emp_ru_id = privilege.emp_ru_idcard
            and eru.emp_ru_idcard = '1859900128488'*/
            //------------------------------ไม่ได้ใช้ เก็บไว้ --------------------------------------

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //------------------------------ไม่ได้ใช้ เก็บไว้ --------------------------------------
            /*if (textBox1.MaxLength == null)
            {
                textBox1.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
            else
            {
                clinic_approve cliapp = new clinic_approve();
                cliapp.Close();
            }*/
            //------------------------------ไม่ได้ใช้ เก็บไว้ --------------------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string query = ("update queue_visit_record set opd_idcard = '"+ dt DataGridTextBoxColumn + "'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);*/
        }

        int selectedRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
    }
}




