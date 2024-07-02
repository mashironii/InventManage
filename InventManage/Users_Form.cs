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
    public partial class Users_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        public Users_Form()
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");
            cn.Open();
            InitializeComponent();
            GetUserRecord();
        }

        private void GetUserRecord()
        {
            cmd = new SqlCommand("Select * from tblUser", cn);
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
                AddPanel.Height = 283;
            } 
            else if (last_NameTextBox.Text == "" || first_NameTextBox.Text == "" || passwordTextBox.Text == "")
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

                        SqlCommand cmd = new SqlCommand(insertqry, cn);
                        cmd.Parameters.AddWithValue("@Full_Name", fname);
                        cmd.Parameters.AddWithValue("@Username", uname);
                        cmd.Parameters.AddWithValue("@Position", pos);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();

                MessageBox.Show("User record created successfully!");

                first_NameTextBox.Text = "";
                last_NameTextBox.Text = "";
                passwordTextBox.Text = "";
                positionComboBox.Text = "";
                GetUserRecord();
                
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            cn.Close();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void expandbtn_Click(object sender, EventArgs e)
        {
            if (AddPanel.Height == 87)
            {
                AddPanel.Height = 283;
            }
            else
            {
                AddPanel.Height = 87;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void last_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void positionLabel_Click(object sender, EventArgs e)
        {

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(last_NameTextBox.Text))
            {
                MessageBox.Show("Please enter a username to search");
                return;
            }

            string username = last_NameTextBox.Text;
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE Username = @Username", cn);
            cmd.Parameters.AddWithValue("@Username", username);
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
            if (string.IsNullOrEmpty(last_NameTextBox.Text))
            {
                MessageBox.Show("Please enter a username to update");
                return;
            }

            string username = last_NameTextBox.Text;
            string fname = first_NameTextBox.Text;
            string lname = last_NameTextBox.Text;
            string password = passwordTextBox.Text;
            string pos = positionComboBox.SelectedItem.ToString();

            cmd = new SqlCommand("UPDATE tblUser SET Full_Name = @Full_Name, Username = @Username, Position = @Position, Password = @Password WHERE Username = @OldUsername", cn);
            cmd.Parameters.AddWithValue("@Full_Name", fname);
            cmd.Parameters.AddWithValue("@Username", lname);
            cmd.Parameters.AddWithValue("@Position", pos);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@OldUsername", username);

            cmd.ExecuteNonQuery();

            MessageBox.Show("User record updated successfully!");

            first_NameTextBox.Text = "";
            last_NameTextBox.Text = "";
            passwordTextBox.Text = "";
            positionComboBox.SelectedIndex = -1;
            GetUserRecord();
        }
    }
}
