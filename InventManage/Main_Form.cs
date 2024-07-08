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
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace InventManage
{
    public partial class Main_Form : Form
    {
        private string userFullName, userPosition;
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Main_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            // Ensure this is set at the start of your application
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }
        public Main_Form(string fullName, string position)
        {
            InitializeComponent();
            userFullName = fullName;
            userPosition = position;
            DisplayUserFullName();
            AdjustUIBasedOnPosition();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            // Ensure this is set at the start of your application
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void DisplayUserFullName()
        {
            EmpLbl.Text = userFullName;
        }

        private void AdjustUIBasedOnPosition()
        {
            // Example: Adjust buttons based on user's position
            switch (userPosition)
            {
                case "Cook":
                    
                    ResizePanel(new Size(253, 363));
                    break;
                case "Manager":

                    ResizePanel(new Size(253, 423));
                    break;
                case "Staff":

                    ResizePanel(new Size(253, 123));
                    break;
                default:
                    // Handle other positions or unknown cases
                    break;
            }
        }

        public void ResizePanel(Size newSize)
        {
            flowLayoutPanel1.Size = newSize;
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
            // Clear existing controls in all panels
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3Near.Controls.Clear();
            flowLayoutPanel4Green.Controls.Clear();

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

                // Determine which panel to add the control to
                if (currentAmount < mrop)
                {
                    // Below threshold, critical level
                    flowLayoutPanel2.Controls.Add(ingredientControl);
                }
                else if (currentAmount >= mrop && currentAmount <= mrop + (mrop < 10 ? 1 : mrop * 0.2m))
                {
                    // Nearing reorder point
                    flowLayoutPanel3Near.Controls.Add(ingredientControl);
                }
                else
                {
                    // Good supply level
                    flowLayoutPanel4Green.Controls.Add(ingredientControl);
                }
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
            // Empty button handler
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
            // Empty paint handler
        }

        public void ResizeAdminPanel(Size newSize)
        {
            AdminPanel.Size = newSize;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //247, 431 > 247, 106 \\\247, 468
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
            // Empty paint handler
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {
            // Empty paint handler
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            string query = "SELECT Ingredient_Id, Ingredient_Name, Quantity, MROP FROM tblIngredients";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            StringBuilder reportContent = new StringBuilder();
            StringBuilder belowMROP = new StringBuilder();
            StringBuilder approachingMROP = new StringBuilder();

            // Format headers
            string headerFormat = "{0,-8} {1,-25} {2,-15} {3,-10}";
            belowMROP.AppendLine("Ingredients Below MROP");
            belowMROP.AppendLine(new string('-', 30));
            belowMROP.AppendLine(string.Format(headerFormat, "ID", "Name", "Quantity", "MROP"));

            approachingMROP.AppendLine("Ingredients Approaching MROP");
            approachingMROP.AppendLine(new string('-', 30));
            approachingMROP.AppendLine(string.Format(headerFormat, "ID", "Name", "Quantity", "MROP"));

            reportContent.AppendLine("Ingredients Report");
            reportContent.AppendLine(new string('-', 30));
            reportContent.AppendLine(string.Format(headerFormat, "ID", "Name", "Quantity", "MROP"));

            // Format data rows
            string rowFormat = "{0,-8} {1,-25} {2,-15} {3,-10}";

            foreach (DataRow row in dt.Rows)
            {
                string ingredientName = row["Ingredient_Name"].ToString();
                decimal quantity = Convert.ToDecimal(row["Quantity"]);
                decimal mrop = Convert.ToDecimal(row["MROP"]);
                decimal thresholdUpper;

                string formattedRow = string.Format(rowFormat, row["Ingredient_Id"], ingredientName, quantity, mrop);

                if (mrop < 10)
                {
                    thresholdUpper = mrop + 1m; // Threshold is 1 less than the MROP for MROPs below 10 kilograms
                }
                else
                {
                    thresholdUpper = mrop + (mrop * 0.2m); // 20% of MROP
                }

                if (quantity < mrop)
                {
                    belowMROP.AppendLine(formattedRow);
                }
                else if (quantity >= mrop && quantity <= thresholdUpper)
                {
                    approachingMROP.AppendLine(formattedRow);
                }

                reportContent.AppendLine(formattedRow);
            }

            // Combine all sections
            StringBuilder finalReportContent = new StringBuilder();
            finalReportContent.AppendLine(belowMROP.ToString());
            finalReportContent.AppendLine();
            finalReportContent.AppendLine(approachingMROP.ToString());
            finalReportContent.AppendLine();
            finalReportContent.AppendLine(reportContent.ToString());

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text file (*.txt)|*.txt",
                Title = "Save Ingredients Report",
                FileName = $"IngredientsReport_{currentDate}.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, finalReportContent.ToString());
                MessageBox.Show("Ingredients report saved successfully.", "Success");
            }
        }

        private void GenExcelBtn_Click(object sender, EventArgs e)
        {
            GenerateExcelReport();
        }

        private void GenerateExcelReport()
        {
            string query = "SELECT Ingredient_Id, Ingredient_Name, Quantity, MROP FROM tblIngredients";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            using (ExcelPackage package = new ExcelPackage())
            {
                // Create worksheets
                ExcelWorksheet belowMROPWorksheet = package.Workbook.Worksheets.Add("Below MROP");
                ExcelWorksheet approachingMROPWorksheet = package.Workbook.Worksheets.Add("Approaching MROP");
                ExcelWorksheet fullReportWorksheet = package.Workbook.Worksheets.Add("Full Report");

                // Define headers
                string[] headers = { "ID", "Name", "Quantity", "MROP" };

                // Format headers and set values
                for (int i = 0; i < headers.Length; i++)
                {
                    belowMROPWorksheet.Cells[1, i + 1].Value = headers[i];
                    belowMROPWorksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    belowMROPWorksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                    approachingMROPWorksheet.Cells[1, i + 1].Value = headers[i];
                    approachingMROPWorksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    approachingMROPWorksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                    fullReportWorksheet.Cells[1, i + 1].Value = headers[i];
                    fullReportWorksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    fullReportWorksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                int belowMROPRow = 2;
                int approachingMROPRow = 2;
                int fullReportRow = 2;

                foreach (DataRow row in dt.Rows)
                {
                    string ingredientName = row["Ingredient_Name"].ToString();
                    decimal quantity = Convert.ToDecimal(row["Quantity"]);
                    decimal mrop = Convert.ToDecimal(row["MROP"]);
                    decimal thresholdUpper;

                    if (mrop < 10)
                    {
                        thresholdUpper = mrop + 1m; // Threshold is 1 less than the MROP for MROPs below 10 kilograms
                    }
                    else
                    {
                        thresholdUpper = mrop + (mrop * 0.2m); // 20% of MROP
                    }

                    object[] rowData = { row["Ingredient_Id"], ingredientName, quantity, mrop };

                    if (quantity < mrop)
                    {
                        for (int i = 0; i < rowData.Length; i++)
                        {
                            belowMROPWorksheet.Cells[belowMROPRow, i + 1].Value = rowData[i];
                            belowMROPWorksheet.Cells[belowMROPRow, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }
                        belowMROPRow++;
                    }
                    else if (quantity >= mrop && quantity <= thresholdUpper)
                    {
                        for (int i = 0; i < rowData.Length; i++)
                        {
                            approachingMROPWorksheet.Cells[approachingMROPRow, i + 1].Value = rowData[i];
                            approachingMROPWorksheet.Cells[approachingMROPRow, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }
                        approachingMROPRow++;
                    }

                    for (int i = 0; i < rowData.Length; i++)
                    {
                        fullReportWorksheet.Cells[fullReportRow, i + 1].Value = rowData[i];
                        fullReportWorksheet.Cells[fullReportRow, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                    fullReportRow++;
                }

                // Auto-fit columns
                belowMROPWorksheet.Cells[belowMROPWorksheet.Dimension.Address].AutoFitColumns();
                approachingMROPWorksheet.Cells[approachingMROPWorksheet.Dimension.Address].AutoFitColumns();
                fullReportWorksheet.Cells[fullReportWorksheet.Dimension.Address].AutoFitColumns();

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel file (*.xlsx)|*.xlsx",
                    Title = "Save Ingredients Report",
                    FileName = $"IngredientsReport_{currentDate}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                    MessageBox.Show("Ingredients report saved successfully.", "Success");
                }
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
