using InventoryManager.Data.Models;
using InventoryManager.Data.Repositories;
using InventoryManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InventoryManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as MainViewModel;
            viewModel.SelectedCategory.Items.Add(new ItemViewModel()
            {
                Name = "New Item",
            });
        }
    }
}
