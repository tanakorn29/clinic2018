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
    public partial class clinic_login : Form
    {
        public clinic_login()
        {
            InitializeComponent();
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
                SqlCommand cmd = new SqlCommand("select * from user_control where uct_user=@uct_user and uct_password=@uct_password", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@uct_user", T_Username.Text);
                cmd.Parameters.AddWithValue("@uct_password", T_Password.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("ยินดีต้อนรับ" + " " + T_Username.Text);

                    clinic_main_v2 m2 = new clinic_main_v2();
                    m2.Show();
                    clinic_login clnlog = new clinic_login();
                    clnlog.Close();
                    Visible = false;
                }

                else
                {
                    MessageBox.Show("Check Username and Password agin!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OKCancel);
            }
        }
        

        private void T_Username_Enter(object sender, EventArgs e)
        {
            if (T_Username.Text == "Username")
            {
                T_Username.Text = "";

                T_Username.ForeColor = Color.Black;
            }
        }

        private void T_Username_Leave(object sender, EventArgs e)
        {
            if (T_Username.Text == "")
            {
                T_Username.Text = "Username";

                T_Username.ForeColor = Color.Silver;
            }
        }

        private void T_Password_Enter(object sender, EventArgs e)
        {
            if (T_Password.Text == "Password")
            {
                T_Password.Text = "";

                T_Password.ForeColor = Color.Black;
            }
        }

        private void T_Password_Leave(object sender, EventArgs e)
        {
            if (T_Password.Text == "")
            {
                T_Password.Text = "Password";

                T_Password.ForeColor = Color.Silver;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /*private void textBox1_Enter(object sender, EventArgs e)
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
        }*/

    }
}
