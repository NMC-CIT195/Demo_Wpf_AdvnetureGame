﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Demo_Wpf_AdventureGame.Presenters;

namespace Demo_Wpf_AdventureGame.PlayerSetup
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            GameWindowPresenter GameWindowPresenter = new GameWindowPresenter();
        }
    }
}
