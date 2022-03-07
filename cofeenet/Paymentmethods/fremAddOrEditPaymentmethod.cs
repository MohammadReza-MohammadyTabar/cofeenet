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
using ValidationComponents;
using Datalayer.Repository;

using DataLayer;
namespace cofeenet.Paymentmethods
{
    public partial class fremAddOrEditPaymentmethod : Form
    {
        public int payID = 0;

        UnitOfWork db = new UnitOfWork();
        public fremAddOrEditPaymentmethod()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                paymentmethode paymentmethode = new paymentmethode()
                {
                    paymentmethode1 = textBox1.Text
                };
                if (payID == 0)
                {

                db.PaymentmethodeRepository.InsertPaymentmethode(paymentmethode);

                }
                else
                {
                    paymentmethode.paymentmethodeid= payID;

                    db.PaymentmethodeRepository.UpdatePaymentmethodel(paymentmethode);

                }
                db.Save();
                DialogResult = DialogResult.OK;

            }
        }

        private void fremAddOrEditPaymentmethod_Load(object sender, EventArgs e)
        {
            if (payID != 0)
            {
                this.Text = "ویرایش";
                btnSave.Text = "ویرایش";
                var pay = db.PaymentmethodeRepository.GetPaymentmethodebyId(payID);
                textBox1.Text = pay.paymentmethode1;
            }
        }
    }
}
