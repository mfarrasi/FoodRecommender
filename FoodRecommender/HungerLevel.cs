using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecommender
{
    public partial class HungerLevel : Form
    {
        public HungerLevel()
        {
            InitializeComponent();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            FoodLibrary.Food myFood = new FoodLibrary.Food();
            string showLabel = myFood.HowHungry(Convert.ToDouble(txtHungerLevel.Text));
            lblShow.Text = showLabel;
        }
        
        private void txtHungerLevel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            FoodTypeA f2 = new FoodTypeA();
            f2.Show();
        }

        private void txtHungerLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext1.PerformClick();
            }
        }

        private void btnMore_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            FoodTypeB f3 = new FoodTypeB();
            f3.Show();
        }
    }
}
