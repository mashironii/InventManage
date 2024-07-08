namespace InventManage
{
    partial class InventoryIn_Form
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
            System.Windows.Forms.Label DishIngLbl;
            System.Windows.Forms.Label label1;
            this.IngredientGridView = new System.Windows.Forms.DataGridView();
            this.Ingredient_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblIngredientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Quantity_Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateAddedPicker = new System.Windows.Forms.DateTimePicker();
            this.SupplierCombo = new System.Windows.Forms.ComboBox();
            this.tblSupplierBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invTablesDatabaseDataSet = new InventManage.InvTablesDatabaseDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.AddInvenBtn = new System.Windows.Forms.Button();
            this.tblSupplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSupplierTableAdapter = new InventManage.InvTablesDatabaseDataSetTableAdapters.tblSupplierTableAdapter();
            DishIngLbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DishIngLbl
            // 
            DishIngLbl.AutoSize = true;
            DishIngLbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DishIngLbl.Location = new System.Drawing.Point(24, 75);
            DishIngLbl.Name = "DishIngLbl";
            DishIngLbl.Size = new System.Drawing.Size(100, 31);
            DishIngLbl.TabIndex = 29;
            DishIngLbl.Text = "Supplier:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(58, 124);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 31);
            label1.TabIndex = 31;
            label1.Text = "Date:";
            // 
            // IngredientGridView
            // 
            this.IngredientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient_Name,
            this.Quantity_Add});
            this.IngredientGridView.Location = new System.Drawing.Point(6, 0);
            this.IngredientGridView.Name = "IngredientGridView";
            this.IngredientGridView.Size = new System.Drawing.Size(410, 433);
            this.IngredientGridView.TabIndex = 0;
            // 
            // Ingredient_Name
            // 
            this.Ingredient_Name.DataSource = this.tblIngredientsBindingSource2;
            this.Ingredient_Name.HeaderText = "Ingredient Name";
            this.Ingredient_Name.Name = "Ingredient_Name";
            this.Ingredient_Name.Width = 265;
            // 
            // tblIngredientsBindingSource2
            // 
            this.tblIngredientsBindingSource2.DataMember = "tblIngredients";
            // 
            // Quantity_Add
            // 
            this.Quantity_Add.HeaderText = "Quantity (Kg/L)";
            this.Quantity_Add.Name = "Quantity_Add";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.dateAddedPicker);
            this.panel1.Controls.Add(DishIngLbl);
            this.panel1.Controls.Add(this.SupplierCombo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddInvenBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 172);
            this.panel1.TabIndex = 1;
            // 
            // dateAddedPicker
            // 
            this.dateAddedPicker.CustomFormat = "yyyy-mm-dd";
            this.dateAddedPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAddedPicker.Location = new System.Drawing.Point(163, 129);
            this.dateAddedPicker.Name = "dateAddedPicker";
            this.dateAddedPicker.Size = new System.Drawing.Size(205, 26);
            this.dateAddedPicker.TabIndex = 30;
            // 
            // SupplierCombo
            // 
            this.SupplierCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblSupplierBindingSource2, "Supplier_Name", true));
            this.SupplierCombo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCombo.FormattingEnabled = true;
            this.SupplierCombo.Location = new System.Drawing.Point(130, 77);
            this.SupplierCombo.Name = "SupplierCombo";
            this.SupplierCombo.Size = new System.Drawing.Size(238, 33);
            this.SupplierCombo.TabIndex = 28;
            // 
            // tblSupplierBindingSource2
            // 
            this.tblSupplierBindingSource2.DataMember = "tblSupplier";
            this.tblSupplierBindingSource2.DataSource = this.invTablesDatabaseDataSet;
            // 
            // invTablesDatabaseDataSet
            // 
            this.invTablesDatabaseDataSet.DataSetName = "InvTablesDatabaseDataSet";
            this.invTablesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddInvenBtn
            // 
            this.AddInvenBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInvenBtn.Location = new System.Drawing.Point(12, 21);
            this.AddInvenBtn.Name = "AddInvenBtn";
            this.AddInvenBtn.Size = new System.Drawing.Size(306, 45);
            this.AddInvenBtn.TabIndex = 1;
            this.AddInvenBtn.Text = "Add to Inventory";
            this.AddInvenBtn.UseVisualStyleBackColor = true;
            this.AddInvenBtn.Click += new System.EventHandler(this.AddInvenBtn_Click);
            // 
            // tblSupplierBindingSource1
            // 
            this.tblSupplierBindingSource1.DataMember = "tblSupplier";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IngredientGridView);
            this.panel2.Location = new System.Drawing.Point(2, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 447);
            this.panel2.TabIndex = 2;
            // 
            // tblIngredientsBindingSource
            // 
            this.tblIngredientsBindingSource.DataMember = "tblIngredients";
            // 
            // tblIngredientsBindingSource1
            // 
            this.tblIngredientsBindingSource1.DataMember = "tblIngredients";
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tblSupplier";
            // 
            // tblSupplierTableAdapter
            // 
            this.tblSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryIn_Form";
            this.Load += new System.EventHandler(this.InventoryIn_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngredientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IngredientGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddInvenBtn;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource1;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource2;
        private System.Windows.Forms.ComboBox SupplierCombo;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource1;
        private System.Windows.Forms.DateTimePicker dateAddedPicker;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ingredient_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Add;
        private InvTablesDatabaseDataSet invTablesDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource2;
        private InvTablesDatabaseDataSetTableAdapters.tblSupplierTableAdapter tblSupplierTableAdapter;
    }
}