using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace InventManage
{
    public partial class Reorder_Form : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataTable dtIngredients;

        public Reorder_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Reorder_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invTablesDatabaseDataSet.tblIngredients' table. You can move, or remove it, as needed.
            this.tblIngredientsTableAdapter1.Fill(this.invTablesDatabaseDataSet.tblIngredients);
            DefineColumns();
            LoadReorderData();
            PopulateComboBoxColumn();
        }

        private void DefineColumns()
        {
            // Define columns for dataGridView1 (Automatic Reorder List)
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ingredient Id", Name = "Ingredient_Id", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ingredient Name", Name = "Ingredient_Name", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "MROP", Name = "MROP", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Current Quantity", Name = "Quantity", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unit", Name = "Unit", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity Requested (Kg/L)", Name = "Quantity_Requested" });

            // Define columns for dataGridView2 (Manual Reorder List)
            dataGridView2.Columns.Clear();

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Ingredient Name",
                Name = "Ingredient_Name_Manual",
                DisplayMember = "Ingredient_Name",
                ValueMember = "Ingredient_Id",
                DataSource = GetAllIngredientNames()
            };
            dataGridView2.Columns.Add(comboBoxColumn);
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity Requested (Kg/L)", Name = "Quantity_Requested_Manual" });
        }

        private void LoadReorderData()
        {
            // Load ingredients below MROP
            DataTable ingredientsBelowMROP = GetIngredientsBelowMROP();

            // Add rows for ingredients below MROP
            foreach (DataRow row in ingredientsBelowMROP.Rows)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Ingredient_Id"].Value = row["Ingredient_Id"];
                dataGridView1.Rows[rowIndex].Cells["Ingredient_Name"].Value = row["Ingredient_Name"];
                dataGridView1.Rows[rowIndex].Cells["MROP"].Value = row["MROP"];
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = row["Quantity"];
                dataGridView1.Rows[rowIndex].Cells["Unit"].Value = row["Unit"];
            }
        }

        private DataTable GetIngredientsBelowMROP()
        {
            // Fetch ingredients below MROP from database
            string query = "SELECT Ingredient_Id, Ingredient_Name, MROP, Quantity, Unit FROM tblIngredients WHERE Quantity < MROP";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private DataTable GetAllIngredientNames()
        {
            // Fetch all ingredient details from database
            string query = "SELECT Ingredient_Id, Ingredient_Name, MROP, Quantity, Unit FROM tblIngredients";
            da = new SqlDataAdapter(query, cn);
            dtIngredients = new DataTable();
            da.Fill(dtIngredients);
            return dtIngredients;
        }

        private void PopulateComboBoxColumn()
        {
            // Populate the combobox column in dataGridView2 with all ingredients
            var comboBoxColumn = (DataGridViewComboBoxColumn)dataGridView2.Columns["Ingredient_Name_Manual"];
            comboBoxColumn.DataSource = dtIngredients;
            comboBoxColumn.DisplayMember = "Ingredient_Name";
            comboBoxColumn.ValueMember = "Ingredient_Id";
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ReorderListBtn_Click(object sender, EventArgs e)
        {
            StringBuilder reorderList = new StringBuilder();
            reorderList.AppendLine("Reorder List:");
            reorderList.AppendLine("------------");

            // Combine entries from dataGridView1
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ingredient_Id"].Value != null)
                {
                    reorderList.AppendLine($"Ingredient: {row.Cells["Ingredient_Name"].Value}, Quantity Requested (Kg/L): {row.Cells["Quantity_Requested"].Value}");
                }
            }

            // Combine entries from dataGridView2
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Ingredient_Name_Manual"].Value != null)
                {
                    reorderList.AppendLine($"Ingredient: {row.Cells["Ingredient_Name_Manual"].FormattedValue}, Quantity Requested (Kg/L): {row.Cells["Quantity_Requested_Manual"].Value}");
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text file (*.txt)|*.txt",
                Title = "Save Reorder List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, reorderList.ToString());
                MessageBox.Show("Reorder list saved successfully.", "Success");
            }
        }
    }
}
