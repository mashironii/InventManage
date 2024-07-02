namespace InventManage
{
    partial class UcIngredProd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Ingredientlbl = new System.Windows.Forms.Label();
            this.AmntLbl = new System.Windows.Forms.Label();
            this.IndicatorPnl = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Unitlbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MROPLBL = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.IndicatorPnl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.MROPLBL);
            this.flowLayoutPanel1.Controls.Add(this.Ingredientlbl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 140);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Ingredientlbl
            // 
            this.Ingredientlbl.BackColor = System.Drawing.Color.Transparent;
            this.Ingredientlbl.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredientlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ingredientlbl.Location = new System.Drawing.Point(3, 0);
            this.Ingredientlbl.Name = "Ingredientlbl";
            this.Ingredientlbl.Size = new System.Drawing.Size(215, 140);
            this.Ingredientlbl.TabIndex = 1;
            this.Ingredientlbl.Text = "Ingredient";
            this.Ingredientlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ingredientlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // AmntLbl
            // 
            this.AmntLbl.BackColor = System.Drawing.Color.Transparent;
            this.AmntLbl.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmntLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AmntLbl.Location = new System.Drawing.Point(0, 0);
            this.AmntLbl.Name = "AmntLbl";
            this.AmntLbl.Size = new System.Drawing.Size(122, 80);
            this.AmntLbl.TabIndex = 0;
            this.AmntLbl.Text = "99";
            this.AmntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IndicatorPnl
            // 
            this.IndicatorPnl.BackColor = System.Drawing.Color.Green;
            this.IndicatorPnl.Controls.Add(this.panel5);
            this.IndicatorPnl.Controls.Add(this.panel4);
            this.IndicatorPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.IndicatorPnl.Location = new System.Drawing.Point(0, 0);
            this.IndicatorPnl.Name = "IndicatorPnl";
            this.IndicatorPnl.Size = new System.Drawing.Size(125, 140);
            this.IndicatorPnl.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Unitlbl);
            this.panel5.Location = new System.Drawing.Point(3, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 43);
            this.panel5.TabIndex = 1;
            // 
            // Unitlbl
            // 
            this.Unitlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Unitlbl.BackColor = System.Drawing.Color.Transparent;
            this.Unitlbl.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unitlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Unitlbl.Location = new System.Drawing.Point(0, 0);
            this.Unitlbl.Name = "Unitlbl";
            this.Unitlbl.Size = new System.Drawing.Size(119, 33);
            this.Unitlbl.TabIndex = 1;
            this.Unitlbl.Text = "Kilogram";
            this.Unitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AmntLbl);
            this.panel4.Location = new System.Drawing.Point(3, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 80);
            this.panel4.TabIndex = 0;
            // 
            // MROPLBL
            // 
            this.MROPLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MROPLBL.BackColor = System.Drawing.Color.Transparent;
            this.MROPLBL.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MROPLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MROPLBL.Location = new System.Drawing.Point(3, 0);
            this.MROPLBL.Name = "MROPLBL";
            this.MROPLBL.Size = new System.Drawing.Size(119, 0);
            this.MROPLBL.TabIndex = 2;
            this.MROPLBL.Text = "MROp";
            this.MROPLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcIngredProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.IndicatorPnl);
            this.Name = "UcIngredProd";
            this.Size = new System.Drawing.Size(352, 140);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.IndicatorPnl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label AmntLbl;
        private System.Windows.Forms.Panel IndicatorPnl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Ingredientlbl;
        private System.Windows.Forms.Label Unitlbl;
        private System.Windows.Forms.Label MROPLBL;
    }
}
