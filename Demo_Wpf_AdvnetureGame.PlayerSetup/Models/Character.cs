using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class Character
    {
        #region ENUMS

        public enum RaceName
        {
            Human,
            Felandrian,
            Zorkanian
        }

        #endregion

        #region FIELDS

        private int _id;
        private string _shortName;
        private bool _isActive;
        private MapCoordinates _currentLocation;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ShortName
        {
            get { return _shortName; }
            set { _shortName = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public MapCoordinates CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(int id, string shortName, MapCoordinates currentLocation)
        {
            _id = id;
            _shortName = shortName;
            _currentLocation = currentLocation;
        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion
    }
}
