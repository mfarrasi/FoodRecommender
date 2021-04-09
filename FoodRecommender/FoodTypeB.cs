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
    public partial class FoodTypeB : Form
    {
        public FoodTypeB()
        {
            InitializeComponent();
        }

        private void lblRecommend_Click(object sender, EventArgs e)
        {

        }

        private void FoodTypeB_Load(object sender, EventArgs e)
        {

        }

        private void btnSavory_Click(object sender, EventArgs e)
        {
            FoodLibrary.FlavorB myFlavor = new FoodLibrary.FlavorB();
            string flavor = myFlavor.HowHungry("savory");
            lblRecommend.Text = flavor;
        }

        private void btnFilling_Click(object sender, EventArgs e)
        {
            FoodLibrary.FlavorB myFlavor = new FoodLibrary.FlavorB();
            string flavor = myFlavor.HowHungry("filling");
            lblRecommend.Text = flavor;
        }
    }
}
