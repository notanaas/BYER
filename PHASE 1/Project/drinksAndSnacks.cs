using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class drinksAndSnacks : Form
    {
        public drinksAndSnacks()
        {
            InitializeComponent();
        }

        public class drinksandsnacks
        {
            public static double priceSnacks { get; set; }
        }

        private void drinksAndSnacks_Load(object sender, EventArgs e)
        {
            // Add checkboxes for food items
            AddCheckBox("Popcorn - Small", 4.50);
            AddCheckBox("Popcorn - Medium", 6.00);
            AddCheckBox("Popcorn - Large", 7.50);
            AddCheckBox("Nachos with Cheese", 5.50);
            AddCheckBox("Hot Dogs", 4.75);
            AddCheckBox("Pretzel Bites", 3.50);
            AddCheckBox("Chicken Tenders", 6.50);
            AddCheckBox("French Fries", 3.50);
            AddCheckBox("Mozzarella Sticks", 5.00);
            AddCheckBox("Veggie Sticks with Dip", 4.00);
            AddCheckBox("Onion Rings", 4.50);
            AddCheckBox("Candy (Assorted)", 3.00);

            // Add checkboxes for drinks
            AddCheckBox("Soft Drinks - Small", 3.00);
            AddCheckBox("Soft Drinks - Medium", 4.00);
            AddCheckBox("Soft Drinks - Large", 5.00);
            AddCheckBox("Bottled Water", 2.50);
            AddCheckBox("Iced Tea", 3.50);
            AddCheckBox("Fruit Juice", 3.50);
            AddCheckBox("Coffee", 3.00);
            AddCheckBox("Milkshakes", 5.50);
            AddCheckBox("Energy Drinks", 4.50);
            AddCheckBox("Smoothies", 5.00);
            AddCheckBox("Slushies", 4.00);
            AddCheckBox("Hot Chocolate", 3.50);
        }

        private void AddCheckBox(string text, double price)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Text = $"{text} - ${price.ToString("F2")}";
            checkBox.Tag = price;
            checkBox.AutoSize = true;
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            checkBox.BackColor = Color.Transparent;
            checkBox.ForeColor = Color.White;

            flowLayoutPanel1.Controls.Add(checkBox);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                double snackPrice = (double)checkBox.Tag;
                drinksandsnacks.priceSnacks += snackPrice;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            userPage back = new userPage();
            back.Show();
            this.Hide();
        }
    }
}
