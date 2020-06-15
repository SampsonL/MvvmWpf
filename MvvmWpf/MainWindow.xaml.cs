using MvvmWpf.ViewModels;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmWpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        private void Border_TextBlock_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.B)
            {
                Border_TextBlock.Background = Brushes.Blue;
            }
            else if (e.Key == Key.R)
            {
                Border_TextBlock.Background = Brushes.Red;
            }
            else if (e.Key == Key.L)
            {
                Border_TextBlock.Background = Brushes.LightBlue;
            }
        }
    }
}
