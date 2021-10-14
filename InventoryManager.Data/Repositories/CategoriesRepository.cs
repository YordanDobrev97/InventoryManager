using InventoryManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager.Data.Repositories
{
    public class CategoriesRepository
    {
        private static List<Category> category_db = new List<Category>
        {
            new Category
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Category 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Items = new List<Item>
                {
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 3",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 4",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 2",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 5",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 6",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 3",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 7",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 2",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 8",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 2",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 9",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 3",
                        Price = 123.22,
                        Quantity = 100,
                    },
                },
                SubCategories = new List<Category>
                {
                    new Category
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = " Sub Category 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Items = new List<Item>
                        {
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 1",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 2",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 3",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 4",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 2",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 5",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 6",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 3",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 7",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 2",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 8",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 2",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 9",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 3",
                                Price = 123.22,
                                Quantity = 100,
                            },
                        }
                    }
                }
            },
            new Category
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Category 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Items = new List<Item>
                {
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 3",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 4",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 2",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 5",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 1",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 6",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 3",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 7",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 2",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 8",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 2",
                        Price = 123.22,
                        Quantity = 100,
                    },
                    new Item
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = "item 9",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Type = "Type 3",
                        Price = 123.22,
                        Quantity = 100,
                    },
                },
                SubCategories = new List<Category>
                {
                    new Category
                    {
                        ID = Guid.NewGuid().ToString(),
                        Name = " Sub Category 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Items = new List<Item>
                        {
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 1",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 2",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 3",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 4",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 2",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 5",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 1",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 6",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 3",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 7",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 2",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 8",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 2",
                                Price = 123.22,
                                Quantity = 100,
                            },
                            new Item
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = "item 9",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Type = "Type 3",
                                Price = 123.22,
                                Quantity = 100,
                            },
                        }
                    }
                }
            }
        };

        public bool DeleteItem(string categoryID, string itemID)
        {
            var category = this.FindCategory(categoryID);
            var item = category.Items.FirstOrDefault(x => x.ID == itemID);
            return category.Items.Remove(item);
        }

        public bool Save(string categoryID,
            string itemID, string itemName, string itemDescription, double itemPrice, int itemQuantity, string itemType)
        {
            var category = this.FindCategory(categoryID);

            if (category == null) return false;

            if (itemID != null)
            {
                category.Items.RemoveAll(x => x.ID == itemID);
            }

            category.Items.Add(new Item()
            {
                ID = Guid.NewGuid().ToString(),
                Name = itemName,
                Description = itemDescription,
                Price = itemPrice,
                Quantity = itemQuantity,
                Type = itemType,
            });

            return true;
        }

        public List<Category> GetCategories()
        {
            return category_db;
        }

        public List<string> SupportedItemsType()
        {
            return new List<string>
            {
                "Type 1",
                "Type 2",
                "Type 3",
                "Type 4",
            };
        }

        private Category FindCategory(string categoryId)
        {
            Category foundedCategory = null;

            foreach (var currentCategory in category_db)
            {
                var allCategories = new Queue<Category>();
                allCategories.Enqueue(currentCategory);

                while (allCategories.Count > 0)
                {
                    var category = allCategories.Dequeue();
                    if (category.ID == categoryId)
                    {
                        foundedCategory = category;
                        break;
                    }

                    if (category.SubCategories != null)
                    {
                        foreach (var subCategory in category.SubCategories)
                        {
                            allCategories.Enqueue(subCategory);
                        }
                    }
                }
            }

            return foundedCategory;
        }
    }
}
