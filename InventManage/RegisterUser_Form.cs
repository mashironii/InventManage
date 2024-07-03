using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventManage
{
    public partial class RegisterUser_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public RegisterUser_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();

            // Initialize the label if not done in the designer
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (last_NameTextBox.Text == "" || first_NameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter all required information");
            }
            else
            {
                string fname = first_NameTextBox.Text;
                string uname = last_NameTextBox.Text;
                string password = passwordTextBox.Text;
                string pos = positionComboBox.SelectedItem.ToString();

                string insertqry = "INSERT INTO tblUser (Full_Name, Username, Position, Password) " +
                    "VALUES (@Full_Name, @Username, @Position, @Password)";

                using (SqlCommand cmd = new SqlCommand(insertqry, cn))
                {
                    cmd.Parameters.AddWithValue("@Full_Name", fname);
                    cmd.Parameters.AddWithValue("@Username", uname);
                    cmd.Parameters.AddWithValue("@Position", pos);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User record created successfully!");

                first_NameTextBox.Text = "";
                last_NameTextBox.Text = "";
                passwordTextBox.Text = "";
                positionComboBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterUser_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void UserIDlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
