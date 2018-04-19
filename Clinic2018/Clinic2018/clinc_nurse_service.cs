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
    public partial class clinc_nurse_service : Form
    {
        public clinc_nurse_service()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = ("select * from employee_ru eru, opd, privilege where eru.emp_ru_idcard = opd.emp_ru_id and opd.emp_ru_id = privilege.emp_ru_idcard and eru.emp_ru_idcard = '" + textBox1.Text + "'");
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["emp_ru_idcard"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["emp_ru_name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["emp_ru_birthday"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["emp_ru_telmobile"].ToString();
            }
        }

        private void clinc_nurse_service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.queue_visit_record' table. You can move, or remove it, as needed.
            this.queue_visit_recordTableAdapter.Fill(this.dataSet2.queue_visit_record);

        }
    }
}
