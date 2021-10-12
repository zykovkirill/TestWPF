using System.Windows;
using System.Windows.Controls;


namespace Omega.Sales.WPF.CustomControl
{
    /// <summary>
    /// UserControl Позволяющий закрывать TabItem
    /// </summary>
    public partial class CloseableHeaderControl : UserControl
    {
        public CloseableHeaderControl()
        {
            InitializeComponent();
        }
        public CloseableHeaderControl(string str)
        {
            InitializeComponent();
            textHeader.Text = str;
        }
        //TODO:Плохой способ обработки события
        public void closeButton_Click(object sender, RoutedEventArgs e)
        {
            var bt = (Button)sender;
            var sp = (StackPanel)bt.Parent;
            var cls = (CloseableHeaderControl)sp.Parent;
            var ti = (TabItem)cls.Parent;
            ((TabControl)ti.Parent).Items.Remove(ti);
        }

    }
}
