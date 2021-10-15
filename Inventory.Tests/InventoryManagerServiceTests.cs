using InventoryManager.Services.DTOs;
using InventoryManager.Services.Services;
using NUnit.Framework;

namespace Inventory.Tests
{
    public class InventoryManagerServiceTests
    {
        private static InventoryManagerService inventoryManagerService = new InventoryManagerService();
        private static CategoryDTO firstCategory = inventoryManagerService.GetCategories().ToArray()[0];
        private static ItemDTO firstItem = firstCategory.Items.ToArray()[0];

        [Test]
        public void TestTryDeleteItemWithInvalidCategoryID()
        {

            var res = inventoryManagerService.DeleteItem("Not exist category", firstItem.ID);
            Assert.False(res);
        }

        [Test]
        public void TestTryDeleteItemWithInvalidItemID()
        {
            var res = inventoryManagerService.DeleteItem(firstCategory.ID, "Invalid item");
            Assert.False(res);
        }

        [Test]
        public void TestDeleteItemWithValidData()
        {
            var res = inventoryManagerService.DeleteItem(firstCategory.ID, firstItem.ID);
            Assert.True(res);
        }

        [Test]
        public void TestTrySaveItemWithInvalidCategory()
        {
            var res = inventoryManagerService.Save("Invalid category", "new item ID", "new item", "lorem ipsum...", 19.20, 10, "Type 1");
            Assert.False(res);
        }

        [Test]
        public void TestSaveItemWithValidData()
        {
            var res = inventoryManagerService.Save(firstCategory.ID, firstItem.ID, "new item", "lorem ipsum...", 19.20, 10, "Type 1");
            Assert.True(res);
        }
    }
}