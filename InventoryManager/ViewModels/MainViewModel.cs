using InventoryManager.Services.DTOs;
using InventoryManager.Services.Services;
using InventoryManager.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace InventoryManager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private InventoryManagerService _inventoryManagerService;

        public MainViewModel()
        {
            _inventoryManagerService = new InventoryManagerService();
            InitCategories();
        }

        private ObservableCollection<CategoryViewModel> categories;
        public ObservableCollection<CategoryViewModel> Categories
        {
            get { return categories; }
            set { categories = value; OnPropertyChanged(); }
        }

        private CategoryViewModel selectedCategory;
        public CategoryViewModel SelectedCategory
        {
            get { return selectedCategory; }
            set { selectedCategory = value; OnPropertyChanged(); }
        }

        private ItemViewModel selectedItem;
        public ItemViewModel SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged(); }
        }

        private DelegateCommand<ItemViewModel> deleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                    deleteCommand = new DelegateCommand<ItemViewModel>(
                        (ivm) =>
                        {
                            if(SelectedCategory != null)
                            {
                                //delete from the UI
                                SelectedCategory.Items.Remove(ivm);
                                //delete from repository
                                _inventoryManagerService.DeleteItem(SelectedCategory.ID, ivm.ID);
                            }
                        },
                        (ivm) =>
                        {
                            return ivm != null;
                        });

                return deleteCommand;
            }
        }

        private DelegateCommand<ItemViewModel> saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                    saveCommand = new DelegateCommand<ItemViewModel>(
                        (ivm) =>
                        {
                            if (SelectedCategory != null)
                            {
                                //save in repository
                                _inventoryManagerService
                                .Save(SelectedCategory.ID, ivm.ID, ivm.Name, ivm.Description, ivm.Price, ivm.Quantity, ivm.Type);
                            }
                        },
                        (ivm) =>
                        {
                            return ivm != null;
                        });

                return saveCommand;
            }
        }

        public List<string> Types
        {
            get
            {
                return new List<string>()
                {
                    "Type 1",
                    "Type 2",
                    "Type 3",
                    "Type 4"
                };
            }
        }

        private void InitCategories()
        {
            Categories = new ObservableCollection<CategoryViewModel>();
            var cats = _inventoryManagerService.GetCategories();
            foreach (var cat in cats)
            {
                Categories.Add(CovertCategory(cat));
            }
        }

        private CategoryViewModel CovertCategory(CategoryDTO categoryDTO)
        {
            return new CategoryViewModel
            {
                ID = categoryDTO.ID,
                Name = categoryDTO.Name,
                Description = categoryDTO.Description,
                Items = new ObservableCollection<ItemViewModel>(categoryDTO.Items.Select(i => ConvertItem(i)).ToList()),
                SubCategories = categoryDTO.SubCategories != null ? new ObservableCollection<CategoryViewModel>(categoryDTO.SubCategories.Select(c => CovertCategory(c)).ToList()) : null
            };
        }

        private ItemViewModel ConvertItem(ItemDTO itemDTO)
        {
            return new ItemViewModel
            {
                ID = itemDTO.ID,
                Name = itemDTO.Name,
                Description = itemDTO.Description,
                Price = itemDTO.Price,
                Quantity = itemDTO.Quantity,
                Type = itemDTO.Type
            };
        }
    }
}
