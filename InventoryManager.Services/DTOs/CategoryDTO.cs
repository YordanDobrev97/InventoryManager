using InventoryManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Services.DTOs
{
    public class CategoryDTO
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CategoryDTO> SubCategories { get; set; }
        public List<ItemDTO> Items { get; set; }
    }
}
