namespace InventManage
{
    partial class Cook_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackCookBtn = new System.Windows.Forms.Button();
            this.Cookbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedListBoxDishes = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackCookBtn);
            this.panel1.Controls.Add(this.Cookbtn);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 68);
            this.panel1.TabIndex = 0;
            // 
            // BackCookBtn
            // 
            this.BackCookBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackCookBtn.Location = new System.Drawing.Point(272, 12);
            this.BackCookBtn.Name = "BackCookBtn";
            this.BackCookBtn.Size = new System.Drawing.Size(170, 45);
            this.BackCookBtn.TabIndex = 2;
            this.BackCookBtn.Text = "Back";
            this.BackCookBtn.UseVisualStyleBackColor = true;
            this.BackCookBtn.Click += new System.EventHandler(this.BackCookBtn_Click);
            // 
            // Cookbtn
            // 
            this.Cookbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cookbtn.Location = new System.Drawing.Point(76, 12);
            this.Cookbtn.Name = "Cookbtn";
            this.Cookbtn.Size = new System.Drawing.Size(190, 45);
            this.Cookbtn.TabIndex = 1;
            this.Cookbtn.Text = "Cook Dishes";
            this.Cookbtn.UseVisualStyleBackColor = true;
            this.Cookbtn.Click += new System.EventHandler(this.Cookbtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkedListBoxDishes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 477);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // checkedListBoxDishes
            // 
            this.checkedListBoxDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxDishes.FormattingEnabled = true;
            this.checkedListBoxDishes.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxDishes.Name = "checkedListBoxDishes";
            this.checkedListBoxDishes.Size = new System.Drawing.Size(505, 469);
            this.checkedListBoxDishes.TabIndex = 0;
            // 
            // Cook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 548);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Cook_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cook_Form";
            this.Load += new System.EventHandler(this.Cook_Form_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox checkedListBoxDishes;
        private System.Windows.Forms.Button BackCookBtn;
        private System.Windows.Forms.Button Cookbtn;
    }
}