using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Context;


namespace cofeenet.Paymentmethods
{
    public partial class frmPaymentmethods : Form
    {
        public frmPaymentmethods()
        {
            InitializeComponent();
        }

        private void frmPaymentmethods_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        public void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //dgPaymentmethods.AutoGenerateColumns = false;
                dgPaymentmethods.DataSource = db.PaymentmethodeRepository.GetAllPaymentmethode();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fremAddOrEditPaymentmethod fremAddOrEditPaymentmethod = new fremAddOrEditPaymentmethod();
            if (fremAddOrEditPaymentmethod.ShowDialog(this) == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPaymentmethods.CurrentRow != null)
            {
                int payID = int.Parse(dgPaymentmethods.CurrentRow.Cells[0].Value.ToString());
                fremAddOrEditPaymentmethod fremAddOrEditPaymentmethod = new fremAddOrEditPaymentmethod();
                fremAddOrEditPaymentmethod.payID = payID;
                if (fremAddOrEditPaymentmethod.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgPaymentmethods.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgPaymentmethods.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف|{name}مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int payid = int.Parse(dgPaymentmethods.CurrentRow.Cells[0].Value.ToString());
                        db.PaymentmethodeRepository.DeletebyId(payid);
                        db.Save();
                        BindGrid();
                    }

                }
            }
            else
            {
                RtlMessageBox.Show("لطفا خطی را انتخاب کنید");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
