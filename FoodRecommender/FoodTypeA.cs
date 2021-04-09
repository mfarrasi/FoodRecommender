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
    public partial class FoodTypeA : Form
    {
        public FoodTypeA()
        {
            InitializeComponent();
        }

        private void FoodTypeA_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSweet_Click(object sender, EventArgs e)
        {
            FoodLibrary.FlavorA myFlavor = new FoodLibrary.FlavorA();
            string flavor = myFlavor.HowHungry("sweet");
            lblRecommend.Text = flavor;
        }
        
        private void btnSavory_Click(object sender, EventArgs e)
        {
            FoodLibrary.FlavorA myFlavor = new FoodLibrary.FlavorA();
            string flavor = myFlavor.HowHungry("salty");
            lblRecommend.Text = flavor;
        }
    }
}
