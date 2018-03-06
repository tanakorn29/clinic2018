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
    public partial class clinic_barcode : Form
    {
        public clinic_barcode()
        {
            InitializeComponent();
        }

        private void B_barcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Picbox.Image = barcode.Draw(T_barcode.Text, 100);
        }

        private void B_qrcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Picbox.Image = qr.Draw(T_qrcode.Text, 100);
        }
    }
}
