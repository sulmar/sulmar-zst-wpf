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
using System.Windows.Threading;
using ZST.WPF.WpfClient.ViewModels;

namespace ZST.WPF.WpfClient
{
    /// <summary>
    /// Interaction logic for ClickerView.xaml
    /// </summary>
    public partial class ClickerView : Page
    {
        private ClickerViewModel viewModel;

        private DispatcherTimer timer;

        public ClickerView()
        {
            InitializeComponent();

            viewModel = new ClickerViewModel();

            timer = new DispatcherTimer();
            timer.Interval = viewModel.PlayingTime;
            timer.Tick += Timer_Tick;

            this.DataContext = viewModel;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            viewModel.StopPlaying();
        }

        private void ChangeCount_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.CanChangeCount())
            {
                viewModel.ChangeCount();
            }
        }

        private void StartPlaying_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            viewModel.StartPlaying();
        }
    }
}
