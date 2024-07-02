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
    public partial class IngredUsageLog_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public IngredUsageLog_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            LoadUsageLog();
        }

        private void LoadUsageLog()
        {
            string query = "SELECT * FROM tblIngredientUsage";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void IngredUsageLog_Form_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            // Get selected date from DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Format the date to match SQL date format (yyyy-MM-dd)
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            // Query to filter usage log entries by date
            string query = "SELECT * FROM tblIngredientUsage WHERE CAST(Usage_Date AS DATE) = @SelectedDate";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@SelectedDate", formattedDate);

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            // Bind filtered data to DataGridView
            dataGridView1.DataSource = dt;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
