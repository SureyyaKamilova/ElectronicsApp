using ElectronicsApp.ViewModels.Windows;
using ElectronicsApp.Views.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ElectronicsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DashBoard dashBoard = new DashBoard();
            DashBoardViewModel dashBoardViewModel=new DashBoardViewModel();

            dashBoard.DataContext = dashBoardViewModel;

            MainWindow = dashBoard;
            MainWindow.Show();
        }
        
    }
}
