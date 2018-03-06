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
using System.Data.SqlTypes;
using System.Data.Sql;


namespace Clinic2018
{
    public partial class clinic_main : Form
    {
        public clinic_main()
        {
            InitializeComponent();
        }
        
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
            SqlDataAdapter sda = new SqlDataAdapter("select * form login where username= '" + T_Username.Text + "' and password= '" + T_Password.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //สำรอง2
            /*SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.Odbc.SqlDataAdapter adapter1 = new System.Data.Odbc.SqlDataAdapter("select * form login where username= '" + T_Username.Text + "' and password= '" + T_Password.Text + "'", conn);
            adapter1.Fill(ds);
            DataTable dt = ds.Tables[0];*/

            if (dt.Rows.Count == 1)
            {
                clinic_main_v2 c1 = new clinic_main_v2();
                c1.Show();
            }
            else
            {
                MessageBox.Show("ตรวจสอบข้อมูลอีกครั้ง");
            }

        }
    }
}
