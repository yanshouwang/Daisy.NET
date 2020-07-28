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

namespace Heap
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _widows = new List<byte[]>();
        }

        private List<byte[]> _widows;

        private void AddWindow(object sender, RoutedEventArgs e)
        {
                var window = new byte[1024*100*1024];
                _widows.Add(window);
        }

        private void ClearWindow(object sender, RoutedEventArgs e)
        {
            _widows.Clear();
        }
    }
}
