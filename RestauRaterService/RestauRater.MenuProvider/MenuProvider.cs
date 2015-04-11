using RestauRater.MenuProvider.Interfaces;
using RestauRater.Models;
using RestauRater.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestauRater.MenuProvider
{
    public class MenuProvider : IMenuProvider
    {
        public IEnumerable<IMenuItem> GetMenuItems(string category)
        {
            if (string.IsNullOrEmpty(category)) return Enumerable.Empty<IMenuItem>();

            category = category.ToUpper();

            switch(category)
            {
                case "ALL":
                    return GetAllMenuItems();
                case "STARTERS":
                    return GetStarters();
                case "MAINS":
                    return GetMains();
                case "DESSERTS":                    
                    return GetDesserts();
                case "DRINKS":
                    return GetDrinks();
                default:
                    return Enumerable.Empty<IMenuItem>();
            }
        }

        private IEnumerable<IMenuItem> GetAllMenuItems()
        {
            return GetStarters().Concat(GetMains()).Concat(GetDesserts()).Concat(GetDrinks());
        }

        private IEnumerable<IMenuItem> GetStarters()
        {
            return new List<IMenuItem>
            {
                new MenuItem("Soup du Jour", string.Empty, 2.99, "Starter"),
                new MenuItem("Scallops", string.Empty, 3.20, "Starter"),
                new MenuItem("Prawn Cocktail", string.Empty, 4.99, "Starter")
            };
        }

        private IEnumerable<IMenuItem> GetMains()
        {
            return new List<IMenuItem>
            {
                new MenuItem("Roast Belly Pork", string.Empty, 13.99, "Main"),
                new MenuItem("Chicken Tagine", string.Empty, 14.50, "Main"),
                new MenuItem("Lobster Thermadore", string.Empty, 17.50, "Main")
            };
        }

        private IEnumerable<IMenuItem> GetDesserts()
        {
            return new List<IMenuItem>
            {
                new MenuItem("New York Style Cheesecake", string.Empty, 4.50, "Dessert"),
                new MenuItem("Eton Mess", string.Empty, 4.10, "Dessert"),
                new MenuItem("Ice Cream", string.Empty, 2.99, "Dessert"),
                new MenuItem("Cheese Platter", string.Empty, 4.99, "Dessert")
            };
        }

        private IEnumerable<IMenuItem> GetDrinks()
        {
            return new List<IMenuItem>
            {
                new MenuItem("House White", string.Empty, 7.95, "Drink"),
                new MenuItem("House Red", string.Empty, 7.95, "Drink"),
                new MenuItem("Still Water", string.Empty, 4.75, "Drink"),
                new MenuItem("Coke", string.Empty, 3.25, "Drink")
            };
        }
    }
}
