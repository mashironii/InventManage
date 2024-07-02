using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventManage
{
    public partial class Supplier_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;

        public Supplier_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Supplier_Form_Load(object sender, EventArgs e)
        {
            GetUserRecord();
        }

        private void GetUserRecord()
        {
            cmd = new SqlCommand("SELECT * FROM tblSupplier", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void addSuppbtn_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 70)
            {
                panel1.Height = 186;
            }

            if (string.IsNullOrEmpty(supptxtbx.Text))
            {
                MessageBox.Show("Please enter all required information");
                return;
            }

            string suppName = supptxtbx.Text;
            string insertqry = "INSERT INTO tblSupplier (Supplier_Name) VALUES (@Supplier_Name)";
            SqlCommand cmd = new SqlCommand(insertqry, cn);
            cmd.Parameters.AddWithValue("@Supplier_Name", suppName);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Supplier record created successfully!");

            supptxtbx.Text = "";
            GetUserRecord();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expandbtn_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 70)
            {
                panel1.Height = 186;
            }
            else if (panel1.Height == 186)
            {
                panel1.Height = 220;
            } else
            {
                panel1.Height = 70;
            }
        }

        private void supplbl_Click(object sender, EventArgs e)
        {

        }

        private void findbtn_Click(object sender, EventArgs e)
        {
         
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(supptxtbx.Text))
            {
                MessageBox.Show("Please enter a supplier name to delete");
                return;
            }

            string suppName = supptxtbx.Text;
            cmd = new SqlCommand("DELETE FROM tblSupplier WHERE Supplier_Name = @Supplier_Name", cn);
            cmd.Parameters.AddWithValue("@Supplier_Name", suppName);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Supplier record deleted successfully!");
                supptxtbx.Text = "";
                GetUserRecord();
            }
            else
            {
                MessageBox.Show("Supplier not found");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 186)
            {
                panel1.Height = 220;
            }
            if (string.IsNullOrEmpty(supptxtbx.Text))
            {
                MessageBox.Show("Please enter a supplier name to update");
                return;
            }

            string suppName = supptxtbx.Text;
            string newSuppName = newSuppNametxtbx.Text; // Assuming you want to update the supplier name itself

            cmd = new SqlCommand("UPDATE tblSupplier SET Supplier_Name = @NewSupplier_Name WHERE Supplier_Name = @Supplier_Name", cn);
            cmd.Parameters.AddWithValue("@NewSupplier_Name", newSuppName);
            cmd.Parameters.AddWithValue("@Supplier_Name", suppName);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Supplier record updated successfully!");
                supptxtbx.Text = "";
                GetUserRecord();
            }
            else
            {
                MessageBox.Show("Supplier not found");
            }
        }

        private void supptxtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
