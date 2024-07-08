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
    public partial class Cook_Form : Form
    {
        private Main_Form mainForm;
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public Cook_Form(Main_Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            
        }

        private void Cook_Form_Load(object sender, EventArgs e)
        {
            LoadDishes();
        }
        private void LoadDishes()
        {
            string query = "SELECT Dish_Id, Dish_Name FROM tblDishes";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            checkedListBoxDishes.DataSource = dt;
            checkedListBoxDishes.DisplayMember = "Dish_Name";
            checkedListBoxDishes.ValueMember = "Dish_Id";
        }

        private void Cookbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxDishes.CheckedItems)
            {
                DataRowView row = (DataRowView)item;
                int dishId = (int)row["Dish_ID"];
                SubtractIngredients(dishId);
            }

            MessageBox.Show("Ingredients updated successfully!");

            mainForm.LoadIngredients();

            this.Close();
        }

        private void LoadIngredients()
        {
            string query = "SELECT Ingredient_Id, Ingredient_Name FROM tblIngredients";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }

        private void SubtractIngredients(int dishId)
        {
            // Join tblDish_Ingredients with tblIngredients to get Ingredient_Name
            string query = @"
                SELECT di.Ingredient_Id, di.Quantity_Req, i.Ingredient_Name 
                FROM tblDish_Ingredients di
                JOIN tblIngredients i ON di.Ingredient_Id = i.Ingredient_Id
                WHERE di.Dish_Id = @Dish_Id";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@Dish_Id", dishId);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                int ingredientId = (int)row["Ingredient_Id"];
                decimal quantityReq = (decimal)row["Quantity_Req"];
                string ingredientName = (string)row["Ingredient_Name"];

                // Subtract the required quantity from the ingredient in tblIngredients
                string updateQuery = "UPDATE tblIngredients SET Quantity = Quantity - @Quantity_Req WHERE Ingredient_Id = @Ingredient_Id";
                SqlCommand updateCmd = new SqlCommand(updateQuery, cn);
                updateCmd.Parameters.AddWithValue("@Quantity_Req", quantityReq);
                updateCmd.Parameters.AddWithValue("@Ingredient_Id", ingredientId);
                updateCmd.ExecuteNonQuery();

                // Log the usage in tblIngredientUsage
                string insertUsageQuery = "INSERT INTO tblIngredientUsage (Dish_Id, Ingredient_Id, Ingredient_Name, Quantity_Used) " +
                                          "VALUES (@DishID, @IngredientID, @IngredientName, @QuantityUsed)";
                SqlCommand insertUsageCmd = new SqlCommand(insertUsageQuery, cn);
                insertUsageCmd.Parameters.AddWithValue("@DishID", dishId);
                insertUsageCmd.Parameters.AddWithValue("@IngredientID", ingredientId);
                insertUsageCmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                insertUsageCmd.Parameters.AddWithValue("@QuantityUsed", quantityReq);
                insertUsageCmd.ExecuteNonQuery();
            }
        }

        private void BackCookBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
