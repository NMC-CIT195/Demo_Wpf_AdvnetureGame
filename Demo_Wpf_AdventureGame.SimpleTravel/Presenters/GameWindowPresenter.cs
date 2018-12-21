using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_AdventureGame.Models;
using Demo_Wpf_AdventureGame.Views;
using Demo_Wpf_AdventureGame.DataAccessLayer;
using System.Windows;

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


        #endregion

        #region METHODS

        /// <summary>
        /// add all initial game data to the GameSession object
        /// </summary>
        private void InitializeGameData()
        {
            _gameSession = new GameSession();

            //
            // method to populate the Player object properties without setup window
            //
            _gameSession.CurrentPlayer = GetGameObjects.PlayerData();
            _gameSession.Map = GetGameObjects.MapData();
            _gameSession.CurrentLocation = _gameSession.Map.Locations.FirstOrDefault(l => l.Id == 1001);
        }

        /// <summary>
        /// display opening splash screen w/ Quit option
        /// </summary>
        private void ShowOpeningWindow()
        {
            OpeningScreen OpeningScreen = new OpeningScreen();
            OpeningScreen.ShowDialog();
        }

        /// <summary>
        /// display the initial player setup window and initialize player properties
        /// </summary>
        private void InitializePlayerSetupWindow()
        {
            PlayerSetupWindow playerSetupWindow = new PlayerSetupWindow();
            playerSetupWindow.Owner = _gameWindow;
            playerSetupWindow.DataContext = _gameSession;
            playerSetupWindow.Show();

            _gameSession.CurrentPlayer.IsActive = true;
        }

        /// <summary>
        /// display the opening window, player setup window, and then the game window
        /// </summary>
        private void InitializeGameWindow()
        {
            _gameWindow = new GameWindow();
            _gameWindow.DataContext = _gameSession;
            _gameWindow.Show();
            _gameWindow.Hide(); // hide game window to show opening window

            ShowOpeningWindow();

           _gameWindow.Show(); // show game window if player does not quit on opening screen
            //InitializePlayerSetupWindow(); 
        }

        #endregion

        #region EVENTS



        #endregion
    }
}
