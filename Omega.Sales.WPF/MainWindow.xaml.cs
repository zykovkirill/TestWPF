using Omega.Sales.WPF.CustomControl;
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
using Omega.Sales.Domain;

namespace Omega.Sales.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            usrName.Text=new WinAuthentication().GetAutentification().Result.Identity.Name;
        }

        private void partButton_Click(object sender, RoutedEventArgs e)
        {
            string str = ((MenuItem)sender).Header.ToString();
            var tab = new TabItem();
            tab.Header = new CloseableHeaderControl(str);
            var lv = new ListViewPart();
            tab.Content = lv;
            int idx = MainTabControl.Items.Count;
            MainTabControl.SelectedIndex = idx;
            MainTabControl.Items.Add(tab);
            MainTabControl.Items.MoveCurrentToLast();

        }

        private void nomenclatureButton_Click(object sender, RoutedEventArgs e)
        {
            string str = ((MenuItem)sender).Header.ToString();
            var tab = new TabItem();
            tab.Header = new CloseableHeaderControl(str);
            var lv = new ListViewNomenclature();
            tab.Content = lv;
            int idx = MainTabControl.Items.Count;
            MainTabControl.SelectedIndex = idx;
            MainTabControl.Items.Add(tab);
            MainTabControl.Items.MoveCurrentToLast();

        }

        private void usrButton_Click(object sender, RoutedEventArgs e)
        {
            string str = ((MenuItem)sender).Header.ToString();
            var tab = new TabItem();
            tab.Header = new CloseableHeaderControl(str);
            var lv = new UsersControl();
            tab.Content = lv;
            int idx = MainTabControl.Items.Count;
            MainTabControl.SelectedIndex = idx;
            MainTabControl.Items.Add(tab);
            MainTabControl.Items.MoveCurrentToLast();

        }

        private void rolButton_Click(object sender, RoutedEventArgs e)
        {
            string str = ((MenuItem)sender).Header.ToString();
            var tab = new TabItem();
            tab.Header = new CloseableHeaderControl(str);
            var lv = new RolesControl();
            tab.Content = lv;
            int idx = MainTabControl.Items.Count;
            MainTabControl.SelectedIndex = idx;
            MainTabControl.Items.Add(tab);
            MainTabControl.Items.MoveCurrentToLast();

        }
    }
}
