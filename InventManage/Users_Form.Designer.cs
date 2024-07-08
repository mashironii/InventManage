namespace InventManage
{
    partial class Users_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label UserIDLabel;
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.UserIDtxtbx = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUserBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.invTablesDatabaseDataSet = new InventManage.InvTablesDatabaseDataSet();
            this.tblUserTableAdapter2 = new InventManage.InvTablesDatabaseDataSetTableAdapters.tblUserTableAdapter();
            this.tblUserBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            UserIDLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.Location = new System.Drawing.Point(5, 239);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(120, 31);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "Full Name:";
            first_NameLabel.Click += new System.EventHandler(this.first_NameLabel_Click);
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.Location = new System.Drawing.Point(5, 155);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(120, 31);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Username:";
            last_NameLabel.Click += new System.EventHandler(this.last_NameLabel_Click);
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            positionLabel.Location = new System.Drawing.Point(332, 90);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(98, 31);
            positionLabel.TabIndex = 7;
            positionLabel.Text = "Position:";
            positionLabel.Click += new System.EventHandler(this.positionLabel_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(332, 185);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(116, 31);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UserIDLabel.Location = new System.Drawing.Point(5, 81);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new System.Drawing.Size(94, 31);
            UserIDLabel.TabIndex = 14;
            UserIDLabel.Text = "User ID:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_NameTextBox.Location = new System.Drawing.Point(11, 273);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(272, 38);
            this.first_NameTextBox.TabIndex = 4;
            this.first_NameTextBox.TextChanged += new System.EventHandler(this.first_NameTextBox_TextChanged);
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_NameTextBox.Location = new System.Drawing.Point(11, 189);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(174, 38);
            this.last_NameTextBox.TabIndex = 6;
            this.last_NameTextBox.TextChanged += new System.EventHandler(this.last_NameTextBox_TextChanged);
            // 
            // positionComboBox
            // 
            this.positionComboBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Cook",
            "Manager",
            "Staff"});
            this.positionComboBox.Location = new System.Drawing.Point(338, 122);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(193, 39);
            this.positionComboBox.TabIndex = 8;
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.positionComboBox_SelectedIndexChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(338, 219);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(193, 38);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddPanel);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 560);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.UserIDtxtbx);
            this.AddPanel.Controls.Add(UserIDLabel);
            this.AddPanel.Controls.Add(this.UpdateBtn);
            this.AddPanel.Controls.Add(this.DelBtn);
            this.AddPanel.Controls.Add(this.first_NameTextBox);
            this.AddPanel.Controls.Add(this.backbtn);
            this.AddPanel.Controls.Add(this.passwordTextBox);
            this.AddPanel.Controls.Add(passwordLabel);
            this.AddPanel.Controls.Add(this.Addbtn);
            this.AddPanel.Controls.Add(first_NameLabel);
            this.AddPanel.Controls.Add(this.last_NameTextBox);
            this.AddPanel.Controls.Add(this.positionComboBox);
            this.AddPanel.Controls.Add(last_NameLabel);
            this.AddPanel.Controls.Add(positionLabel);
            this.AddPanel.Location = new System.Drawing.Point(3, 3);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(593, 87);
            this.AddPanel.TabIndex = 15;
            // 
            // UserIDtxtbx
            // 
            this.UserIDtxtbx.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDtxtbx.Location = new System.Drawing.Point(11, 115);
            this.UserIDtxtbx.Name = "UserIDtxtbx";
            this.UserIDtxtbx.Size = new System.Drawing.Size(174, 38);
            this.UserIDtxtbx.TabIndex = 15;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(218, 21);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(108, 45);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.Location = new System.Drawing.Point(332, 21);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(108, 45);
            this.DelBtn.TabIndex = 12;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(446, 21);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(95, 45);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(38, 21);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(170, 45);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Find User";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Id,
            this.fullNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUserBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 229);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // User_Id
            // 
            this.User_Id.DataPropertyName = "User_Id";
            this.User_Id.FillWeight = 72.72727F;
            this.User_Id.HeaderText = "User_Id";
            this.User_Id.Name = "User_Id";
            this.User_Id.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.FillWeight = 156.3094F;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 215;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 102.578F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 141;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.FillWeight = 68.38535F;
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 94;
            // 
            // tblUserBindingSource4
            // 
            this.tblUserBindingSource4.DataMember = "tblUser";
            this.tblUserBindingSource4.DataSource = this.invTablesDatabaseDataSet;
            // 
            // invTablesDatabaseDataSet
            // 
            this.invTablesDatabaseDataSet.DataSetName = "InvTablesDatabaseDataSet";
            this.invTablesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserTableAdapter2
            // 
            this.tblUserTableAdapter2.ClearBeforeFill = true;
            // 
            // tblUserBindingSource3
            // 
            this.tblUserBindingSource3.DataMember = "tblUser";
            // 
            // tblUserBindingSource1
            // 
            this.tblUserBindingSource1.DataMember = "tblUser";
            // 
            // tblUserBindingSource2
            // 
            this.tblUserBindingSource2.DataMember = "tblUser";
            // 
            // Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 564);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users_Form";
            this.Load += new System.EventHandler(this.Users_Form_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTablesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.BindingSource userBindingSource;

        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Addbtn;

        private System.Windows.Forms.BindingSource tblUserBindingSource;

        private System.Windows.Forms.BindingSource tblUserBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblUserBindingSource2;
        private System.Windows.Forms.BindingSource tblUserBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private InvTablesDatabaseDataSet invTablesDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource4;
        private InvTablesDatabaseDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter2;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.TextBox UserIDtxtbx;
    }
}