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
using System.Windows.Shapes;
using Demo_Wpf_AdventureGame.Models;

namespace Demo_Wpf_AdventureGame
{
    /// <summary>
    /// Interaction logic for MissionWindow.xaml
    /// </summary>
    public partial class MissionWindow : Window
    {
        public MissionWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowSplashScreen();
        }

        private void ShowSplashScreen()
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Owner = this;
            splashScreen.ShowDialog();

            //Player myPlayer = new Player(1, "Bonzo", 100, Character.RaceName.Human, true, new MapCoordinates(4,5));
            //Console.WriteLine(myPlayer.PlayerInfo());
        }
    }
}
