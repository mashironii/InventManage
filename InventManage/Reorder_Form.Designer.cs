namespace InventManage
{
    partial class Reorder_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.ReorderListBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblIngredientsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.invTablesDatabaseDataSet = new InventManage.InvTablesDatabaseDataSet();
            this.Quantity_Requested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblIngredientsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsTableAdapter1 = new InventManage.InvTablesDatabaseDataSetTableAdapters.tblIngredientsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Backbtn);
            this.panel1.Controls.Add(this.ReorderListBtn);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingredients below MROP:";
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(290, 24);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(111, 45);
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // ReorderListBtn
            // 
            this.ReorderListBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorderListBtn.Location = new System.Drawing.Point(10, 24);
            this.ReorderListBtn.Name = "ReorderListBtn";
            this.ReorderListBtn.Size = new System.Drawing.Size(274, 45);
            this.ReorderListBtn.TabIndex = 2;
            this.ReorderListBtn.Text = "Make Reorder List";
            this.ReorderListBtn.UseVisualStyleBackColor = true;
            this.ReorderListBtn.Click += new System.EventHandler(this.ReorderListBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 225);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // tblIngredientsBindingSource
            // 
            this.tblIngredientsBindingSource.DataMember = "tblIngredients";
            // 
            // tblIngredientsBindingSource1
            // 
            this.tblIngredientsBindingSource1.DataMember = "tblIngredients";
            // 
            // tblIngredientsBindingSource2
            // 
            this.tblIngredientsBindingSource2.DataMember = "tblIngredients";
            // 
            // tblIngredientsBindingSource3
            // 
            this.tblIngredientsBindingSource3.DataMember = "tblIngredients";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(816, 604);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 232);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 32);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manual Order of Ingredients:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(3, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 250);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity_Requested});
            this.dataGridView2.DataSource = this.tblIngredientsBindingSource4;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(806, 241);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // tblIngredientsBindingSource6
            // 
            this.tblIngredientsBindingSource6.DataMember = "tblIngredients";
            this.tblIngredientsBindingSource6.DataSource = this.invTablesDatabaseDataSet;
            // 
            // invTablesDatabaseDataSet
            // 
            this.invTablesDatabaseDataSet.DataSetName = "InvTablesDatabaseDataSet";
            this.invTablesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Quantity_Requested
            // 
            this.Quantity_Requested.DataPropertyName = "Ingredient_Id";
            this.Quantity_Requested.HeaderText = "Quantity_Requested";
            this.Quantity_Requested.Name = "Quantity_Requested";
            this.Quantity_Requested.ReadOnly = true;
            // 
            // tblIngredientsBindingSource4
            // 
            this.tblIngredientsBindingSource4.DataMember = "tblIngredients";
            // 
            // tblIngredientsBindingSource5
            // 
            this.tblIngredientsBindingSource5.DataMember = "tblIngredients";
            // 
            // tblIngredientsTableAdapter1
            // 
            this.tblIngredientsTableAdapter1.ClearBeforeFill = true;
            // 
            // Reorder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 661);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Reorder_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reorder_Form";
            this.Load += new System.EventHandler(this.Reorder_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button ReorderListBtn;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource1;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource3;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource5;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private InvTablesDatabaseDataSet invTablesDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource6;
        private InvTablesDatabaseDataSetTableAdapters.tblIngredientsTableAdapter tblIngredientsTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Requested;
    }
}