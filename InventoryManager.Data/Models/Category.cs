using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Data.Models
{
    public class Category
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> SubCategories { get; set; }
        public List<Item> Items { get; set; }
    }
}
