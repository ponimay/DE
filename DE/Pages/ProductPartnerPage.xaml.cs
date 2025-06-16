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
    /// Логика взаимодействия для ProductPartnerPage.xaml
    /// </summary>
    public partial class ProductPartnerPage : Page
    {
        public ProductPartnerPage(Partner p)
        {
            InitializeComponent();
            LV.ItemsSource = Connect.con.RequestProduct.Where(x => x.PartnerID == p.PartnerID).ToList();
        }
    }
}
