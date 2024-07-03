using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventManage
{
    public partial class Users_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;

        public Users_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            GetUserRecord(); // Load user records on form initialization
        }

        private void GetUserRecord()
        {
            cmd = new SqlCommand("SELECT * FROM tblUser", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Users_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invTablesDatabaseDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter2.Fill(this.invTablesDatabaseDataSet.tblUser);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (AddPanel.Height == 87)
            {
                AddPanel.Height = 322;
            }

            if (string.IsNullOrEmpty(UserIDtxtbx.Text))
            {
                MessageBox.Show("Please enter a User ID to search");
                return;
            }

            int userId;
            if (int.TryParse(UserIDtxtbx.Text, out userId))
            {
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE User_Id = @UserId", cn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    first_NameTextBox.Text = dr["Full_Name"].ToString();
                    last_NameTextBox.Text = dr["Username"].ToString();
                    positionComboBox.SelectedItem = dr["Position"].ToString();
                    passwordTextBox.Text = dr["Password"].ToString();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("User not found");
                    dr.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid User ID. Please enter a valid numeric User ID.");
            }
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            cn.Close();
            this.Close();
        }

        private void expandbtn_Click(object sender, EventArgs e)
        {
            if (AddPanel.Height == 87)
            {
                AddPanel.Height = 322;
            }
            else
            {
                AddPanel.Height = 87;
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(last_NameTextBox.Text))
            {
                MessageBox.Show("Please enter a username to delete");
                return;
            }

            string username = last_NameTextBox.Text;

            cmd = new SqlCommand("DELETE FROM tblUser WHERE Username = @Username", cn);
            cmd.Parameters.AddWithValue("@Username", username);

            cmd.ExecuteNonQuery();

            MessageBox.Show("User record deleted successfully!");

            first_NameTextBox.Text = "";
            last_NameTextBox.Text = "";
            passwordTextBox.Text = "";
            positionComboBox.SelectedIndex = -1;
            GetUserRecord();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserIDtxtbx.Text))
            {
                MessageBox.Show("Please enter a User ID to update");
                return;
            }

            int userId;
            if (int.TryParse(UserIDtxtbx.Text, out userId))
            {
                string fname = first_NameTextBox.Text;
                string lname = last_NameTextBox.Text; // Assuming last_NameTextBox is used for Username
                string password = passwordTextBox.Text;
                string pos = positionComboBox.SelectedItem?.ToString();

                // Update the record using User_Id instead of Username
                cmd = new SqlCommand("UPDATE tblUser SET Full_Name = @Full_Name, Username = @Username, Position = @Position, Password = @Password WHERE User_Id = @UserId", cn);
                cmd.Parameters.AddWithValue("@Full_Name", fname);
                cmd.Parameters.AddWithValue("@Username", lname);
                cmd.Parameters.AddWithValue("@Position", pos);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserId", userId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User record updated successfully!");

                first_NameTextBox.Text = "";
                last_NameTextBox.Text = "";
                passwordTextBox.Text = "";
                positionComboBox.SelectedIndex = -1;
                GetUserRecord();
            }
            else
            {
                MessageBox.Show("Invalid User ID. Please enter a valid numeric User ID.");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder for any required functionality related to cell content click
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to password text box change
        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to position combo box selection change
        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to first name text box change
        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to last name text box change
        }

        private void first_NameLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to first name label click
        }

        private void last_NameLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to last name label click
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to password label click
        }

        private void positionLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to position label click
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            // Placeholder for any required functionality related to find button click
        }
    }
}
