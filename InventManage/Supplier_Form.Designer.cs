namespace InventManage
{
    partial class Supplier_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.expandbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.addSuppbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newSuppNametxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.supptxtbx = new System.Windows.Forms.TextBox();
            this.supplbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Supplier_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSupplierBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.invTablesDatabaseDataSet = new InventManage.InvTablesDatabaseDataSet();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // expandbtn
            // 
            this.expandbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.expandbtn.Location = new System.Drawing.Point(440, 16);
            this.expandbtn.Name = "expandbtn";
            this.expandbtn.Size = new System.Drawing.Size(48, 54);
            this.expandbtn.TabIndex = 6;
            this.expandbtn.Text = "V";
            this.expandbtn.UseVisualStyleBackColor = true;
            this.expandbtn.Click += new System.EventHandler(this.expandbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.backbtn.Location = new System.Drawing.Point(271, 16);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(154, 54);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addSuppbtn
            // 
            this.addSuppbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.addSuppbtn.Location = new System.Drawing.Point(12, 16);
            this.addSuppbtn.Name = "addSuppbtn";
            this.addSuppbtn.Size = new System.Drawing.Size(244, 54);
            this.addSuppbtn.TabIndex = 4;
            this.addSuppbtn.Text = "Add Supplier";
            this.addSuppbtn.UseVisualStyleBackColor = true;
            this.addSuppbtn.Click += new System.EventHandler(this.addSuppbtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 456);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newSuppNametxtbx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.delbtn);
            this.panel1.Controls.Add(this.supptxtbx);
            this.panel1.Controls.Add(this.supplbl);
            this.panel1.Controls.Add(this.addSuppbtn);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.expandbtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 70);
            this.panel1.TabIndex = 8;
            // 
            // newSuppNametxtbx
            // 
            this.newSuppNametxtbx.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.newSuppNametxtbx.Location = new System.Drawing.Point(181, 188);
            this.newSuppNametxtbx.Name = "newSuppNametxtbx";
            this.newSuppNametxtbx.Size = new System.Drawing.Size(244, 29);
            this.newSuppNametxtbx.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label1.Location = new System.Drawing.Point(50, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Name:";
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.updatebtn.Location = new System.Drawing.Point(102, 76);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(154, 54);
            this.updatebtn.TabIndex = 13;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.delbtn.Location = new System.Drawing.Point(271, 76);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(154, 54);
            this.delbtn.TabIndex = 12;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // supptxtbx
            // 
            this.supptxtbx.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.supptxtbx.Location = new System.Drawing.Point(181, 153);
            this.supptxtbx.Name = "supptxtbx";
            this.supptxtbx.Size = new System.Drawing.Size(244, 29);
            this.supptxtbx.TabIndex = 10;
            this.supptxtbx.TextChanged += new System.EventHandler(this.supptxtbx_TextChanged);
            // 
            // supplbl
            // 
            this.supplbl.AutoSize = true;
            this.supplbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.supplbl.Location = new System.Drawing.Point(50, 156);
            this.supplbl.Name = "supplbl";
            this.supplbl.Size = new System.Drawing.Size(133, 25);
            this.supplbl.TabIndex = 9;
            this.supplbl.Text = "Supplier Name:";
            this.supplbl.Click += new System.EventHandler(this.supplbl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supplier_Id,
            this.supplierNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSupplierBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 250);
            this.dataGridView1.TabIndex = 9;
            // 
            // Supplier_Id
            // 
            this.Supplier_Id.DataPropertyName = "Supplier_Id";
            this.Supplier_Id.HeaderText = "Supplier_Id";
            this.Supplier_Id.Name = "Supplier_Id";
            this.Supplier_Id.ReadOnly = true;
            this.Supplier_Id.Width = 150;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier_Name";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // tblSupplierBindingSource4
            // 
            this.tblSupplierBindingSource4.DataMember = "tblSupplier";
            this.tblSupplierBindingSource4.DataSource = this.invTablesDatabaseDataSet;
            // 
            // invTablesDatabaseDataSet
            // 
            this.invTablesDatabaseDataSet.DataSetName = "InvTablesDatabaseDataSet";
            this.invTablesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Supplier_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 522);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Supplier_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Form";
            this.Load += new System.EventHandler(this.Supplier_Form_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button expandbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addSuppbtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox supptxtbx;
        private System.Windows.Forms.Label supplbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private InvTablesDatabaseDataSet invTablesDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource4;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.TextBox newSuppNametxtbx;
        private System.Windows.Forms.Label label1;
    }
}
