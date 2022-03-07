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

namespace cofeenet
{
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        private void frmType_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
       public void BindGrid()
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                dgType.AutoGenerateColumns = false;
                dgType.DataSource = db.TypeRepository.GetAllType();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                
                dgType.DataSource = db.TypeRepository.GetTypesByFilter(txtFilter.Text);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void deleteType_Click(object sender, EventArgs e)
        {
            if (dgType.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgType.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف|{name}مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int typeid = int.Parse(dgType.CurrentRow.Cells[0].Value.ToString());
                        db.TypeRepository.DeletebyType(typeid);
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

        private void newType_Click(object sender, EventArgs e)
        {
            frmAddOrEditType frmAddOrEditType = new frmAddOrEditType();
            if (frmAddOrEditType.ShowDialog(this) == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void editType_Click(object sender, EventArgs e)
        {
            if (dgType.CurrentRow != null)
            {
                int typeID = int.Parse(dgType.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditType frmAddOrEditType = new frmAddOrEditType();
                frmAddOrEditType.typeID = typeID;
                if (frmAddOrEditType.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }
    }
}
