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

            string query = ("select * from patient where patient_idcard='" + textBox1.Text + "'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["patient_idcard"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["patient_name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["patient_birthday"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["patient_telmobile"].ToString();
            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
    }
}
