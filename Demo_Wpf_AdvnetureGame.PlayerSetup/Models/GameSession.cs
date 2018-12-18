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

        private Player _player;
        private Map _map;


        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public Map Map
        {
            get { return _map; }
            set { _map = value; }
        }

        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion


    }
}
