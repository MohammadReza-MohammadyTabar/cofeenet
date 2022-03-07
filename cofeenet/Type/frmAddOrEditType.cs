using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using DataLayer.Context;
using Datalayer.Repository;
using DataLayer;

namespace cofeenet
{
    public partial class frmAddOrEditType : Form
    {
        public int typeID = 0;
        
        UnitOfWork db = new UnitOfWork();

        public frmAddOrEditType()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                type type = new type()
                {
                    typename = txtTypeName.Text
                };
                if (typeID == 0)
                {
                    
                        db.TypeRepository.InsertType(type);
                    
                }
                else
                {
                    type.typeid = typeID;
                    
                        db.TypeRepository.UpdateType(type);
                    
                }
                db.Save();
                DialogResult = DialogResult.OK;
                
            }
        }

        private void frmAddOrEditType_Load(object sender, EventArgs e)
        {
            if (typeID != 0)
            {
                this.Text = "ویرایش";
                btnSave.Text = "ویرایش";
                var type = db.TypeRepository.GetTypebyId(typeID);
                txtTypeName.Text = type.typename;
            }
        }
    }
}
