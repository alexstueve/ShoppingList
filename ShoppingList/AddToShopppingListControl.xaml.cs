using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for AddToShopppingListControl.xaml
    /// </summary>
    public partial class AddToShopppingListControl : UserControl
    {
        public AddToShopppingListControl()
        {
            InitializeComponent();

            AddButton.Click += OnAddbuttonClicked;
        }

        public void OnAddbuttonClicked(object sender, RoutedEventArgs e)
        {
            //var data = (ShoppingListData)DataContext;
            if (DataContext is ShoppingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }

        }
    }
}
