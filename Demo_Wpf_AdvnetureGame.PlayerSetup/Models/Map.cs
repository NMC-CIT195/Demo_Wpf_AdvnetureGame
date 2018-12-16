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
        private int _maxRows;
        private int _maxColumns;
        private Location[,] _locations;

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

        public int MaxRows
        {
            get { return _maxRows; }
            set { _maxRows = value; }
        }

        public int MaxColumns
        {
            get { return _maxColumns; }
            set { _maxColumns = value; }
        }

        public Location[,] Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Map()
        {

        }

        public Map(string name, int maxRows, int maxColumns)
        {
            _name = name;
            _locations = new Location[maxRows, maxColumns];
        }

        public void AddLocation(Location location, int row, int column)
        {
            if (location != null)
            {
                _locations[row, column] = location;
            }

        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion
    }
}
