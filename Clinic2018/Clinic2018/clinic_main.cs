﻿using System;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clinic_test_1  cs = new clinic_test_1();
            cs.Show();
        }

        private void L_name_Click(object sender, EventArgs e)
        {
            
        }

        private void ll1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clinic_search search = new clinic_search();
            search.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clinic_search search = new clinic_search();
            search.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            clinic_login log = new clinic_login();
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clinc_nurse_service nurse= new clinc_nurse_service();
            nurse.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clinic_doctor_service docter= new clinic_doctor_service();
            docter.Show();
        }
    }
}
