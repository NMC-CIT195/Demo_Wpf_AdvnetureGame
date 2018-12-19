using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class Character
    {
        protected int _id;
        protected string _shortName;
        protected RaceName _race;
        protected bool _isActive;
        protected MapCoordinates _currentLocation;

        public virtual int Id { get; set; }
        public virtual string ShortName { get; set; }
        public virtual RaceName Race { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual MapCoordinates CurrentLocation { get; set; }

        public Character()
        {

        }

        public Character(
            int id, 
            string shortName, 
            RaceName race,
            bool isActive,
            MapCoordinates currentLocation)
        {
            _id = id;
            _shortName = shortName;
            _race = race;
            _isActive = isActive;
            _currentLocation = currentLocation;
        }
    }
}
