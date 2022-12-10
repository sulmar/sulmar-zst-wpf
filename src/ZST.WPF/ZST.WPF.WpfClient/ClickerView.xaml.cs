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
using ZST.WPF.WpfClient.ViewModels;

namespace ZST.WPF.WpfClient
{
    /// <summary>
    /// Interaction logic for ClickerView.xaml
    /// </summary>
    public partial class ClickerView : Page
    {
        private ClickerViewModel viewModel;

        public ClickerView()
        {
            InitializeComponent();

            viewModel = new ClickerViewModel();

            this.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ChangeCount();
        }
    }
}
