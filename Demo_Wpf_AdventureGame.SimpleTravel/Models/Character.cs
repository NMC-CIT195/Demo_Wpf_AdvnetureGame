using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class Character : INotifyPropertyChanged
    {
        #region ENUMS



        #endregion

        #region FIELDS

        protected int _id;
        protected string _shortName;
        protected RaceName _race;
        protected bool _isActive;
        protected int _currentLocationId;

        #endregion

        #region PROPERTIES

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ShortName
        {
            get { return _shortName; }
            set
            {
                _shortName = value;
                OnPropertyChanged("ShortName");
            }
        }

        public RaceName Race
        {
            get { return _race; }
            set
            {
                _race = value;
                OnPropertyChanged("Race");
            }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                OnPropertyChanged("IsActive");
            }
        }

        public int CurrentLocationId
        {
            get { return _currentLocationId; }
            set
            {
                _currentLocationId = value;
                OnPropertyChanged("CurrentLocation");
            }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(
            int id,
            string shortName,
            RaceName race,
            bool isActive,
            int currentLocationId)
        {
            _id = id;
            _shortName = shortName;
            _race = race;
            _isActive = isActive;
            _currentLocationId = currentLocationId;
        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
