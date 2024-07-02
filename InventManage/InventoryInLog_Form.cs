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
    public partial class InventoryInLog_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public InventoryInLog_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            LoadInventoryInLog();
        }

        private void LoadInventoryInLog()
        {
            string query = "SELECT * FROM tblInventoryInLog";
            cmd = new SqlCommand(query, cn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void InventoryInLog_Form_Load(object sender, EventArgs e)
        {

        }

        private void SearchInventoryInBtn_Click(object sender, EventArgs e)
        {
            // Get selected date from DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Format the date to match SQL date format (yyyy-MM-dd)
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            // Query to filter usage log entries by date
            string query = "SELECT * FROM tblInventoryInLog WHERE CAST(Date_Added AS DATE) = @SelectedDate";
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
