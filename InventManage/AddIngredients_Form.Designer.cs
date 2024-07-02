namespace InventManage
{
    partial class AddIngredients_Form
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
            this.label8 = new System.Windows.Forms.Label();
            this.SuppliercomboBox3 = new System.Windows.Forms.ComboBox();
            this.CategorycomboBox2 = new System.Windows.Forms.ComboBox();
            this.UnitcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitCosttextBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MROPtextBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IngNametextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IngredIDtextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expandbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ingredient_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredient_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mROPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblIngredientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.SuppliercomboBox3);
            this.panel1.Controls.Add(this.CategorycomboBox2);
            this.panel1.Controls.Add(this.UnitcomboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.UnitCosttextBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MROPtextBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IngNametextBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.IngredIDtextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.expandbtn);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 84);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kg/Ltr";
            // 
            // SuppliercomboBox3
            // 
            this.SuppliercomboBox3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliercomboBox3.FormattingEnabled = true;
            this.SuppliercomboBox3.Location = new System.Drawing.Point(586, 298);
            this.SuppliercomboBox3.Name = "SuppliercomboBox3";
            this.SuppliercomboBox3.Size = new System.Drawing.Size(238, 33);
            this.SuppliercomboBox3.TabIndex = 20;
            this.SuppliercomboBox3.Text = "Local";
            // 
            // CategorycomboBox2
            // 
            this.CategorycomboBox2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorycomboBox2.FormattingEnabled = true;
            this.CategorycomboBox2.Items.AddRange(new object[] {
            "Vegetables",
            "Dairy & Eggs",
            "Meat and Poultry",
            "Seafood",
            "Dry Goods",
            "Canned Goods",
            "Spices and Seasonings",
            "Sauces and Condiments"});
            this.CategorycomboBox2.Location = new System.Drawing.Point(586, 216);
            this.CategorycomboBox2.Name = "CategorycomboBox2";
            this.CategorycomboBox2.Size = new System.Drawing.Size(238, 33);
            this.CategorycomboBox2.TabIndex = 19;
            this.CategorycomboBox2.Text = "Vegetables";
            // 
            // UnitcomboBox1
            // 
            this.UnitcomboBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitcomboBox1.FormattingEnabled = true;
            this.UnitcomboBox1.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Liter",
            "Milliliter"});
            this.UnitcomboBox1.Location = new System.Drawing.Point(304, 215);
            this.UnitcomboBox1.Name = "UnitcomboBox1";
            this.UnitcomboBox1.Size = new System.Drawing.Size(131, 33);
            this.UnitcomboBox1.TabIndex = 18;
            this.UnitcomboBox1.Text = "Kilogram";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Category:";
            // 
            // UnitCosttextBox5
            // 
            this.UnitCosttextBox5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitCosttextBox5.Location = new System.Drawing.Point(304, 299);
            this.UnitCosttextBox5.Name = "UnitCosttextBox5";
            this.UnitCosttextBox5.Size = new System.Drawing.Size(244, 29);
            this.UnitCosttextBox5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unit Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Unit:";
            // 
            // MROPtextBox3
            // 
            this.MROPtextBox3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MROPtextBox3.Location = new System.Drawing.Point(33, 299);
            this.MROPtextBox3.Name = "MROPtextBox3";
            this.MROPtextBox3.Size = new System.Drawing.Size(142, 29);
            this.MROPtextBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "MROP:";
            // 
            // IngNametextBox2
            // 
            this.IngNametextBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngNametextBox2.Location = new System.Drawing.Point(33, 216);
            this.IngNametextBox2.Name = "IngNametextBox2";
            this.IngNametextBox2.Size = new System.Drawing.Size(244, 29);
            this.IngNametextBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingredient Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngredIDtextBox1
            // 
            this.IngredIDtextBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredIDtextBox1.Location = new System.Drawing.Point(33, 134);
            this.IngredIDtextBox1.Name = "IngredIDtextBox1";
            this.IngredIDtextBox1.Size = new System.Drawing.Size(244, 29);
            this.IngredIDtextBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingredient Name:";
            // 
            // expandbtn
            // 
            this.expandbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandbtn.Location = new System.Drawing.Point(461, 16);
            this.expandbtn.Name = "expandbtn";
            this.expandbtn.Size = new System.Drawing.Size(48, 54);
            this.expandbtn.TabIndex = 3;
            this.expandbtn.Text = "V";
            this.expandbtn.UseVisualStyleBackColor = true;
            this.expandbtn.Click += new System.EventHandler(this.expandbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(292, 16);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(154, 54);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(33, 16);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(244, 54);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add Ingredients";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient_Id,
            this.Ingredient_Name,
            this.mROPDataGridViewTextBoxColumn,
            this.Quantity,
            this.unitDataGridViewTextBoxColumn,
            this.unitcostDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblIngredientsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 340);
            this.dataGridView1.TabIndex = 2;
            // 
            // Ingredient_Id
            // 
            this.Ingredient_Id.DataPropertyName = "Ingredient_Id";
            this.Ingredient_Id.HeaderText = "Ingredient_Id";
            this.Ingredient_Id.Name = "Ingredient_Id";
            this.Ingredient_Id.ReadOnly = true;
            // 
            // Ingredient_Name
            // 
            this.Ingredient_Name.DataPropertyName = "Ingredient_Name";
            this.Ingredient_Name.HeaderText = "Ingredient_Name";
            this.Ingredient_Name.Name = "Ingredient_Name";
            this.Ingredient_Name.Width = 150;
            // 
            // mROPDataGridViewTextBoxColumn
            // 
            this.mROPDataGridViewTextBoxColumn.DataPropertyName = "MROP";
            this.mROPDataGridViewTextBoxColumn.HeaderText = "MROP";
            this.mROPDataGridViewTextBoxColumn.Name = "mROPDataGridViewTextBoxColumn";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // unitcostDataGridViewTextBoxColumn
            // 
            this.unitcostDataGridViewTextBoxColumn.DataPropertyName = "Unit_cost";
            this.unitcostDataGridViewTextBoxColumn.HeaderText = "Unit_cost";
            this.unitcostDataGridViewTextBoxColumn.Name = "unitcostDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // tblIngredientsBindingSource2
            // 
            this.tblIngredientsBindingSource2.DataMember = "tblIngredients";
            // 
            // dishesDataSet
            // 
            // 
            // tblIngredientsBindingSource1
            // 
            this.tblIngredientsBindingSource1.DataMember = "tblIngredients";
            // 
            // ingredientDataSet
            // 
            // 
            // ingredientsDataSet
            // 
            // 
            // tblIngredientsBindingSource
            // 
            this.tblIngredientsBindingSource.DataMember = "tblIngredients";
            // 
            // tblIngredientsTableAdapter
            // 
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 717);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 439);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // tblIngredientsTableAdapter1
            // 
            // 
            // tblIngredientsTableAdapter2
            // 
            // 
            // AddIngredients_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 437);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddIngredients_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIngredients_Form";
            this.Load += new System.EventHandler(this.AddIngredients_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox IngredIDtextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button expandbtn;
        private System.Windows.Forms.ComboBox SuppliercomboBox3;
        private System.Windows.Forms.ComboBox CategorycomboBox2;
        private System.Windows.Forms.ComboBox UnitcomboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UnitCosttextBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MROPtextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IngNametextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mROPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
    }
}