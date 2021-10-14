using InventoryManager.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

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
            var viewModel = this.DataContext as MainViewModel;
            viewModel.SelectedCategory.Items.Add(new ItemViewModel()
            {
                Name = "New Item",
            });
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MainViewModel();
        }
    }
}
