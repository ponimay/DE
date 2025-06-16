using DE.AppData;
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

namespace DE.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Partner pa;
        bool isNew;
        public AddEditPage(Partner partner)
        {
            InitializeComponent();
            CMB.ItemsSource = Connect.con.PartnerType.ToList();
            if(partner == null)
            {
                partner = new Partner();
                isNew = true;
            }
            else
            {
                pa = partner;
                isNew = false;
            }
            DataContext = pa = partner;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (isNew)
            {
                Connect.con.Partner.Add(pa);
            }
            try
            {
                Connect.con.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Nav.frame.GoBack();
        }
    }
}
