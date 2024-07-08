namespace InventManage
{
    partial class AddDish_Form
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
            System.Windows.Forms.Label DishLbl;
            System.Windows.Forms.Label dishIngrLbl;
            System.Windows.Forms.Label QuantityReqLbl;
            System.Windows.Forms.Label DishIngLbl;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDishesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.invTablesDatabaseDataSet = new InventManage.InvTablesDatabaseDataSet();
            this.tblDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.newdishname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.findbtn = new System.Windows.Forms.Button();
            this.UnitCombo = new System.Windows.Forms.ComboBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.DishNameCombo = new System.Windows.Forms.ComboBox();
            this.tblDishesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.QuantityReqTxtBox = new System.Windows.Forms.TextBox();
            this.DishIngredComboBx = new System.Windows.Forms.ComboBox();
            this.tblIngredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Dish_NameTextBox = new System.Windows.Forms.TextBox();
            this.AddDishbtn = new System.Windows.Forms.Button();
            this.tblDishesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDishIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDishIngredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblIngredientsTableAdapter = new InventManage.InvTablesDatabaseDataSetTableAdapters.tblIngredientsTableAdapter();
            this.tblDishesTableAdapter = new InventManage.InvTablesDatabaseDataSetTableAdapters.tblDishesTableAdapter();
            DishLbl = new System.Windows.Forms.Label();
            dishIngrLbl = new System.Windows.Forms.Label();
            QuantityReqLbl = new System.Windows.Forms.Label();
            DishIngLbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishIngredientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DishLbl
            // 
            DishLbl.AutoSize = true;
            DishLbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DishLbl.Location = new System.Drawing.Point(29, 78);
            DishLbl.Name = "DishLbl";
            DishLbl.Size = new System.Drawing.Size(128, 31);
            DishLbl.TabIndex = 4;
            DishLbl.Text = "Dish Name:";
            // 
            // dishIngrLbl
            // 
            dishIngrLbl.AutoSize = true;
            dishIngrLbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dishIngrLbl.Location = new System.Drawing.Point(29, 470);
            dishIngrLbl.Name = "dishIngrLbl";
            dishIngrLbl.Size = new System.Drawing.Size(116, 31);
            dishIngrLbl.TabIndex = 22;
            dishIngrLbl.Text = "Ingredient:";
            // 
            // QuantityReqLbl
            // 
            QuantityReqLbl.AutoSize = true;
            QuantityReqLbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QuantityReqLbl.Location = new System.Drawing.Point(29, 552);
            QuantityReqLbl.Name = "QuantityReqLbl";
            QuantityReqLbl.Size = new System.Drawing.Size(195, 31);
            QuantityReqLbl.TabIndex = 24;
            QuantityReqLbl.Text = "Quantity Required:";
            // 
            // DishIngLbl
            // 
            DishIngLbl.AutoSize = true;
            DishIngLbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DishIngLbl.Location = new System.Drawing.Point(29, 385);
            DishIngLbl.Name = "DishIngLbl";
            DishIngLbl.Size = new System.Drawing.Size(128, 31);
            DishIngLbl.TabIndex = 28;
            DishIngLbl.Text = "Dish Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(5, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(178, 31);
            label1.TabIndex = 31;
            label1.Text = "New Dish Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.tblDishesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(544, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dish_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dish_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dish_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dish_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tblDishesBindingSource3
            // 
            this.tblDishesBindingSource3.DataMember = "tblDishes";
            this.tblDishesBindingSource3.DataSource = this.invTablesDatabaseDataSet;
            // 
            // invTablesDatabaseDataSet
            // 
            this.invTablesDatabaseDataSet.DataSetName = "InvTablesDatabaseDataSet";
            this.invTablesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDishesBindingSource
            // 
            this.tblDishesBindingSource.DataMember = "tblDishes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.findbtn);
            this.panel1.Controls.Add(this.UnitCombo);
            this.panel1.Controls.Add(DishIngLbl);
            this.panel1.Controls.Add(this.Backbtn);
            this.panel1.Controls.Add(this.DishNameCombo);
            this.panel1.Controls.Add(this.QuantityReqTxtBox);
            this.panel1.Controls.Add(QuantityReqLbl);
            this.panel1.Controls.Add(dishIngrLbl);
            this.panel1.Controls.Add(this.DishIngredComboBx);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.Dish_NameTextBox);
            this.panel1.Controls.Add(DishLbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.AddDishbtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 702);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.newdishname);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(25, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 10);
            this.panel2.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(305, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 38);
            this.button3.TabIndex = 34;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newdishname
            // 
            this.newdishname.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newdishname.Location = new System.Drawing.Point(10, 53);
            this.newdishname.Name = "newdishname";
            this.newdishname.Size = new System.Drawing.Size(289, 38);
            this.newdishname.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(305, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // findbtn
            // 
            this.findbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbtn.Location = new System.Drawing.Point(330, 111);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(187, 38);
            this.findbtn.TabIndex = 30;
            this.findbtn.Text = "Find";
            this.findbtn.UseVisualStyleBackColor = true;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // UnitCombo
            // 
            this.UnitCombo.DisplayMember = "select unit";
            this.UnitCombo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitCombo.FormattingEnabled = true;
            this.UnitCombo.Items.AddRange(new object[] {
            "kilograms",
            "grams",
            "liters",
            "milliliters"});
            this.UnitCombo.Location = new System.Drawing.Point(214, 603);
            this.UnitCombo.Name = "UnitCombo";
            this.UnitCombo.Size = new System.Drawing.Size(142, 33);
            this.UnitCombo.TabIndex = 29;
            this.UnitCombo.Text = "Unit";
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(331, 155);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(186, 38);
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // DishNameCombo
            // 
            this.DishNameCombo.DataSource = this.tblDishesBindingSource2;
            this.DishNameCombo.DisplayMember = "Dish_Name";
            this.DishNameCombo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DishNameCombo.FormattingEnabled = true;
            this.DishNameCombo.Location = new System.Drawing.Point(35, 419);
            this.DishNameCombo.Name = "DishNameCombo";
            this.DishNameCombo.Size = new System.Drawing.Size(238, 33);
            this.DishNameCombo.TabIndex = 27;
            this.DishNameCombo.ValueMember = "Dish_Id";
            // 
            // tblDishesBindingSource2
            // 
            this.tblDishesBindingSource2.DataMember = "tblDishes";
            this.tblDishesBindingSource2.DataSource = this.invTablesDatabaseDataSet;
            // 
            // QuantityReqTxtBox
            // 
            this.QuantityReqTxtBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityReqTxtBox.Location = new System.Drawing.Point(35, 600);
            this.QuantityReqTxtBox.Name = "QuantityReqTxtBox";
            this.QuantityReqTxtBox.Size = new System.Drawing.Size(170, 38);
            this.QuantityReqTxtBox.TabIndex = 25;
            // 
            // DishIngredComboBx
            // 
            this.DishIngredComboBx.DataSource = this.tblIngredientsBindingSource1;
            this.DishIngredComboBx.DisplayMember = "Ingredient_Name";
            this.DishIngredComboBx.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DishIngredComboBx.FormattingEnabled = true;
            this.DishIngredComboBx.Location = new System.Drawing.Point(35, 504);
            this.DishIngredComboBx.Name = "DishIngredComboBx";
            this.DishIngredComboBx.Size = new System.Drawing.Size(238, 33);
            this.DishIngredComboBx.TabIndex = 21;
            this.DishIngredComboBx.ValueMember = "Ingredient_Id";
            // 
            // tblIngredientsBindingSource1
            // 
            this.tblIngredientsBindingSource1.DataMember = "tblIngredients";
            this.tblIngredientsBindingSource1.DataSource = this.invTablesDatabaseDataSet;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Dish Ingredient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(458, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 367);
            this.dataGridView2.TabIndex = 6;
            // 
            // Dish_NameTextBox
            // 
            this.Dish_NameTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dish_NameTextBox.Location = new System.Drawing.Point(35, 112);
            this.Dish_NameTextBox.Name = "Dish_NameTextBox";
            this.Dish_NameTextBox.Size = new System.Drawing.Size(289, 38);
            this.Dish_NameTextBox.TabIndex = 5;
            // 
            // AddDishbtn
            // 
            this.AddDishbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDishbtn.Location = new System.Drawing.Point(330, 60);
            this.AddDishbtn.Name = "AddDishbtn";
            this.AddDishbtn.Size = new System.Drawing.Size(188, 45);
            this.AddDishbtn.TabIndex = 2;
            this.AddDishbtn.Text = "Add Dish";
            this.AddDishbtn.UseVisualStyleBackColor = true;
            this.AddDishbtn.Click += new System.EventHandler(this.AddDishbtn_Click);
            // 
            // tblDishesBindingSource1
            // 
            this.tblDishesBindingSource1.DataMember = "tblDishes";
            // 
            // tblIngredientsBindingSource
            // 
            this.tblIngredientsBindingSource.DataMember = "tblIngredients";
            // 
            // tblDishIngredientsBindingSource
            // 
            this.tblDishIngredientsBindingSource.DataMember = "tblDish_Ingredients";
            // 
            // tblDishIngredientsBindingSource1
            // 
            this.tblDishIngredientsBindingSource1.DataMember = "tblDish_Ingredients";
            // 
            // tblIngredientsTableAdapter
            // 
            this.tblIngredientsTableAdapter.ClearBeforeFill = true;
            // 
            // tblDishesTableAdapter
            // 
            this.tblDishesTableAdapter.ClearBeforeFill = true;
            // 
            // AddDish_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 703);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDish_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDish_Form";
            this.Load += new System.EventHandler(this.AddDish_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDishIngredientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblDishesBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox Dish_NameTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddDishbtn;
        private System.Windows.Forms.ComboBox DishIngredComboBx;
        private System.Windows.Forms.TextBox QuantityReqTxtBox;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource;
        private System.Windows.Forms.ComboBox DishNameCombo;
        private System.Windows.Forms.BindingSource tblDishesBindingSource1;
        private System.Windows.Forms.BindingSource tblDishIngredientsBindingSource;
        private System.Windows.Forms.BindingSource tblDishIngredientsBindingSource1;
        private System.Windows.Forms.ComboBox UnitCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private InvTablesDatabaseDataSet invTablesDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblIngredientsBindingSource1;
        private InvTablesDatabaseDataSetTableAdapters.tblIngredientsTableAdapter tblIngredientsTableAdapter;
        private System.Windows.Forms.BindingSource tblDishesBindingSource2;
        private InvTablesDatabaseDataSetTableAdapters.tblDishesTableAdapter tblDishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tblDishesBindingSource3;
        private System.Windows.Forms.TextBox newdishname;
        private System.Windows.Forms.Button findbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}