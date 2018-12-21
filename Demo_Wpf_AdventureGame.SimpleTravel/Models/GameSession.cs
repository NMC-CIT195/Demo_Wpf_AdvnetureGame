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
        private Location _currentLocation;
        private List<Location> _locationsVisited;

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

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                if (!HasVisited(value))
                {
                    LocationsVisited.Add(value);
                    _currentPlayer.ExperiencePoints += _currentLocation.ExperiencePoints;
                }
            }
        }

        public List<Location> LocationsVisited
        {
            get { return _locationsVisited; }
            set { _locationsVisited = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public GameSession()
        {
            _currentPlayer = new Player();
            _map = new Map();
            _locationsVisited = new List<Location>();
        }

        #endregion

        #region METHODS

        private bool HasVisited(Location location)
        {
            return _locationsVisited.Contains(location);
        }

        #endregion

        #region EVENTS



        #endregion


    }
}
