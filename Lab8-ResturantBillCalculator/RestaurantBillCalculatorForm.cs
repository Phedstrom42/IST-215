using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_ResturantBillCalculator
{
    public partial class RestaurantBillCalculator : Form
    {
        private decimal subTotal = 0M;
        private decimal tip = 0M;
        private decimal tax = 0M;
        private string output;

        private static Dictionary<string, decimal> beverages = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Soda", 1.95m },
            { "Tea", 1.50m },
            { "Coffee", 1.25m },
            { "Mineral Water", 2.95m },
            { "Juice", 2.50m },
            { "Milk", 1.50m }
        };

        private static Dictionary<string, decimal> appetizers = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Buffalo Wings", 5.95m },
            { "Buffalo Fingers", 6.95m },
            { "Potato Skins", 8.95m },
            { "Nachos", 8.95m },
            { "Mashroom Caps", 10.95m },
            { "Shimp Cocktail", 12.95m },
            { "Chips and Salsa", 6.95m }
        };

        private static Dictionary<string, decimal> mainCourses = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Seafood Alfredo", 15.95m },
            { "Chicken Alfredo", 13.95m },
            { "Chicken Picatta", 13.95m },
            { "Turkey Club", 11.95m },
            { "Lobster Pie", 19.95m },
            { "Schrimp Scampi", 18.95m },
            { "Turkey Dinner", 13.95m },
            { "Stuffed Chicken", 14.95m }
        };

        private static Dictionary<string, decimal> desserts = new Dictionary<string, decimal>
        {
            { "None", 0.0m },
            { "Apple Pie", 5.95m },
            { "Sundae", 3.95m },
            { "Carrot Cake", 5.95m },
            { "Mud Pie", 4.95m  },
            { "Apple Crip", 5.95m }
        };


        public RestaurantBillCalculator()
        {
            InitializeComponent();
            nubTipPercent.Value = 15M; // Default tip is 1%
        }// End of contrustcor RestaurantBillCalculator()

        private void RestaurantBillCalculator_Load(object sender, EventArgs e)
        {
            LoadCategory("Beverage", cbBeverage);
            LoadCategory("Appetizer", cbAppetizer);
            LoadCategory("Main Course", cbMainCourse);
            LoadCategory("Dessert", cbDessert);

        }// End of RestaurantBillCalculator_Load(object, EventArgs)

        public void LoadCategory(string categoryString, ComboBox categoryCombo)
        {
            List<string> items = null;

            switch (categoryString)
            {
                case "Beverage":
                    items = beverages.Keys.ToList();
                    break;
                case "Appetizer":
                    items = appetizers.Keys.ToList();
                    break;
                case "Main Course":
                    items = mainCourses.Keys.ToList();
                    break;
                case "Dessert":
                    items = desserts.Keys.ToList();
                    break;
                default:
                    break;
            }// End of switch

            categoryCombo.Items.AddRange(items.ToArray());
        }

        private void cbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cbBeverage.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Beverage", selectedItem);
            output += "\r\n";
            txtItemOutput.Text = output;
        }

        private void cbAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cbAppetizer.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Appetizer", selectedItem);
            output += "\r\n";
            txtItemOutput.Text = output;

        }

        private void cbMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cbMainCourse.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Main Course", selectedItem);
            output += "\r\n";
            txtItemOutput.Text = output;
        }

        private void cbDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Convert.ToString(cbDessert.SelectedItem);
            output += selectedItem.Equals("None") ? "" : selectedItem;

            AddToSubtotal("Dessert", selectedItem);
            output += "\r\n";
            txtItemOutput.Text = output;
        }


        private void AddToSubtotal(string category, string name)
        {
            Dictionary<string, decimal> items = null;

            switch(category)
            {
                case "Beverage":
                    items = beverages;
                    break;
                case "Appetizer":
                    items = appetizers;
                    break;
                case "Main Course":
                    items = mainCourses;
                    break;
                case "Dessert":
                    items = desserts;
                    break;
                default:
                    break;
            }// End of switch

            foreach(var item in items)
            {
                if (item.Key == name)
                    subTotal += item.Value;
            }

            txtSubtotalValue.Text = string.Format($"{subTotal:C}");

            tax = subTotal * 0.09M;
            txtTaxValue.Text = string.Format($"{tax:C}");

            tip = (nubTipPercent.Value / 100) * (subTotal + tax);
            txtTipValue.Text = string.Format($"{tip:C}");

            txtTotalValue.Text = string.Format($"{(subTotal + tax + tip):C}");

        }

        private void btnClearBill_Click(object sender, EventArgs e)
        {
            subTotal = 0M;

            txtSubtotalValue.Text   = "0.00";
            txtTaxValue.Text        = "0.00";
            txtTipValue.Text        = "0.00";
            txtTotalValue.Text      = "0.00";
            txtItemOutput.Text      = string.Empty;
            output                  = string.Empty;

        }

        private void nubTipPercent_ValueChanged(object sender, EventArgs e)
        {
            ReCalculateTip();
        }

        private void ReCalculateTip()
        {
            tip = (nubTipPercent.Value / 100) * (subTotal + tax);
            txtTipValue.Text = tip.ToString("C");
            txtTipValue.Text = string.Format($"{(subTotal + tax + tip):C}");
        }
    }
}
