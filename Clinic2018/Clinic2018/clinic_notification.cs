using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using WebCamCapture;

namespace Clinic2018
{
    public partial class clinic_notification : Form
    {
        public clinic_notification()
        {
            InitializeComponent();
        }

        private void B_show_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Show Message";
            popup.ContentText = "Medical and Health Care Management System";
            popup.Popup();
        }
    }
}
