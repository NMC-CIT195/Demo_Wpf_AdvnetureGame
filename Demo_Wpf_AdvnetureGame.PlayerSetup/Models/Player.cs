using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class Player : Character
    {
        #region FIELDS

        private int _age;
        private bool _isGalacticCitizen;

        #endregion

        #region PROPERTIES

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool IsGalacticCitizen
        {
            get { return _isGalacticCitizen; }
            set { _isGalacticCitizen = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Player() { }

        public Player(
            int id, 
            string shortName, 
            int age, 
            RaceName race, 
            bool isActive, 
            bool isGalacticCitizen, 
            string militaryStatus,
            MapCoordinates currentLocation) : base(id, shortName, race, isActive, currentLocation)
        {
            _age = age;
            _isGalacticCitizen = isGalacticCitizen;
        }

        #endregion

        #region METHODS

        public string PlayerInfo()
        {
            return $"{_shortName} is a {_race} and is {_age} years old.";
        }

        #endregion

        #region EVENTS



        #endregion
    }
}
