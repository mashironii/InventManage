using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace InventManage
{

    public partial class Login_Form : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;

        public Login_Form()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\InventManage\InventManage\InvDatabase.mdf;Integrated Security=True");

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Emptxtbx.Text == "" && PassTxtBx.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password to log in.");
            }
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }

                string qry = "SELECT Full_Name FROM tblUser WHERE Username = @Username AND Password = @Password";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@Username", Emptxtbx.Text);
                cmd.Parameters.AddWithValue("@Password", PassTxtBx.Text);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string fullName = dr["Full_Name"].ToString();
                    this.Hide();
                    Main_Form main_Form = new Main_Form(fullName);
                    main_Form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterUser_Form reg = new RegisterUser_Form();
            reg.ShowDialog();
        }
    }
}

