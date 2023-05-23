using DataFromGUS.Interface;
using DataFromGUS.Service;
using Microsoft.Extensions.DependencyInjection;
using PicturesOfCSO.ViewModel;
using System;
using System.Windows;
using System.Net.Http;
using System.ComponentModel;
using DataFromGUS;

namespace PicturesOfCSO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Container = ConfigureDependencyInjection();
        }

        public IServiceProvider Container { get; }

        IServiceProvider ConfigureDependencyInjection()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IGUSdbwAreaAPIService, GUSdbwAreaAPIService>();
            serviceCollection.AddSingleton<HttpClient>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
