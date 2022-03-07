using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cofeenet
{
    public partial class cofeenet_main : Form
    {
        public cofeenet_main()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmtype_Click(object sender, EventArgs e)
        {
            frmType frmType = new frmType();
            frmType.ShowDialog();
        }

        private void frmPaymentmethod_Click(object sender, EventArgs e)
        {
            Paymentmethods.frmPaymentmethods frmPaymentmethods = new Paymentmethods.frmPaymentmethods();
            frmPaymentmethods.ShowDialog();
        }
    }
}
