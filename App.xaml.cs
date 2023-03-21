using MultiSelectionComboBoxExample.ViewModels;
using MultiSelectionComboBoxExample.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MultiSelectionComboBoxExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new ExampleWindow { ViewModel = new ExampleViewModel() };
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Current.MainWindow = mainWindow;

            mainWindow.Show();
        }
        public App()
        {
        }
    }
}
