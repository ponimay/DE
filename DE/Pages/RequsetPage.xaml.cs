using DE.AppData;
using DE.Pages;
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

namespace DE
{
    /// <summary>
    /// Логика взаимодействия для RequsetPage.xaml
    /// </summary>
    public partial class RequsetPage : Page
    {
        public RequsetPage()
        {
            InitializeComponent();
            Nav.textBlock.Text = "Страница заявки";
        }

        private void LV_Loaded(object sender, RoutedEventArgs e)
        {
            LV.ItemsSource = Connect.con.Partner.ToList();
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Nav.frame.Navigate(new AddEditPage(LV.SelectedItem as Partner));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.Navigate(new AddEditPage(null));
        }

        private void Prod_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.Navigate(new ProductPartnerPage((sender as Button).DataContext as Partner));

        }
    }
}
