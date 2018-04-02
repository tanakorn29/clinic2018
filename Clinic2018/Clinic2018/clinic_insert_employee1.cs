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
    public partial class clinic_insert_employee1 : Form
    {
        public clinic_insert_employee1()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111 ");
        private void button1_Click(object sender, EventArgs e)
        {
            string insertquery = "insert into employee_doctor(emp_doc_name, emp_doc_idcard, emp_doc_birth, emp_doc_address, emp_doc_tel, emp_doc_email, emp_doc_occupation_id, emp_doc_specialist) values('"+tb1.Text+"', '"+tb2.Text+"', '"+dateTimePicker1.Value.Date+"', '"+tb3.Text+"', '"+tb4.Text+"', '"+tb5.Text+"', '"+tb6.Text+"', '"+tb7.Text+"')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertquery, conn);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("เพิ่มข้อมูลแล้ว");
                }
                else
                {
                    MessageBox.Show("ไม่สำเร็จ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            
            
            /*clinic_insert_employee2 c2 = new clinic_insert_employee2();
            c2.Setlabel1 = textBox2.Text;
            c2.Setlabel2 = textBox1.Text;
            c2.Setlabel3 = textBox3.Text;
            c2.Show();*/
            
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /*private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }*/
    }
}
