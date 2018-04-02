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
