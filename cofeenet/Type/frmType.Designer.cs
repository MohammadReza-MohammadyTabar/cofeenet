
namespace cofeenet
{
    partial class frmType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.dgType = new System.Windows.Forms.DataGridView();
            this.typeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newType = new System.Windows.Forms.ToolStripButton();
            this.deleteType = new System.Windows.Forms.ToolStripButton();
            this.editType = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgType)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newType,
            this.deleteType,
            this.editType,
            this.toolStripButton4,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 59);
            this.toolStripLabel1.Text = "جستوجو:";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 62);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgType
            // 
            this.dgType.AllowUserToAddRows = false;
            this.dgType.AllowUserToDeleteRows = false;
            this.dgType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeId,
            this.typename});
            this.dgType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgType.Location = new System.Drawing.Point(0, 62);
            this.dgType.Name = "dgType";
            this.dgType.ReadOnly = true;
            this.dgType.Size = new System.Drawing.Size(800, 388);
            this.dgType.TabIndex = 1;
            // 
            // typeId
            // 
            this.typeId.DataPropertyName = "typeid";
            this.typeId.HeaderText = "Column1";
            this.typeId.Name = "typeId";
            this.typeId.ReadOnly = true;
            this.typeId.Visible = false;
            // 
            // typename
            // 
            this.typename.DataPropertyName = "typename";
            this.typename.HeaderText = "نام خدمت";
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            // 
            // newType
            // 
            this.newType.Image = global::cofeenet.Properties.Resources._1371475930_filenew;
            this.newType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(44, 59);
            this.newType.Text = "ایجاد";
            this.newType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newType.Click += new System.EventHandler(this.newType_Click);
            // 
            // deleteType
            // 
            this.deleteType.Image = global::cofeenet.Properties.Resources._1371476007_Close_Box_Red;
            this.deleteType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteType.Name = "deleteType";
            this.deleteType.Size = new System.Drawing.Size(44, 59);
            this.deleteType.Text = "حذف";
            this.deleteType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteType.Click += new System.EventHandler(this.deleteType_Click);
            // 
            // editType
            // 
            this.editType.Image = global::cofeenet.Properties.Resources._1371475973_document_edit;
            this.editType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editType.Name = "editType";
            this.editType.Size = new System.Drawing.Size(44, 59);
            this.editType.Text = "تغییر";
            this.editType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editType.Click += new System.EventHandler(this.editType_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::cofeenet.Properties.Resources._1371476342_Refresh;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 59);
            this.toolStripButton4.Text = "بروزرسانی";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // frmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgType);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نوع خدمات";
            this.Load += new System.EventHandler(this.frmType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newType;
        private System.Windows.Forms.ToolStripButton deleteType;
        private System.Windows.Forms.ToolStripButton editType;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.DataGridView dgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
    }
}