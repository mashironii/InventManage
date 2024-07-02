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
    public partial class UcIngredProd : UserControl
    {
        public UcIngredProd()
        {
            InitializeComponent();
        }

        public string IngredientName
        {
            get { return Ingredientlbl.Text; }
            set { Ingredientlbl.Text = value; }
        }

        public string Amount
        {
            get { return AmntLbl.Text; }
            set { AmntLbl.Text = value; }
        }

        public string Unit
        {
            get { return Unitlbl.Text; }
            set { Unitlbl.Text = value; }
        }

        public string MROP
        {
            get { return MROPLBL.Text; }
            set { MROPLBL.Text = value; }
        }

        public void UpdateIndicatorColor(decimal currentAmount, decimal mrop)
        {
            decimal thresholdUpper, thresholdLower;

            if (mrop < 10)
            {
                thresholdUpper = mrop + 1m; // Threshold is 1 less than the MROP for MROPs below 10 kilograms
                thresholdLower = mrop - 1m;
            }
            else
            {
                thresholdUpper = mrop + (mrop * 0.2m); // 20% of MROP
            }

            if (currentAmount > thresholdUpper)
            {
                IndicatorPnl.BackColor = Color.ForestGreen; // Good supply level
            }
            else if (thresholdUpper >= currentAmount && currentAmount >= mrop)
            {
                IndicatorPnl.BackColor = Color.SandyBrown; // Nearing reorder point
            }
            else
            {
                IndicatorPnl.BackColor = Color.Firebrick; // Below threshold, critical level
            }
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IngredLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
