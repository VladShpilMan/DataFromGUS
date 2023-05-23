using DataFromGUS.Interface;
using Microsoft.Extensions.DependencyInjection;
using PicturesOfCSO.ViewModel;
using System.Windows.Controls;

namespace PicturesOfCSO.View
{
    public partial class ListCSO : UserControl
    {
        public ListCSO()
        {
            InitializeComponent();

            var container = ((App)App.Current).Container;

            DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(ListCSOViewModel));
        }
    }
}
