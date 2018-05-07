using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic2018
{
    public partial class clinic_medicine_main : Form
    {
        public clinic_medicine_main()
        {
            InitializeComponent();
        }

        private void p1_Click(object sender, EventArgs e)
        {
            p22.Visible = false;
            p33.Visible = false;
            p44.Visible = false;
            p55.Visible = false;
        }

        private void p2_Click(object sender, EventArgs e)
        {
            p22.Visible = true;
            p33.Visible = false;
            p44.Visible = false;
            p55.Visible = false;
        }

        private void p3_Click(object sender, EventArgs e)
        {
            p33.Visible = true;
            p22.Visible = false;
            p44.Visible = false;
            p55.Visible = false;
        }

        private void p5_Click(object sender, EventArgs e)
        {
            p44.Visible = true;
            p22.Visible = false;
            p33.Visible = false;
            p55.Visible = false;
        }

        private void p6_Click(object sender, EventArgs e)
        {
            p55.Visible = true;
            p22.Visible = false;
            p33.Visible = false;
            p44.Visible = false;

        }



        Timer t = new Timer();

        private void clinic_medicine_main_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();


            label2.Text = DateTime.Now.ToString("dddd d MMMM yyyy", new CultureInfo("th-TH"));

        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            String time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label3.Text = time;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
