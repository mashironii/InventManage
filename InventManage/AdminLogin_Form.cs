using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventManage
{
    public partial class AdminLogin_Form : Form
    {
        private Main_Form mainForm;
        public AdminLogin_Form(Main_Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Emptxtbx.Text == "" || PassTxtBx.Text == "")
            {
                MessageBox.Show("Please input admin username and password.");
            }
            else
            {
                if (Emptxtbx.Text == "dollyadmin" && PassTxtBx.Text == "1234")
                {
                    //247, 431 > 247, 106
                    mainForm.ResizeAdminPanel(new Size(247, 468));
                    this.Close();
                } else
                {
                    MessageBox.Show("Invalid admin username or password.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
