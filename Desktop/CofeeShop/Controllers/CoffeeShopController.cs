using CofeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Controllers
{
    public class CoffeeShopController
    {

        private List<MenuItem> menu;
        private string menuFilePath = "menu.txt"; // Path to the file to save/load the menu

        public CoffeeShopController()
        {
            menu = new List<MenuItem>();
            LoadMenu();  // Load menu from file on initialization
        }

        public void CreateMenuItem(string itemID, string category, string shortDescription,
                                   string longDescription, decimal retailPrice, decimal costPrice,
                                   string imageURL)
        {
            MenuItem newItem = new MenuItem(itemID, category, shortDescription,
                                            longDescription, retailPrice, costPrice, imageURL);
            menu.Add(newItem);
            SaveMenu();  // Save menu after adding a new item
        }

        public void SaveMenu()
        {
            using (StreamWriter writer = new StreamWriter(menuFilePath))
            {
                foreach (var item in menu)
                {
                    writer.WriteLine($"{item.ItemID},{item.Category},{item.ShortDescription}," +
                                     $"{item.LongDescription},{item.RetailPrice},{item.CostPrice}," +
                                     $"{item.ImageURL}");
                }
            }
        }

        public void LoadMenu()
        {
            if (File.Exists(menuFilePath))
            {
                menu.Clear();
                using (StreamReader reader = new StreamReader(menuFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 7)
                        {
                            MenuItem menuItem = new MenuItem(parts[0], parts[1], parts[2], parts[3],
                                                             Convert.ToDecimal(parts[4]), Convert.ToDecimal(parts[5]),
                                                             parts[6]);
                            menu.Add(menuItem);
                        }
                    }
                }
            }
        }

        public List<MenuItem> GetMenu()
        {
            return menu;
        }
        public List<MenuItem> GetMenuByCategory(string category)
        {
            // Simulated data retrieval based on category
            return menu.Where(item => item.Category == category).ToList();
        }

        public MenuItem GetMenuItemByID(string itemID)
        {
            // Simulated data retrieval based on item ID
            return menu.FirstOrDefault(item => item.ItemID == itemID);
        }

    }
}
