using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class Map
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private int _id;
        private string _name;
        private List<Location> _locations;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        public List<Location> AccessibleLocations
        {
            get
            {
                return CalculateAccessibleLocations();
            }
        }

        #endregion

        #region CONSTRUCTORS

        public Map()
        {

        }

        public Map(string name, int maxRows, int maxColumns)
        {
            _name = name;
            _locations = new List<Location>();
        }

        public void AddLocation(Location location)
        {
            if (location != null)
            {
                _locations.Add(location);
            }
        }

        public Location GetLocationById(int id)
        {
            return _locations.FirstOrDefault(l => l.Id == id);
        }

        #endregion

        #region METHODS


        public List<Location> CalculateAccessibleLocations()
        {
            return _locations.Where(l => l.IsAccessible == true).ToList();
        }

        #endregion

        #region EVENTS



        #endregion
    }
}
