using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventManage
{
    public partial class AddIngredients_Form : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        public AddIngredients_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            GetUserRecord();
            PopulateComboBox("select Supplier_Name from tblSupplier", SuppliercomboBox3);
            PopulateSupplierComboBox();
        }

        private void AddIngredients_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invTablesDatabaseDataSet.tblIngredients' table. You can move, or remove it, as needed.
            this.tblIngredientsTableAdapter.Fill(this.invTablesDatabaseDataSet.tblIngredients);
        }

        private void GetUserRecord()
        {
            cmd = new SqlCommand("SELECT * FROM tblIngredients", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void PopulateSupplierComboBox()
        {
            string query = "SELECT Supplier_Name FROM tblSupplier";
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        SuppliercomboBox3.Items.Clear();

                        while (reader.Read())
                        {
                            string supplierName = reader.GetString(reader.GetOrdinal("Supplier_Name"));
                            SuppliercomboBox3.Items.Add(supplierName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void PopulateComboBox(string query, ComboBox comboBox)
        {
            // Create a connection object using the existing connection string
            using (SqlConnection connection = new SqlConnection(cn.ConnectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the command and retrieve data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items
                            comboBox.Items.Clear();

                            // Loop through the data and add to combo box
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 84)
            {
                panel1.Height = 364;
                this.Height = 759;
            }

            if (IngNametextBox2.Text == "" || MROPtextBox3.Text == "" || UnitCosttextBox5.Text == "")
            {
                MessageBox.Show("Please enter all required information");
            }
            else
            {
                string IngName = IngNametextBox2.Text;
                string MROP = MROPtextBox3.Text;
                string unitCost = UnitCosttextBox5.Text;
                string unit = UnitcomboBox1.SelectedItem.ToString();
                string categ = CategorycomboBox2.SelectedItem.ToString();
                string supp = SuppliercomboBox3.SelectedItem.ToString();

                string insertqry = "INSERT INTO tblIngredients (Ingredient_Name, MROP, Unit, Unit_Cost, Category, Supplier) " +
                    "VALUES (@Ingredient_Name, @MROP, @Unit, @Unit_Cost, @Category, @Supplier)";

                using (SqlCommand cmd = new SqlCommand(insertqry, cn))
                {
                    cmd.Parameters.AddWithValue("@Ingredient_Name", IngName);
                    cmd.Parameters.AddWithValue("@MROP", MROP);
                    cmd.Parameters.AddWithValue("@Unit", unit);
                    cmd.Parameters.AddWithValue("@Unit_Cost", unitCost);
                    cmd.Parameters.AddWithValue("@Category", categ);
                    cmd.Parameters.AddWithValue("@Supplier", supp);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User record created successfully!");

                IngNametextBox2.Text = "";
                MROPtextBox3.Text = "";
                UnitCosttextBox5.Text = "";
                UnitcomboBox1.Text = "Kilogram";
                CategorycomboBox2.Text = "Vegetables";
                SuppliercomboBox3.Text = "Local";
                GetUserRecord();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expandbtn_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 84)
            {
                panel1.Height = 364;
                this.Height = 759;
            }
            else
            {
                panel1.Height = 84;
                this.Height = 476;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM tblIngredients WHERE Ingredient_Name = @Ingredient_Name";
            using (SqlCommand cmd = new SqlCommand(searchQuery, cn))
            {
                cmd.Parameters.AddWithValue("@Ingredient_Name", IngredIDtextBox1.Text.Trim());

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        IngNametextBox2.Text = row["Ingredient_Name"].ToString();
                        MROPtextBox3.Text = row["MROP"].ToString();
                        UnitCosttextBox5.Text = row["Unit_Cost"].ToString();
                        UnitcomboBox1.Text = row["Unit"].ToString();
                        CategorycomboBox2.Text = row["Category"].ToString();
                        SuppliercomboBox3.Text = row["Supplier"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Ingredient Name.");
                    }
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (IngredIDtextBox1.Text == "")
            {
                MessageBox.Show("Please enter Ingredient Name to update.");
            }
            else if (IngNametextBox2.Text == "" || MROPtextBox3.Text == "" || UnitCosttextBox5.Text == "")
            {
                MessageBox.Show("Please enter all required information");
            }
            else
            {
                string IngName = IngNametextBox2.Text;
                string MROP = MROPtextBox3.Text;
                string unitCost = UnitCosttextBox5.Text;
                string unit = UnitcomboBox1.SelectedItem.ToString();
                string categ = CategorycomboBox2.SelectedItem.ToString();
                string supp = SuppliercomboBox3.SelectedItem.ToString();

                string updateqry = "UPDATE tblIngredients SET Ingredient_Name = @Ingredient_Name, MROP = @MROP, Unit = @Unit, Unit_Cost = @Unit_Cost, Category = @Category, Supplier = @Supplier WHERE Ingredient_Name = @SearchName";

                using (SqlCommand cmd = new SqlCommand(updateqry, cn))
                {
                    cmd.Parameters.AddWithValue("@Ingredient_Name", IngName);
                    cmd.Parameters.AddWithValue("@MROP", MROP);
                    cmd.Parameters.AddWithValue("@Unit", unit);
                    cmd.Parameters.AddWithValue("@Unit_Cost", unitCost);
                    cmd.Parameters.AddWithValue("@Category", categ);
                    cmd.Parameters.AddWithValue("@Supplier", supp);
                    cmd.Parameters.AddWithValue("@SearchName", IngredIDtextBox1.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ingredient record updated successfully!");
                GetUserRecord();

                IngNametextBox2.Text = "";
                MROPtextBox3.Text = "";
                UnitCosttextBox5.Text = "";
                UnitcomboBox1.Text = "Kilogram";
                CategorycomboBox2.Text = "Vegetables";
                SuppliercomboBox3.Text = "Local";
                IngredIDtextBox1.Text = "";
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (IngredIDtextBox1.Text == "")
            {
                MessageBox.Show("Please enter Ingredient Name to delete.");
            }
            else
            {
                string deleteqry = "DELETE FROM tblIngredients WHERE Ingredient_Name = @Ingredient_Name";

                using (SqlCommand cmd = new SqlCommand(deleteqry, cn))
                {
                    cmd.Parameters.AddWithValue("@Ingredient_Name", IngredIDtextBox1.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ingredient record deleted successfully!");
                GetUserRecord();

                IngNametextBox2.Text = "";
                MROPtextBox3.Text = "";
                UnitCosttextBox5.Text = "";
                UnitcomboBox1.Text = "Kilogram";
                CategorycomboBox2.Text = "Vegetables";
                SuppliercomboBox3.Text = "Local";
                IngredIDtextBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetUserRecord();
        }
    }
}
