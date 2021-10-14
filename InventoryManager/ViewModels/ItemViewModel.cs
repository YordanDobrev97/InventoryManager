using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.ViewModels
{
    public class ItemViewModel : ViewModelBase
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged(); }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; OnPropertyChanged(); }
        }


        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }
    }
}
