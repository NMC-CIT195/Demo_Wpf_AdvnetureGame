using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class GameSession
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private Player _currentPlayer;
        private Map _map;


        #endregion

        #region PROPERTIES

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
            set { _currentPlayer = value; }
        }

        public Map Map
        {
            get { return _map; }
            set { _map = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public GameSession()
        {
            _currentPlayer = new Player();
            _map = new Map();
        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion


    }
}
