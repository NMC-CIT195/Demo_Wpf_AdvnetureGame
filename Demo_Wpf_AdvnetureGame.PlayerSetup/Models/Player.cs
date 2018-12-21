using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class Player : Character, INotifyPropertyChanged
    {
        #region FIELDS

        private int _age;
        private bool _isGalacticCitizen;
        private int _experiencePoints;

        #endregion

        #region PROPERTIES

        public int Age
        {
            get { return _age; }
            set
            {
               _age = value;
                OnPropertyChanged("Age"); 
            }
        }

        public bool IsGalacticCitizen
        {
            get { return _isGalacticCitizen; }
            set
            {
                _isGalacticCitizen = value;
                OnPropertyChanged("IsGalacticCitizen");
            }
        }
        
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
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
