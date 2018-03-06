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
    public partial class clinic_main_v2 : Form
    {
        private object set;

        public clinic_main_v2()
        {
            InitializeComponent();
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clinic_barcode newMDIchild = new clinic_barcode();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clinic_test_1 cns = new clinic_test_1();
            cns.Show();
        }

        private void clinic_main_v2_Load(object sender, EventArgs e)
        {
          //  clinic_login lgn = new clinic_login();
          //  lgn.Show();
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
                    MessageBox.Show("ยินดีต้อนรับ" +" "+T_Username.Text);
                    this.menuStrip1.Show();
                    this.toolStrip1.Show();
                    this.panel1.Hide();
                }
                else
                {
                    MessageBox.Show("Check Username and Password agin!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error",MessageBoxButtons.OKCancel);
            }
         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.menuStrip1.Hide();
            this.toolStrip1.Hide();
          //this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clinic_test_1  cs = new clinic_test_1();
            cs.Show();
        }

        private void L_name_Click(object sender, EventArgs e)
        {
            
        }
    }
}
