﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Wpfnavigator.ViewModels;

namespace Wpfnavigator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            App.Current.ShutdownMode = System.Windows.ShutdownMode.OnMainWindowClose;

            MainWindowViewModel context = new MainWindowViewModel();
            Window mainWindow = new MainWindow() { DataContext = context };
            context.SetCurrentViewModel(new Page1());
            //context.SetCurrentViewModel(new Tru01_01_ViewModel());
            mainWindow.Show();

        }
        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            MessageBox.Show(ex.Message, "Thread Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}