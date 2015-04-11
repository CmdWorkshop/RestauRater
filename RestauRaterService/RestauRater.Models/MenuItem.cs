using RestauRater.Models.Interfaces;

namespace RestauRater.Models
{
    public class MenuItem : IMenuItem
    {
        private string name;
        private string description;
        private double price;
        private string category;

        public string Name
        {
            get { return this.name; }
        }

        public string Description
        {
            get { return this.description; }
        }

        public double Price
        {
            get { return this.price; }
        }

        public string Category
        {
            get { return this.category; }
        }

        public MenuItem(string name, string description, double price, string category)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.category = category;           
        }
    }
}
