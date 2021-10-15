using InventoryManager.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            //Description.TextTrimming = TextTrimming.CharacterEllipsis;
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var newItem = new ItemViewModel()
            {
                Name = "New Item",
            };

            var viewModel = this.DataContext as MainViewModel;
            viewModel.SelectedCategory.Items.Add(newItem);
            listItems.BorderBrush = Brushes.Red;
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MainViewModel();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            listItems.BorderBrush = Brushes.Gray;
        }
    }
}
