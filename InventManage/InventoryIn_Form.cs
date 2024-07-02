using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventManage
{
    public partial class InventoryIn_Form : Form
    {
        private Main_Form mainForm;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public InventoryIn_Form(Main_Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            LoadSuppliers();
        }

        private void LoadIngredients()
        {
            string query = "SELECT Ingredient_Id, Ingredient_Name FROM tblIngredients";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }

        private void InventoryIn_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invTablesDatabaseDataSet.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.invTablesDatabaseDataSet.tblSupplier);
            LoadIngredients();
            PopulateComboBoxColumn();
        }

        private void PopulateComboBoxColumn()
        {
            var comboBoxColumn = (DataGridViewComboBoxColumn)IngredientGridView.Columns["Ingredient_Name"];
            comboBoxColumn.DataSource = dt;
            comboBoxColumn.DisplayMember = "Ingredient_Name";
            comboBoxColumn.ValueMember = "Ingredient_Id";
        }

        private void LoadSuppliers()
        {
            string query = "SELECT Supplier_Name FROM tblSupplier";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            DataTable suppliersTable = new DataTable(); // Rename to avoid confusion with class-level dt
            da.Fill(suppliersTable);

            // Clear existing items
            SupplierCombo.Items.Clear();

            // Bind the data to ComboBox
            foreach (DataRow row in suppliersTable.Rows)
            {
                SupplierCombo.Items.Add(row["Supplier_Name"].ToString());
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInvenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string supplierName = SupplierCombo.SelectedItem?.ToString();
                DateTime dateAdded = dateAddedPicker.Value;

                foreach (DataGridViewRow row in IngredientGridView.Rows)
                {
                    if (row.Cells["Ingredient_Name"].Value != null && row.Cells["Quantity_Add"].Value != null)
                    {
                        int ingredientId = (int)row.Cells["Ingredient_Name"].Value;
                        decimal amountToAdd;
                        if (decimal.TryParse(row.Cells["Quantity_Add"].Value.ToString(), out amountToAdd))
                        {
                            // Fetch the Ingredient Name
                            string ingredientNameQuery = "SELECT Ingredient_Name FROM tblIngredients WHERE Ingredient_Id = @IngredientId";
                            cmd = new SqlCommand(ingredientNameQuery, cn);
                            cmd.Parameters.AddWithValue("@IngredientId", ingredientId);
                            string ingredientName = cmd.ExecuteScalar().ToString();

                            string query = "UPDATE tblIngredients SET Quantity = Quantity + @AmountToAdd WHERE Ingredient_Id = @IngredientId";
                            cmd = new SqlCommand(query, cn);
                            cmd.Parameters.AddWithValue("@AmountToAdd", amountToAdd);
                            cmd.Parameters.AddWithValue("@IngredientId", ingredientId);
                            cmd.ExecuteNonQuery();

                            // Insert log entry
                            string logQuery = "INSERT INTO tblInventoryInLog (Ingredient_Id, Ingredient_Name, Supplier_Name, Quantity_Added, Date_Added) VALUES (@IngredientId, @IngredientName, @SupplierName, @QuantityAdded, @DateAdded)";
                            cmd = new SqlCommand(logQuery, cn);
                            cmd.Parameters.AddWithValue("@IngredientId", ingredientId);
                            cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                            cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                            cmd.Parameters.AddWithValue("@QuantityAdded", amountToAdd);
                            cmd.Parameters.AddWithValue("@DateAdded", dateAdded);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("All amounts added successfully!");

                // Clear the Add Ingredients DataGridView
                IngredientGridView.Rows.Clear();

                mainForm.LoadIngredients();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
