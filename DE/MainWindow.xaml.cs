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

namespace DE
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Nav.frame = Mframe;
            Nav.textBlock = TxtB;
            Nav.frame.Navigate(new RequsetPage());
        }

        private void Mframe_ContentRendered(object sender, EventArgs e)
        {
            if (Nav.frame.CanGoBack)
            {
                Back.Visibility = Visibility.Visible;
            }
            else
            {
                Back.Visibility= Visibility.Collapsed;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.GoBack();
        }
    }
}
