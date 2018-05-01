using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic2018
{
    public partial class clinic_111 : Form
    {
        public clinic_111()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clinic_222 c2 = new clinic_222();
            c2.Show();
        }
    }
}
