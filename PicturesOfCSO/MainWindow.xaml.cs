using DataFromGUS.Interface;
using Microsoft.Extensions.DependencyInjection;
using PicturesOfCSO.ViewModel;
using System.Windows;

namespace PicturesOfCSO
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowModel();
        }
    }
}
