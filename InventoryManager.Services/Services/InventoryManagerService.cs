using InventoryManager.Data.Models;
using InventoryManager.Data.Repositories;
using InventoryManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Services.Services
{
    public class InventoryManagerService
    {
        private CategoriesRepository _categoriesRepository;

        public InventoryManagerService()
        {
            _categoriesRepository = new CategoriesRepository();
        }

        public List<CategoryDTO> GetCategories()
        {
            List<CategoryDTO> res = new List<CategoryDTO>();

            foreach (var cat in _categoriesRepository.GetCategories())
                res.Add(this.CovertCategory(cat));
            
            return res;
        }


        public bool DeleteItem(string categoryID, string itemID)
        {
            return _categoriesRepository.DeleteItem(categoryID, itemID);
        }

        public bool Save(string categoryID, string itemID, string itemName, 
            string itemDescription, double itemPrice, int itemQuantity, string itemType)
        {
            return _categoriesRepository.Save(categoryID, itemID, itemName, itemDescription, itemPrice, itemQuantity, itemType);
        }

        public bool AddItem(string itemID, string itemName, string itemDescription,
            double itemPrice, int itemQuantity, string itemType)
        {

            return false;
        }

        private CategoryDTO CovertCategory(Category category)
        {
            return new CategoryDTO
            {
                ID = category.ID,
                Name = category.Name,
                Description = category.Description,
                Items = category.Items.Select(i => this.CovertItem(i)).ToList(),
                SubCategories = category.SubCategories != null ? category.SubCategories.Select(c => this.CovertCategory(c)).ToList() : null
            };
        }

        private ItemDTO CovertItem(Item item)
        {
            return new ItemDTO
            {
                ID = item.ID,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Quantity = item.Quantity,
                Type = item.Type
            };
        }
    }
}
