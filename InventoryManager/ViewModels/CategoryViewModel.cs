using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.ViewModels
{
    public class CategoryViewModel : ViewModelBase
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

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
        }

        private ObservableCollection<CategoryViewModel> subCategories;
        public ObservableCollection<CategoryViewModel> SubCategories
        {
            get { return subCategories; }
            set { subCategories = value; OnPropertyChanged(); }
        }

        private ObservableCollection<ItemViewModel> items;
        public ObservableCollection<ItemViewModel> Items
        {
            get { return items; }
            set { items = value; OnPropertyChanged(); }
        }
    }
}
