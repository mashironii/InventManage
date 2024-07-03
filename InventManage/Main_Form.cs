using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InventManage
{
    public partial class Main_Form : Form
    {
        private string userFullName;
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;

        public Main_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
        }
        public Main_Form(string fullName)
        {
            InitializeComponent();
            userFullName = fullName;
            DisplayUserFullName();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
        }

        private void DisplayUserFullName()
        {
            EmpLbl.Text = userFullName;
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form log = new Login_Form();
            log.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users_Form user = new Users_Form();
            user.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            LoadIngredients();
        }

        public void LoadIngredients()
        {
            // Clear existing controls
            flowLayoutPanel2.Controls.Clear();

            // Fetch data from the database
            string query = "SELECT Ingredient_Name, MROP, Quantity, Unit FROM tblIngredients";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Create and populate user controls
            foreach (DataRow row in dt.Rows)
            {
                UcIngredProd ingredientControl = new UcIngredProd();
                ingredientControl.IngredientName = row["Ingredient_Name"].ToString();
                ingredientControl.Amount = row["Quantity"].ToString();
                ingredientControl.Unit = row["Unit"].ToString();

                decimal currentAmount = Convert.ToDecimal(row["Quantity"]);
                decimal mrop = Convert.ToDecimal(row["MROP"]);
                ingredientControl.UpdateIndicatorColor(currentAmount, mrop);

                // Add the user control to the flow layout panel
                flowLayoutPanel2.Controls.Add(ingredientControl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddIngredients_Form add = new AddIngredients_Form();
            add.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supplier_Form supplier = new Supplier_Form();
            supplier.ShowDialog();
        }

        private void MainBtn_Add_Click(object sender, EventArgs e)
        {
            Cook_Form ckfrm = new Cook_Form(this);
            ckfrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDish_Form add = new AddDish_Form();
            add.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InventoryIn_Form inventory = new InventoryIn_Form(this);
            inventory.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ResizeAdminPanel(Size newSize)
        {
            AdminPanel.Size = newSize;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //247, 431 > 247, 106
            if (AdminPanel.Size.Height == 106)
            {
                AdminLogin_Form login = new AdminLogin_Form(this);
                login.ShowDialog();
            }
            else
            {
                AdminPanel.Height = 106;
            }
        }

        private void InventoryInBtn_Click(object sender, EventArgs e)
        {
            InventoryInLog_Form inv = new InventoryInLog_Form();
            inv.ShowDialog();
        }
        private void UseLogBtn_Click(object sender, EventArgs e)
        {
            IngredUsageLog_Form use = new IngredUsageLog_Form();
            use.ShowDialog();
        }

        private void ReorderBtn_Click(object sender, EventArgs e)
        {
            Reorder_Form reorder_Form = new Reorder_Form();
            reorder_Form.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
