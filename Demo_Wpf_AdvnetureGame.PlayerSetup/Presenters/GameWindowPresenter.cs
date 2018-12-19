using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_AdventureGame.Models;
using Demo_Wpf_AdventureGame.Views;
using Demo_Wpf_AdventureGame.DataAccessLayer;

namespace Demo_Wpf_AdventureGame.Presenters
{
    public class GameWindowPresenter
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private GameSession _gameSession;
        private GameWindow _gameWindow;

        #endregion

        #region PROPERTIES

        public GameSession GameSession
        {
            get { return _gameSession; }
            set { _gameSession = value; }
        }

        public GameWindow GameWindow
        {
            get { return _gameWindow; }
            set { _gameWindow = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public GameWindowPresenter()
        {
            InitializeGameData();
            InitializeGameWindow();
        }

        private void InitializeGameData()
        {
            _gameSession = new GameSession();
            _gameSession.CurrentPlayer = GetGameObjects.PlayerInformation();
        }

        #endregion

        #region METHODS

        private void ShowOpeningWindow()
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Owner = _gameWindow;
            splashScreen.ShowDialog();
        }

        private void ShowPlayerSetupWindow()
        {
            PlayerSetupWindow playerSetupWindow = new PlayerSetupWindow();
            playerSetupWindow.Owner = _gameWindow;
            playerSetupWindow.DataContext = _gameSession;
            playerSetupWindow.ShowDialog();
        }

        private void InitializeGameWindow()
        {
            _gameSession = new GameSession();

            _gameSession.CurrentPlayer.ShortName = "Bonzo";

            _gameWindow = new GameWindow();
            _gameWindow.DataContext = _gameSession;
            _gameWindow.Show();

            //ShowOpeningWindow();
            ShowPlayerSetupWindow();
        }

        #endregion

        #region EVENTS



        #endregion
    }
}
