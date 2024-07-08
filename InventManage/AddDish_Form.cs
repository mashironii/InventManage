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
using System.Xml.Linq;

namespace InventManage
{
    public partial class AddDish_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        public AddDish_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
        }

        private void AddDish_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invTablesDatabaseDataSet.tblDishes' table. You can move, or remove it, as needed.
            this.tblDishesTableAdapter.Fill(this.invTablesDatabaseDataSet.tblDishes);
            // TODO: This line of code loads data into the 'invTablesDatabaseDataSet.tblIngredients' table. You can move, or remove it, as needed.
            this.tblIngredientsTableAdapter.Fill(this.invTablesDatabaseDataSet.tblIngredients);

            GetDishRecord();
            GetDishIngredRecord();

        }

        private void GetDishRecord()
        {
            cmd = new SqlCommand("Select * from tblDishes", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void GetDishIngredRecord()
        {
            string query = "SELECT di.Dish_Ingredient_Id, di.Dish_Id, di.Ingredient_Id, i.Ingredient_Name, di.Quantity_Req " +
                           "FROM tblDish_Ingredients di " +
                           "JOIN tblIngredients i ON di.Ingredient_Id = i.Ingredient_Id";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            // Update DataGridView column headers by index positions
            dataGridView2.Columns[0].HeaderText = "Dish_Ingredient_Id";
            dataGridView2.Columns[1].HeaderText = "Dish_Id";
            dataGridView2.Columns[2].HeaderText = "Ingredient_Id";
            dataGridView2.Columns[3].HeaderText = "Ingredient_Name";
            dataGridView2.Columns[4].HeaderText = "Quantity Required (kg/l)";
        }
        private void AddDishbtn_Click(object sender, EventArgs e)
        {
            if (Dish_NameTextBox.Text == "")
            {
                MessageBox.Show("Please enter Dish Name.");
            }
            else
            {
                string dname = Dish_NameTextBox.Text;
                string insertqry = "INSERT INTO tblDishes (Dish_Name) " +
                        "VALUES (@Dish_Name)";

                SqlCommand cmd = new SqlCommand(insertqry, cn);
                cmd.Parameters.AddWithValue("@Dish_Name", dname);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dish added successfully!");
                GetDishRecord();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QuantityReqTxtBox.Text == "")
            {
                MessageBox.Show("Please input ingredient quantity.");
            }
            else
            {
                int d_ID = (int)DishNameCombo.SelectedValue;
                int s_ID = (int)DishIngredComboBx.SelectedValue;
                decimal qua = decimal.Parse(QuantityReqTxtBox.Text);
                string selectedUnit = UnitCombo.SelectedItem.ToString();

                // Convert quantity to kilograms or liters
                if (selectedUnit == "grams")
                {
                    qua /= 1000; // Convert to kilograms
                }
                else if (selectedUnit == "milliliters")
                {
                    qua /= 1000; // Convert to liters
                }

                string insertqry = "INSERT INTO tblDish_Ingredients (Dish_Id, Ingredient_Id, Quantity_Req) " +
                    "VALUES (@Dish_Id, @Ingredient_Id, @Quantity_Req)";

                SqlCommand cmd = new SqlCommand(insertqry, cn);
                cmd.Parameters.AddWithValue("@Dish_Id", d_ID);
                cmd.Parameters.AddWithValue("@Ingredient_Id", s_ID);
                cmd.Parameters.AddWithValue("@Quantity_Req", qua);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dish Ingredient added successfully!");
                GetDishIngredRecord();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            //427, 145

            if (panel2.Height == 10)
            {
                panel2.Height = 104;
            }

            if (string.IsNullOrEmpty(Dish_NameTextBox.Text))
            {
                MessageBox.Show("Please enter a dish name to search.");
                return;
            }

            string dname = Dish_NameTextBox.Text;
            string findqry = "SELECT * FROM tblDishes WHERE Dish_Name = @Dish_Name";

            SqlCommand cmd = new SqlCommand(findqry, cn);
            cmd.Parameters.AddWithValue("@Dish_Name", dname);

            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                Dish_NameTextBox.Text = dt.Rows[0]["Dish_Name"].ToString();
                // If there are other fields you want to display, you can add them here
            }
            else
            {
                MessageBox.Show("Dish not found.");
                GetDishRecord();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Dish_NameTextBox.Text))
            {
                MessageBox.Show("Please enter the dish name to delete.");
                return;
            }

            string dname = Dish_NameTextBox.Text;
            string deleteqry = "DELETE FROM tblDishes WHERE Dish_Name = @Dish_Name";

            SqlCommand cmd = new SqlCommand(deleteqry, cn);
            cmd.Parameters.AddWithValue("@Dish_Name", dname);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Dish deleted successfully!");
                GetDishRecord();
            }
            else
            {
                MessageBox.Show("Dish not found.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Dish_NameTextBox.Text) || string.IsNullOrEmpty(newdishname.Text))
            {
                MessageBox.Show("Please enter the current and new dish names.");
                return;
            }

            string dname = Dish_NameTextBox.Text;
            string newDname = newdishname.Text;
            string updateqry = "UPDATE tblDishes SET Dish_Name = @NewDish_Name WHERE Dish_Name = @Dish_Name";

            SqlCommand cmd = new SqlCommand(updateqry, cn);
            cmd.Parameters.AddWithValue("@Dish_Name", dname);
            cmd.Parameters.AddWithValue("@NewDish_Name", newDname);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Dish updated successfully!");
                GetDishRecord();
            }
            else
            {
                MessageBox.Show("Dish not found.");
            }
        }

        private void clearBTn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

