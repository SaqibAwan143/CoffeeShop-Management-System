using CofeeShop.Controllers;
using CofeeShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeeShop.Views
{
    public partial class MenuDisplayForm : Form
    {
        private CoffeeShopController coffeeShopController;
        public MenuDisplayForm(CoffeeShopController controller)
        {
            coffeeShopController = controller;

            // Initialize UI elements and set up event handlers
            InitializeComponent();

            // Populate the ListView with menu items
            PopulateMenuItems();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            /*label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;*/
        }
        private void PopulateMenuItems()
        {
            // Clear existing items in the ListView
            listViewMenu.Items.Clear();

            // Get the menu from the CoffeeShopController
            List<MenuItem> menu = coffeeShopController.GetMenu();

            // Populate the ListView with menu items
            foreach (var item in menu)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemID);
                listViewItem.SubItems.Add(item.ShortDescription);
                listViewItem.SubItems.Add(item.Category);
                listViewItem.SubItems.Add(item.RetailPrice.ToString());
                listViewMenu.Items.Add(listViewItem);
            }
        }




        private void UpdateListView(List<MenuItem> menuItems)
        {
            // Clear existing items in the ListView
            listViewMenu.Items.Clear();

            // Populate the ListView with menu items
            foreach (var item in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemID);
                listViewItem.SubItems.Add(item.ShortDescription);
                listViewItem.SubItems.Add(item.Category);
                listViewItem.SubItems.Add(item.RetailPrice.ToString());
                listViewMenu.Items.Add(listViewItem);


            }
        }
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (listViewMenu.SelectedItems.Count == 1)
            {
                // Get the selected menu item's ID
                string selectedItemID = listViewMenu.SelectedItems[0].Text;

                // Get the menu item from the CoffeeShopController
                MenuItem selectedItem = coffeeShopController.GetMenuItemByID(selectedItemID);
                ShowItem f = new ShowItem(selectedItem);
                f.ShowDialog();
                // Display details of the selected item (you can choose how to display this information)
                //MessageBox.Show($"Item ID: {selectedItem.ItemID}\n" +
                //                $"Category: {selectedItem.Category}\n" +
                //                $"Short Description: {selectedItem.ShortDescription}\n" +
                //                $"Long Description: {selectedItem.LongDescription}\n" +
                //                $"Retail Price: {selectedItem.RetailPrice:C}\n" +
                //                $"Cost Price: {selectedItem.CostPrice:C}\n" +
                //                $"Image URL: {selectedItem.ImageURL}",
                //                "Item Details");
            }
            else
            {
                MessageBox.Show("Please select an item to view details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the selected category
            comboBoxCategory.SelectedIndex = -1;

            // Reload all menu items
            PopulateMenuItems();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();

            // Get the menu items based on the selected category
            List<MenuItem> filteredMenu = coffeeShopController.GetMenuByCategory(selectedCategory);

            // Update the ListView with the filtered menu items
            UpdateListView(filteredMenu);
        }

        private void MenuDisplayForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
